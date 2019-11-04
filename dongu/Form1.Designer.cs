namespace dongu
{
    partial class Form1
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
            this.btnCift = new System.Windows.Forms.Button();
            this.btnAZ = new System.Windows.Forms.Button();
            this.btnToplam = new System.Windows.Forms.Button();
            this.btnIslem = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOrn1
            // 
            this.btnOrn1.Location = new System.Drawing.Point(12, 12);
            this.btnOrn1.Name = "btnOrn1";
            this.btnOrn1.Size = new System.Drawing.Size(133, 25);
            this.btnOrn1.TabIndex = 0;
            this.btnOrn1.Text = "1 - 1000";
            this.btnOrn1.UseVisualStyleBackColor = true;
            this.btnOrn1.Click += new System.EventHandler(this.BtnOrn1_Click);
            // 
            // btnOrn2
            // 
            this.btnOrn2.Location = new System.Drawing.Point(12, 41);
            this.btnOrn2.Name = "btnOrn2";
            this.btnOrn2.Size = new System.Drawing.Size(133, 25);
            this.btnOrn2.TabIndex = 1;
            this.btnOrn2.Text = "1000 - 1";
            this.btnOrn2.UseVisualStyleBackColor = true;
            this.btnOrn2.Click += new System.EventHandler(this.BtnOrn2_Click);
            // 
            // btnCift
            // 
            this.btnCift.Location = new System.Drawing.Point(12, 70);
            this.btnCift.Name = "btnCift";
            this.btnCift.Size = new System.Drawing.Size(133, 25);
            this.btnCift.TabIndex = 2;
            this.btnCift.Text = "1 - 1000 Çift Sayılar";
            this.btnCift.UseVisualStyleBackColor = true;
            this.btnCift.Click += new System.EventHandler(this.BtnCift_Click);
            // 
            // btnAZ
            // 
            this.btnAZ.Location = new System.Drawing.Point(12, 99);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(133, 25);
            this.btnAZ.TabIndex = 3;
            this.btnAZ.Text = "A-Z\'ye Alfabe";
            this.btnAZ.UseVisualStyleBackColor = true;
            this.btnAZ.Click += new System.EventHandler(this.BtnAZ_Click);
            // 
            // btnToplam
            // 
            this.btnToplam.Location = new System.Drawing.Point(12, 128);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(133, 25);
            this.btnToplam.TabIndex = 4;
            this.btnToplam.Text = "1 - 100 Toplamı";
            this.btnToplam.UseVisualStyleBackColor = true;
            this.btnToplam.Click += new System.EventHandler(this.BtnToplam_Click);
            // 
            // btnIslem
            // 
            this.btnIslem.Location = new System.Drawing.Point(12, 157);
            this.btnIslem.Name = "btnIslem";
            this.btnIslem.Size = new System.Drawing.Size(133, 25);
            this.btnIslem.TabIndex = 5;
            this.btnIslem.Text = "İşlem Yap";
            this.btnIslem.UseVisualStyleBackColor = true;
            this.btnIslem.Click += new System.EventHandler(this.BtnIslem_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 186);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(133, 25);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Yılları ListBox\'a Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(151, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 220);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnIslem);
            this.Controls.Add(this.btnToplam);
            this.Controls.Add(this.btnAZ);
            this.Controls.Add(this.btnCift);
            this.Controls.Add(this.btnOrn2);
            this.Controls.Add(this.btnOrn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrn1;
        private System.Windows.Forms.Button btnOrn2;
        private System.Windows.Forms.Button btnCift;
        private System.Windows.Forms.Button btnAZ;
        private System.Windows.Forms.Button btnToplam;
        private System.Windows.Forms.Button btnIslem;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox listBox1;
    }
}

