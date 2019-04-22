namespace SqlSample.WinUI
{
    partial class FrmSiparis
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
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstUrun = new System.Windows.Forms.ListBox();
            this.txtUurunAdi = new System.Windows.Forms.TextBox();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.erpSepet = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(54, 30);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(148, 21);
            this.cmbKategori.TabIndex = 0;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label1";
            // 
            // lstUrun
            // 
            this.lstUrun.FormattingEnabled = true;
            this.lstUrun.Location = new System.Drawing.Point(16, 61);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(186, 147);
            this.lstUrun.TabIndex = 2;
            this.lstUrun.SelectedIndexChanged += new System.EventHandler(this.lstUrun_SelectedIndexChanged);
            // 
            // txtUurunAdi
            // 
            this.txtUurunAdi.Location = new System.Drawing.Point(291, 22);
            this.txtUurunAdi.Name = "txtUurunAdi";
            this.txtUurunAdi.Size = new System.Drawing.Size(120, 20);
            this.txtUurunAdi.TabIndex = 3;
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(291, 48);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(120, 20);
            this.txtStokMiktari.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(291, 75);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(362, 101);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(49, 30);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "+";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // erpSepet
            // 
            this.erpSepet.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Siparişi Tamamla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 237);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtStokMiktari);
            this.Controls.Add(this.txtUurunAdi);
            this.Controls.Add(this.lstUrun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKategori);
            this.Name = "FrmSiparis";
            this.Text = "FrmSiparis";
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpSepet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstUrun;
        private System.Windows.Forms.TextBox txtUurunAdi;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ErrorProvider erpSepet;
        private System.Windows.Forms.Button button1;
    }
}