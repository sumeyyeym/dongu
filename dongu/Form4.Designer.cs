namespace dongu
{
    partial class Form4
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
            this.btnOrn1 = new System.Windows.Forms.Button();
            this.btnOrn2 = new System.Windows.Forms.Button();
            this.btnOrn3 = new System.Windows.Forms.Button();
            this.btnOrn4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOrn1
            // 
            this.btnOrn1.Location = new System.Drawing.Point(12, 12);
            this.btnOrn1.Name = "btnOrn1";
            this.btnOrn1.Size = new System.Drawing.Size(246, 23);
            this.btnOrn1.TabIndex = 0;
            this.btnOrn1.Text = "Dizinin Elemanlarını At";
            this.btnOrn1.UseVisualStyleBackColor = true;
            this.btnOrn1.Click += new System.EventHandler(this.BtnOrn1_Click);
            // 
            // btnOrn2
            // 
            this.btnOrn2.Location = new System.Drawing.Point(12, 41);
            this.btnOrn2.Name = "btnOrn2";
            this.btnOrn2.Size = new System.Drawing.Size(246, 23);
            this.btnOrn2.TabIndex = 1;
            this.btnOrn2.Text = "2\'ye Bölünenler";
            this.btnOrn2.UseVisualStyleBackColor = true;
            this.btnOrn2.Click += new System.EventHandler(this.BtnOrn2_Click);
            // 
            // btnOrn3
            // 
            this.btnOrn3.Location = new System.Drawing.Point(12, 70);
            this.btnOrn3.Name = "btnOrn3";
            this.btnOrn3.Size = new System.Drawing.Size(246, 23);
            this.btnOrn3.TabIndex = 2;
            this.btnOrn3.Text = "ListBox1\'den ListBox2\'ye";
            this.btnOrn3.UseVisualStyleBackColor = true;
            this.btnOrn3.Click += new System.EventHandler(this.BtnOrn3_Click);
            // 
            // btnOrn4
            // 
            this.btnOrn4.Location = new System.Drawing.Point(12, 99);
            this.btnOrn4.Name = "btnOrn4";
            this.btnOrn4.Size = new System.Drawing.Size(246, 23);
            this.btnOrn4.TabIndex = 3;
            this.btnOrn4.Text = "Renk";
            this.btnOrn4.UseVisualStyleBackColor = true;
            this.btnOrn4.Click += new System.EventHandler(this.BtnOrn4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(138, 128);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 246);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOrn4);
            this.Controls.Add(this.btnOrn3);
            this.Controls.Add(this.btnOrn2);
            this.Controls.Add(this.btnOrn1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrn1;
        private System.Windows.Forms.Button btnOrn2;
        private System.Windows.Forms.Button btnOrn3;
        private System.Windows.Forms.Button btnOrn4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}