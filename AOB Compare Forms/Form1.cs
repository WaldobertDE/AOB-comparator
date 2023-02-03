using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace AOBCompare
{
    
    public partial class Form1 : MaterialForm
    {
        Stopwatch sw;
        AOBResult result = new AOBResult();
        List<string> AOBList = new List<string>();

        
        public Form1()
        {
            InitializeComponent();

            var msm = MaterialSkinManager.Instance;
            msm.AddFormToManage(this);
            msm.Theme = MaterialSkinManager.Themes.DARK;
            msm.ColorScheme = new ColorScheme(Primary.Green400, Primary.Red500, Primary.Grey900, Accent.Green400, TextShade.WHITE);

            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            backgroundWorker1.WorkerReportsProgress = true;


            ShowStatus("Add at least 2 lines of bytes and hit Compare!");
        }

        [STAThread]
        void CopyResultToClipboard(string result)
        {
            Clipboard.SetText(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw = new Stopwatch();
            AOBList.Clear();
            if (InputCheck())
            {
                btnCompare.Enabled = false;
                InputBox.ReadOnly = true;


                foreach (var item in InputBox.Lines)
                {
                    if (string.IsNullOrEmpty(item) || string.IsNullOrWhiteSpace(item))
                    {
                        break;
                    }
                    AOBList.Add(item.ToUpper().Replace(" ", ""));
                }
                
                backgroundWorker1.RunWorkerAsync(result);
                sw.Restart();

                ShowStatus("Comparing...");
            }            
            
        }

        bool InputCheck()
        {

            if (InputBox.TextLength == 0 || InputBox.TextLength == 1 || InputBox.TextLength == 0 || InputBox.Lines.Count() == 0 || InputBox.Lines.Count() == 1)
            {
                ShowStatus("Please fill something in...");
                return false;
            }

            var length = InputBox.Lines[0].Replace(" ", "").Trim().Length;
            foreach (var line in InputBox.Lines)
            {
                if (line.Replace(" ", "").Trim().Length != length)
                {
                    if (string.IsNullOrEmpty(line) || string.IsNullOrWhiteSpace(line))
                    {
                        break;
                    }
                    ShowStatus("Check for empty, shorter or longer lines!");
                    return false;
                }
            } 
            return true;
        }

        string CompareAOB()
        {
            List<char> outputList = new List<char>();
            List<char> rowChars = new List<char>();
            for (int _char = 0; _char < AOBList.First().Length; _char++)
            {
                for (int row = 0; row < AOBList.Count; row++)
                {
                    rowChars.Add(AOBList[row][_char]);
                }

                outputList.Add(CompareListContents(rowChars, AOBList.First()[_char]));
                rowChars.Clear();

                try
                {                    
                    double currentPos = _char;
                    double firstLength = AOBList.First().Length;
                    int progress = (int)(currentPos / firstLength * 100);

                    backgroundWorker1.ReportProgress(progress);
                }
                catch (Exception)
                {
                }
                

            }
            backgroundWorker1.ReportProgress(100);
            return String.Join("", outputList);
        }

        int GetChangedHalfBytes(string output)
        {
            return output.Count(c => (c == '?'));
        }

        int GetChangedBytes(string output)
        {
            return output.Count(c => (c == '?'))/2;
        }



        void ShowStatus(string msg)
        {
            statusStrip1.Items[0].Text = msg;
        }

        char CompareListContents(List<char> list, char c)
        {
            bool equal = list.Distinct().Count() == 1;

            if (equal)
            {                
                return c;                
            }
            else
            {                
                return '?';                
            }
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            AOBResult result = e.Result as AOBResult;
            var output = Regex.Replace(result.filteredAOB, ".{2}", "$0 ").TrimEnd(' ');

            string msg = "";
            if (cbMode.Checked)
            {
                sw.Stop();
                double elapsedTime = double.Parse(string.Format("{0}e-3", sw.ElapsedMilliseconds)); //evil lol
                var spaces = output.Count(c => (c == ' '));
                msg = $"Got {GetChangedHalfBytes(output)} differences out of {output.Length - spaces} half-bytes. Took {elapsedTime} seconds.";
            }
            else
            {
                string[] bytes = output.TrimEnd(' ').Split(' ');

                for (int i = 0; i < bytes.Length; i++)
                {
                    if (bytes[i].Contains("?"))
                    {
                        bytes[i] = "??";
                    }
                }

                output = string.Join(" ", bytes).ToString().TrimEnd(' ');
                var spaces = output.Count(c => (c == ' '));
                sw.Stop();
                double elapsedTime = double.Parse(string.Format("{0}e-3", sw.ElapsedMilliseconds)); //evil lol
                msg = $"Got {GetChangedBytes(output)} differences out of {(output.Length - spaces)/2} bytes. Took {elapsedTime} seconds.";

            }

            outputBox.Text = output.TrimEnd(' ');

            if (cbClipboard.Checked) CopyResultToClipboard(output);
            
            ShowStatus(msg);
            btnCompare.Enabled = true;
            InputBox.ReadOnly = false;

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            materialProgressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            AOBResult result = e.Argument as AOBResult;
            result.filteredAOB = CompareAOB();
            e.Result = result;
        }

        private void cbTopMost_CheckedChanged(object sender, EventArgs e)
        {
            var x = sender as MaterialCheckbox;
            if (x.Checked)
            {
                ActiveForm.TopMost = true;
            }
            else
            {
                ActiveForm.TopMost = false;
            }
        }
    }

    public class AOBResult
    {
        public string filteredAOB { get; set; }
    }

}
