namespace Demo_5
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurName = new System.Windows.Forms.TextBox();
            this.comboCinsiyet = new System.Windows.Forms.ComboBox();
            this.comboDurum = new System.Windows.Forms.ComboBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(113, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(284, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 173);
            this.listBox1.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(104, 60);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(119, 20);
            this.textName.TabIndex = 2;
            // 
            // textSurName
            // 
            this.textSurName.Location = new System.Drawing.Point(104, 97);
            this.textSurName.Name = "textSurName";
            this.textSurName.Size = new System.Drawing.Size(119, 20);
            this.textSurName.TabIndex = 3;
            // 
            // comboCinsiyet
            // 
            this.comboCinsiyet.FormattingEnabled = true;
            this.comboCinsiyet.Location = new System.Drawing.Point(102, 134);
            this.comboCinsiyet.Name = "comboCinsiyet";
            this.comboCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.comboCinsiyet.TabIndex = 4;
            // 
            // comboDurum
            // 
            this.comboDurum.FormattingEnabled = true;
            this.comboDurum.Location = new System.Drawing.Point(102, 173);
            this.comboDurum.Name = "comboDurum";
            this.comboDurum.Size = new System.Drawing.Size(121, 21);
            this.comboDurum.TabIndex = 5;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(36, 63);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(36, 97);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSoyad.TabIndex = 7;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(36, 137);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(46, 13);
            this.lblCinsiyet.TabIndex = 8;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(36, 181);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(41, 13);
            this.lblDurum.TabIndex = 9;
            this.lblDurum.Text = "Durum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ogrenci Kayit Sistemi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.comboDurum);
            this.Controls.Add(this.comboCinsiyet);
            this.Controls.Add(this.textSurName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Ogrenci Kayit Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurName;
        private System.Windows.Forms.ComboBox comboCinsiyet;
        private System.Windows.Forms.ComboBox comboDurum;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label1;
    }
}

