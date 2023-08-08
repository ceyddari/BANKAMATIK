namespace BANKAMATIK
{
    partial class DovizKuru
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
            this.components = new System.ComponentModel.Container();
            this.lblTarih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblSterlin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(279, 54);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(47, 20);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "tarih";
            this.lblTarih.Click += new System.EventHandler(this.lblTarih_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDolar.Location = new System.Drawing.Point(55, 187);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 18);
            this.lblDolar.TabIndex = 2;
            this.lblDolar.Text = "   c";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEuro.Location = new System.Drawing.Point(55, 245);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(32, 18);
            this.lblEuro.TabIndex = 3;
            this.lblEuro.Text = "   c";
            // 
            // lblSterlin
            // 
            this.lblSterlin.AutoSize = true;
            this.lblSterlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSterlin.Location = new System.Drawing.Point(55, 303);
            this.lblSterlin.Name = "lblSterlin";
            this.lblSterlin.Size = new System.Drawing.Size(32, 18);
            this.lblSterlin.TabIndex = 4;
            this.lblSterlin.Text = "   c";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(54, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Güncel Döviz Piyasa Kuru";
            // 
            // DovizKuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSterlin);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblTarih);
            this.Name = "DovizKuru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anlık Döviz Kuru";
            this.Load += new System.EventHandler(this.DovizKuru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblSterlin;
        private System.Windows.Forms.Label label1;
    }
}