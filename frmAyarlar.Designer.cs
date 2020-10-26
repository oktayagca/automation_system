namespace Royal_Resteurant_Oto
{
    partial class frmAyarlar
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cbGorevi = new System.Windows.Forms.ComboBox();
            this.txtGorevId2 = new System.Windows.Forms.TextBox();
            this.txtPersonelId = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lvPersoneller = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.rollback = new System.Windows.Forms.Button();
            this.lbBilgi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnYeni);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.cbGorevi);
            this.groupBox1.Controls.Add(this.txtGorevId2);
            this.groupBox1.Controls.Add(this.txtPersonelId);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtSifreTekrar);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(476, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.depositphotos_110610080_stock_illustration_royal_crown_symbol_icon1;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Location = new System.Drawing.Point(162, 260);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(97, 49);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "KAYDET";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.depositphotos_110610080_stock_illustration_royal_crown_symbol_icon1;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeni.Location = new System.Drawing.Point(59, 260);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(97, 49);
            this.btnYeni.TabIndex = 5;
            this.btnYeni.Text = "YENİ";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.depositphotos_110610080_stock_illustration_royal_crown_symbol_icon1;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Location = new System.Drawing.Point(265, 260);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 49);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cbGorevi
            // 
            this.cbGorevi.FormattingEnabled = true;
            this.cbGorevi.Location = new System.Drawing.Point(192, 201);
            this.cbGorevi.Name = "cbGorevi";
            this.cbGorevi.Size = new System.Drawing.Size(179, 21);
            this.cbGorevi.TabIndex = 4;
            this.cbGorevi.SelectedIndexChanged += new System.EventHandler(this.cbGorevi_SelectedIndexChanged);
            // 
            // txtGorevId2
            // 
            this.txtGorevId2.Location = new System.Drawing.Point(377, 202);
            this.txtGorevId2.Name = "txtGorevId2";
            this.txtGorevId2.Size = new System.Drawing.Size(31, 20);
            this.txtGorevId2.TabIndex = 3;
            // 
            // txtPersonelId
            // 
            this.txtPersonelId.Location = new System.Drawing.Point(377, 52);
            this.txtPersonelId.Name = "txtPersonelId";
            this.txtPersonelId.Size = new System.Drawing.Size(31, 20);
            this.txtPersonelId.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(192, 52);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(179, 20);
            this.txtAd.TabIndex = 2;
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(192, 165);
            this.txtSifreTekrar.Multiline = true;
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '*';
            this.txtSifreTekrar.Size = new System.Drawing.Size(179, 20);
            this.txtSifreTekrar.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(192, 129);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(179, 20);
            this.txtSifre.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(192, 94);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(179, 20);
            this.txtSoyad.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(83, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "GÖREV";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ŞİFRE TEKRAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(81, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "ŞİFRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(85, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD";
            // 
            // lvPersoneller
            // 
            this.lvPersoneller.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvPersoneller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvPersoneller.FullRowSelect = true;
            this.lvPersoneller.GridLines = true;
            this.lvPersoneller.Location = new System.Drawing.Point(6, 11);
            this.lvPersoneller.Name = "lvPersoneller";
            this.lvPersoneller.Size = new System.Drawing.Size(402, 139);
            this.lvPersoneller.TabIndex = 1;
            this.lvPersoneller.UseCompatibleStateImageBehavior = false;
            this.lvPersoneller.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PersonelId";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PersonelGörevId";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "GÖREV";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "AD";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SOYAD";
            this.columnHeader5.Width = 146;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.exit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(313, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 68);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rollback
            // 
            this.rollback.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rollback.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.rollback;
            this.rollback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rollback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollback.Location = new System.Drawing.Point(396, 688);
            this.rollback.Name = "rollback";
            this.rollback.Size = new System.Drawing.Size(77, 68);
            this.rollback.TabIndex = 12;
            this.rollback.UseVisualStyleBackColor = false;
            this.rollback.Click += new System.EventHandler(this.rollback_Click);
            // 
            // lbBilgi
            // 
            this.lbBilgi.AutoSize = true;
            this.lbBilgi.BackColor = System.Drawing.Color.Transparent;
            this.lbBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbBilgi.ForeColor = System.Drawing.Color.Black;
            this.lbBilgi.Location = new System.Drawing.Point(476, 96);
            this.lbBilgi.Name = "lbBilgi";
            this.lbBilgi.Size = new System.Drawing.Size(172, 20);
            this.lbBilgi.TabIndex = 14;
            this.lbBilgi.Text = "KULLANICI BİLGİSİ";
            this.lbBilgi.Click += new System.EventHandler(this.lbBilgi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvPersoneller);
            this.groupBox2.Location = new System.Drawing.Point(476, 512);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 156);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // frmAyarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.indir1;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbBilgi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rollback);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAyarlar";
            this.Text = "frmAyarlar";
            this.Load += new System.EventHandler(this.frmAyarlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ComboBox cbGorevi;
        private System.Windows.Forms.TextBox txtGorevId2;
        private System.Windows.Forms.TextBox txtPersonelId;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvPersoneller;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button rollback;
        private System.Windows.Forms.Label lbBilgi;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}