namespace BankaTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtSOYAD = new System.Windows.Forms.TextBox();
            this.maskTCKN = new System.Windows.Forms.MaskedTextBox();
            this.maskTEL = new System.Windows.Forms.MaskedTextBox();
            this.maskHESAP = new System.Windows.Forms.MaskedTextBox();
            this.txtPAROLA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.btnHesap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "TCKN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEFON :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "HESAPNO :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "PAROLA :";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(133, 101);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(198, 26);
            this.txtAD.TabIndex = 1;
            // 
            // txtSOYAD
            // 
            this.txtSOYAD.Location = new System.Drawing.Point(133, 133);
            this.txtSOYAD.Name = "txtSOYAD";
            this.txtSOYAD.Size = new System.Drawing.Size(198, 26);
            this.txtSOYAD.TabIndex = 2;
            // 
            // maskTCKN
            // 
            this.maskTCKN.Location = new System.Drawing.Point(133, 166);
            this.maskTCKN.Mask = "00000000000";
            this.maskTCKN.Name = "maskTCKN";
            this.maskTCKN.Size = new System.Drawing.Size(198, 26);
            this.maskTCKN.TabIndex = 3;
            this.maskTCKN.ValidatingType = typeof(int);
            // 
            // maskTEL
            // 
            this.maskTEL.Location = new System.Drawing.Point(133, 198);
            this.maskTEL.Mask = "(999) 000-0000";
            this.maskTEL.Name = "maskTEL";
            this.maskTEL.Size = new System.Drawing.Size(198, 26);
            this.maskTEL.TabIndex = 4;
            // 
            // maskHESAP
            // 
            this.maskHESAP.Enabled = false;
            this.maskHESAP.Location = new System.Drawing.Point(133, 230);
            this.maskHESAP.Mask = "000000";
            this.maskHESAP.Name = "maskHESAP";
            this.maskHESAP.Size = new System.Drawing.Size(137, 26);
            this.maskHESAP.TabIndex = 5;
            this.maskHESAP.ValidatingType = typeof(int);
            // 
            // txtPAROLA
            // 
            this.txtPAROLA.Location = new System.Drawing.Point(132, 262);
            this.txtPAROLA.Name = "txtPAROLA";
            this.txtPAROLA.Size = new System.Drawing.Size(198, 26);
            this.txtPAROLA.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Magneto", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(52, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 41);
            this.label7.TabIndex = 12;
            this.label7.Text = "KAYABANK";
            // 
            // btnKaydol
            // 
            this.btnKaydol.ForeColor = System.Drawing.Color.Black;
            this.btnKaydol.Location = new System.Drawing.Point(132, 295);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(198, 50);
            this.btnKaydol.TabIndex = 7;
            this.btnKaydol.Text = "KAYIT OL";
            this.btnKaydol.UseVisualStyleBackColor = true;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // btnHesap
            // 
            this.btnHesap.ForeColor = System.Drawing.Color.Black;
            this.btnHesap.Location = new System.Drawing.Point(276, 230);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(55, 25);
            this.btnHesap.TabIndex = 13;
            this.btnHesap.Text = "...";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(349, 382);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.btnKaydol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPAROLA);
            this.Controls.Add(this.maskHESAP);
            this.Controls.Add(this.maskTEL);
            this.Controls.Add(this.maskTCKN);
            this.Controls.Add(this.txtSOYAD);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.TextBox txtSOYAD;
        private System.Windows.Forms.MaskedTextBox maskTCKN;
        private System.Windows.Forms.MaskedTextBox maskTEL;
        private System.Windows.Forms.MaskedTextBox maskHESAP;
        private System.Windows.Forms.TextBox txtPAROLA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.Button btnHesap;
    }
}