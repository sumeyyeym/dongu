namespace dongu
{
    partial class Form3
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
            this.btnW = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(12, 12);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(75, 41);
            this.btnW.TabIndex = 0;
            this.btnW.Text = "while";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.BtnW_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(12, 66);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 41);
            this.btnD.TabIndex = 1;
            this.btnD.Text = "dowhile";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.BtnD_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(93, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 121);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnW);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.ListBox listBox1;
    }
}