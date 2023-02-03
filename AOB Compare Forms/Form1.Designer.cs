
namespace AOBCompare
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.InputBox = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.cbClipboard = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.btnCompare = new MaterialSkin.Controls.MaterialButton();
            this.outputBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbMode = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbTopMost = new MaterialSkin.Controls.MaterialCheckbox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputBox.Depth = 0;
            this.InputBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.InputBox.Location = new System.Drawing.Point(6, 33);
            this.InputBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(543, 262);
            this.InputBox.TabIndex = 9;
            this.InputBox.Text = "";
            this.InputBox.WordWrap = false;
            // 
            // cbClipboard
            // 
            this.cbClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClipboard.AutoSize = true;
            this.cbClipboard.Depth = 0;
            this.cbClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClipboard.Location = new System.Drawing.Point(3, 368);
            this.cbClipboard.Margin = new System.Windows.Forms.Padding(0);
            this.cbClipboard.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbClipboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbClipboard.Name = "cbClipboard";
            this.cbClipboard.ReadOnly = false;
            this.cbClipboard.Ripple = true;
            this.cbClipboard.Size = new System.Drawing.Size(202, 37);
            this.cbClipboard.TabIndex = 10;
            this.cbClipboard.Text = "Copy result to clipboard";
            this.cbClipboard.UseVisualStyleBackColor = true;
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(6, 354);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(543, 5);
            this.materialProgressBar1.Step = 1;
            this.materialProgressBar1.TabIndex = 11;
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompare.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnCompare.Depth = 0;
            this.btnCompare.HighEmphasis = true;
            this.btnCompare.Icon = null;
            this.btnCompare.Location = new System.Drawing.Point(457, 368);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompare.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCompare.Size = new System.Drawing.Size(91, 36);
            this.btnCompare.TabIndex = 12;
            this.btnCompare.Text = "Compare";
            this.btnCompare.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnCompare.UseAccentColor = false;
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputBox
            // 
            this.outputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBox.AnimateReadOnly = false;
            this.outputBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.outputBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.outputBox.Depth = 0;
            this.outputBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.HideSelection = true;
            this.outputBox.LeadingIcon = null;
            this.outputBox.Location = new System.Drawing.Point(6, 300);
            this.outputBox.MaxLength = 32767;
            this.outputBox.MouseState = MaterialSkin.MouseState.OUT;
            this.outputBox.Name = "outputBox";
            this.outputBox.PasswordChar = '\0';
            this.outputBox.PrefixSuffixText = null;
            this.outputBox.ReadOnly = true;
            this.outputBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.outputBox.SelectedText = "";
            this.outputBox.SelectionLength = 0;
            this.outputBox.SelectionStart = 0;
            this.outputBox.ShortcutsEnabled = true;
            this.outputBox.Size = new System.Drawing.Size(543, 48);
            this.outputBox.TabIndex = 13;
            this.outputBox.TabStop = false;
            this.outputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.outputBox.TrailingIcon = null;
            this.outputBox.UseSystemPasswordChar = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(3, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(549, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(91, 17);
            this.statusLabel.Text = "Hello there!";
            // 
            // cbMode
            // 
            this.cbMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMode.AutoSize = true;
            this.cbMode.Depth = 0;
            this.cbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMode.Location = new System.Drawing.Point(205, 368);
            this.cbMode.Margin = new System.Windows.Forms.Padding(0);
            this.cbMode.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbMode.Name = "cbMode";
            this.cbMode.ReadOnly = false;
            this.cbMode.Ripple = true;
            this.cbMode.Size = new System.Drawing.Size(144, 37);
            this.cbMode.TabIndex = 15;
            this.cbMode.Text = "Half-Byte mode";
            this.cbMode.UseVisualStyleBackColor = true;
            // 
            // cbTopMost
            // 
            this.cbTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTopMost.AutoSize = true;
            this.cbTopMost.Depth = 0;
            this.cbTopMost.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTopMost.Location = new System.Drawing.Point(349, 368);
            this.cbTopMost.Margin = new System.Windows.Forms.Padding(0);
            this.cbTopMost.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbTopMost.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbTopMost.Name = "cbTopMost";
            this.cbTopMost.ReadOnly = false;
            this.cbTopMost.Ripple = true;
            this.cbTopMost.Size = new System.Drawing.Size(99, 37);
            this.cbTopMost.TabIndex = 16;
            this.cbTopMost.Text = "Topmost";
            this.cbTopMost.UseVisualStyleBackColor = true;
            this.cbTopMost.CheckedChanged += new System.EventHandler(this.cbTopMost_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 439);
            this.Controls.Add(this.cbTopMost);
            this.Controls.Add(this.cbMode);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.materialProgressBar1);
            this.Controls.Add(this.cbClipboard);
            this.Controls.Add(this.InputBox);
            this.DrawerHighlightWithAccent = false;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(555, 439);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AOB comparator";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox InputBox;
        private MaterialSkin.Controls.MaterialCheckbox cbClipboard;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private MaterialSkin.Controls.MaterialButton btnCompare;
        private MaterialSkin.Controls.MaterialTextBox2 outputBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private MaterialSkin.Controls.MaterialCheckbox cbMode;
        private MaterialSkin.Controls.MaterialCheckbox cbTopMost;
    }
}

