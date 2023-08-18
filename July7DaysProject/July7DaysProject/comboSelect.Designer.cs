namespace July7DaysProject
{
    partial class comboSelect
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
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb4 = new System.Windows.Forms.ComboBox();
            this.ch1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb3
            // 
            this.cb3.FormattingEnabled = true;
            this.cb3.Location = new System.Drawing.Point(26, 58);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(237, 21);
            this.cb3.TabIndex = 0;
            this.cb3.SelectedIndexChanged += new System.EventHandler(this.cb3_SelectedIndexChanged);
            // 
            // cb4
            // 
            this.cb4.FormattingEnabled = true;
            this.cb4.Location = new System.Drawing.Point(323, 58);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(243, 21);
            this.cb4.TabIndex = 1;
            // 
            // ch1
            // 
            this.ch1.Location = new System.Drawing.Point(245, 152);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(75, 23);
            this.ch1.TabIndex = 2;
            this.ch1.Text = "Choose";
            this.ch1.UseVisualStyleBackColor = true;
            this.ch1.Click += new System.EventHandler(this.ch1_Click);
            // 
            // comboSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 367);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Name = "comboSelect";
            this.Text = "comboTest";
            this.Load += new System.EventHandler(this.comboSelect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb4;
        private System.Windows.Forms.Button ch1;
    }
}