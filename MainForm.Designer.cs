namespace bnifty.AssemblyVersionTool
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
            this.txtAssemblyVersion = new System.Windows.Forms.TextBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuildDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAssemblyVersion
            // 
            this.txtAssemblyVersion.Location = new System.Drawing.Point(105, 11);
            this.txtAssemblyVersion.Name = "txtAssemblyVersion";
            this.txtAssemblyVersion.Size = new System.Drawing.Size(133, 20);
            this.txtAssemblyVersion.TabIndex = 0;
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(163, 77);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(75, 23);
            this.cmdCalculate.TabIndex = 1;
            this.cmdCalculate.Text = "Berekenen";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Build datum:";
            // 
            // lblBuildDate
            // 
            this.lblBuildDate.AutoSize = true;
            this.lblBuildDate.Location = new System.Drawing.Point(102, 48);
            this.lblBuildDate.Name = "lblBuildDate";
            this.lblBuildDate.Size = new System.Drawing.Size(0, 13);
            this.lblBuildDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assembly versie:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 108);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBuildDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.txtAssemblyVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Assembly version tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssemblyVersion;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBuildDate;
        private System.Windows.Forms.Label label3;
    }
}

