namespace GrafischeApplicaties
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFilename = new System.Windows.Forms.TextBox();
            this.BtnOpenFileDialog = new System.Windows.Forms.Button();
            this.BtnParse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filename:";
            // 
            // TxtFilename
            // 
            this.TxtFilename.Location = new System.Drawing.Point(76, 6);
            this.TxtFilename.Name = "TxtFilename";
            this.TxtFilename.Size = new System.Drawing.Size(341, 23);
            this.TxtFilename.TabIndex = 1;
            // 
            // BtnOpenFileDialog
            // 
            this.BtnOpenFileDialog.Location = new System.Drawing.Point(423, 6);
            this.BtnOpenFileDialog.Name = "BtnOpenFileDialog";
            this.BtnOpenFileDialog.Size = new System.Drawing.Size(24, 23);
            this.BtnOpenFileDialog.TabIndex = 2;
            this.BtnOpenFileDialog.Text = "...";
            this.BtnOpenFileDialog.UseVisualStyleBackColor = true;
            this.BtnOpenFileDialog.Click += new System.EventHandler(this.BtnOpenFileDialog_Click);
            // 
            // BtnParse
            // 
            this.BtnParse.Location = new System.Drawing.Point(372, 35);
            this.BtnParse.Name = "BtnParse";
            this.BtnParse.Size = new System.Drawing.Size(75, 23);
            this.BtnParse.TabIndex = 3;
            this.BtnParse.Text = "Parse!";
            this.BtnParse.UseVisualStyleBackColor = true;
            this.BtnParse.Click += new System.EventHandler(this.BtnParse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 382);
            this.Controls.Add(this.BtnParse);
            this.Controls.Add(this.BtnOpenFileDialog);
            this.Controls.Add(this.TxtFilename);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtFilename;
        private Button BtnOpenFileDialog;
        private Button BtnParse;
    }
}