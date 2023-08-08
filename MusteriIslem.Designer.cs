using System;

namespace BANKAMATIK
{
    partial class MusteriIslem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHesapH = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSifreDegistir = new System.Windows.Forms.Button();
            this.btnHavale = new System.Windows.Forms.Button();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.btnBakiyeGoruntule = new System.Windows.Forms.Button();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnHesapH);
            this.groupBox1.Controls.Add(this.btnCikis);
            this.groupBox1.Controls.Add(this.btnSifreDegistir);
            this.groupBox1.Controls.Add(this.btnHavale);
            this.groupBox1.Controls.Add(this.btnParaYatir);
            this.groupBox1.Controls.Add(this.btnBakiyeGoruntule);
            this.groupBox1.Controls.Add(this.btnParaCek);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(75, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 607);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnHesapH
            // 
            this.btnHesapH.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHesapH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapH.Location = new System.Drawing.Point(126, 393);
            this.btnHesapH.Name = "btnHesapH";
            this.btnHesapH.Size = new System.Drawing.Size(213, 47);
            this.btnHesapH.TabIndex = 8;
            this.btnHesapH.Text = "Hesap Hareketleri";
            this.btnHesapH.UseVisualStyleBackColor = false;
            this.btnHesapH.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Crimson;
            this.btnCikis.Location = new System.Drawing.Point(126, 533);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(213, 47);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSifreDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreDegistir.Location = new System.Drawing.Point(126, 323);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(213, 47);
            this.btnSifreDegistir.TabIndex = 6;
            this.btnSifreDegistir.Text = "Şifre Değiştir";
            this.btnSifreDegistir.UseVisualStyleBackColor = false;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click_1);
            // 
            // btnHavale
            // 
            this.btnHavale.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHavale.Location = new System.Drawing.Point(126, 253);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(213, 47);
            this.btnHavale.TabIndex = 5;
            this.btnHavale.Text = "Havale/EFT";
            this.btnHavale.UseVisualStyleBackColor = false;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYatir.Location = new System.Drawing.Point(126, 113);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(213, 47);
            this.btnParaYatir.TabIndex = 3;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = false;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // btnBakiyeGoruntule
            // 
            this.btnBakiyeGoruntule.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBakiyeGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBakiyeGoruntule.Location = new System.Drawing.Point(126, 183);
            this.btnBakiyeGoruntule.Name = "btnBakiyeGoruntule";
            this.btnBakiyeGoruntule.Size = new System.Drawing.Size(213, 47);
            this.btnBakiyeGoruntule.TabIndex = 4;
            this.btnBakiyeGoruntule.Text = "Bakiye Görüntüle";
            this.btnBakiyeGoruntule.UseVisualStyleBackColor = false;
            this.btnBakiyeGoruntule.Click += new System.EventHandler(this.btnBakiyeGoruntule_Click);
            // 
            // btnParaCek
            // 
            this.btnParaCek.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCek.Location = new System.Drawing.Point(126, 43);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(213, 47);
            this.btnParaCek.TabIndex = 2;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = false;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(154, 26);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(16, 24);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hesap No:";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapNo.Location = new System.Drawing.Point(154, 50);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(16, 24);
            this.lblHesapNo.TabIndex = 6;
            this.lblHesapNo.Text = ".";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(126, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Döviz Kurları";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MusteriIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 736);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MusteriIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.MusteriIslem_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHesapH;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnSifreDegistir;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Button btnBakiyeGoruntule;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHesapNo;
        private EventHandler btnSifreDegistir_Click;
        private System.Windows.Forms.Button button1;
    }
}