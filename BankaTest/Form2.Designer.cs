namespace BankaTest
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.maskHesap = new System.Windows.Forms.MaskedTextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHareket = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblTelefon);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblHesapNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTCKN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblAdSoyad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 99);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad :";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(104, 14);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(48, 18);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "NULL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "TCKN :";
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Location = new System.Drawing.Point(104, 32);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(48, 18);
            this.lblTCKN.TabIndex = 3;
            this.lblTCKN.Text = "NULL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hesap No :";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Location = new System.Drawing.Point(104, 50);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(48, 18);
            this.lblHesapNo.TabIndex = 5;
            this.lblHesapNo.Text = "NULL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Telefon No :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(104, 68);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(48, 18);
            this.lblTelefon.TabIndex = 7;
            this.lblTelefon.Text = "NULL";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.lblBakiye);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnHareket);
            this.groupBox1.Controls.Add(this.btnGonder);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.maskHesap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hesap No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tutar :";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(107, 101);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(171, 26);
            this.txtTutar.TabIndex = 5;
            // 
            // maskHesap
            // 
            this.maskHesap.Location = new System.Drawing.Point(107, 69);
            this.maskHesap.Name = "maskHesap";
            this.maskHesap.Size = new System.Drawing.Size(171, 26);
            this.maskHesap.TabIndex = 4;
            // 
            // btnGonder
            // 
            this.btnGonder.ForeColor = System.Drawing.Color.Black;
            this.btnGonder.Location = new System.Drawing.Point(107, 134);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(171, 38);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Magneto", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(61, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 41);
            this.label6.TabIndex = 8;
            this.label6.Text = "KAYABANK";
            // 
            // btnHareket
            // 
            this.btnHareket.ForeColor = System.Drawing.Color.Black;
            this.btnHareket.Location = new System.Drawing.Point(107, 178);
            this.btnHareket.Name = "btnHareket";
            this.btnHareket.Size = new System.Drawing.Size(171, 38);
            this.btnHareket.TabIndex = 7;
            this.btnHareket.Text = "Hareketlerim";
            this.btnHareket.UseVisualStyleBackColor = true;
            this.btnHareket.Click += new System.EventHandler(this.btnHareket_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bakiye :";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(230, 22);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(48, 18);
            this.lblBakiye.TabIndex = 9;
            this.lblBakiye.Text = "NULL";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(373, 483);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.MaskedTextBox maskHesap;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHareket;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label8;
    }
}