namespace Royal_Resteurant_Oto
{
    partial class frmMutfak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMutfak));
            this.lvKategoriler = new System.Windows.Forms.ListView();
            this.lvGidaListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.rbKategori = new System.Windows.Forms.RadioButton();
            this.rbUrun = new System.Windows.Forms.RadioButton();
            this.panelUrun = new System.Windows.Forms.Panel();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.txtGıdaFiyat = new System.Windows.Forms.TextBox();
            this.txtGıdaAdı = new System.Windows.Forms.TextBox();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAnaKategori = new System.Windows.Forms.Panel();
            this.txtKategoriId = new System.Windows.Forms.TextBox();
            this.txtAcıklamaa = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbAltkategori = new System.Windows.Forms.RadioButton();
            this.rbAnakategori = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.rollback = new System.Windows.Forms.Button();
            this.panelUrun.SuspendLayout();
            this.panelAnaKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvKategoriler
            // 
            this.lvKategoriler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvKategoriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvKategoriler.FullRowSelect = true;
            this.lvKategoriler.GridLines = true;
            this.lvKategoriler.Location = new System.Drawing.Point(434, 459);
            this.lvKategoriler.Name = "lvKategoriler";
            this.lvKategoriler.Size = new System.Drawing.Size(499, 209);
            this.lvKategoriler.TabIndex = 0;
            this.lvKategoriler.UseCompatibleStateImageBehavior = false;
            this.lvKategoriler.View = System.Windows.Forms.View.Details;
            this.lvKategoriler.SelectedIndexChanged += new System.EventHandler(this.lvKategoriler_SelectedIndexChanged);
            // 
            // lvGidaListesi
            // 
            this.lvGidaListesi.AllowColumnReorder = true;
            this.lvGidaListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvGidaListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvGidaListesi.FullRowSelect = true;
            this.lvGidaListesi.GridLines = true;
            this.lvGidaListesi.Location = new System.Drawing.Point(434, 459);
            this.lvGidaListesi.Name = "lvGidaListesi";
            this.lvGidaListesi.Size = new System.Drawing.Size(499, 209);
            this.lvGidaListesi.TabIndex = 1;
            this.lvGidaListesi.UseCompatibleStateImageBehavior = false;
            this.lvGidaListesi.View = System.Windows.Forms.View.Details;
            this.lvGidaListesi.SelectedIndexChanged += new System.EventHandler(this.lvGıdaListesi_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TurId";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "KATEGORİ";
            this.columnHeader2.Width = 186;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "AÇIKLAMA";
            this.columnHeader3.Width = 206;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ÜRÜN ID";
            this.columnHeader4.Width = 68;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "KATEGORİ ID";
            this.columnHeader5.Width = 88;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "KATEGORİ";
            this.columnHeader6.Width = 109;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ÜRÜN ADI";
            this.columnHeader7.Width = 127;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "FİYAT";
            this.columnHeader8.Width = 186;
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(509, 390);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 63);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDegistir.BackgroundImage")));
            this.btnDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDegistir.Location = new System.Drawing.Point(627, 390);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(111, 63);
            this.btnDegistir.TabIndex = 2;
            this.btnDegistir.Text = "DEĞİŞTİR";
            this.btnDegistir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSil.Location = new System.Drawing.Point(752, 390);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 63);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // rbKategori
            // 
            this.rbKategori.AutoSize = true;
            this.rbKategori.BackColor = System.Drawing.Color.Transparent;
            this.rbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKategori.Location = new System.Drawing.Point(1097, -67);
            this.rbKategori.Name = "rbKategori";
            this.rbKategori.Size = new System.Drawing.Size(123, 17);
            this.rbKategori.TabIndex = 5;
            this.rbKategori.TabStop = true;
            this.rbKategori.Text = "KATEGORİ EKLE";
            this.rbKategori.UseVisualStyleBackColor = false;
            // 
            // rbUrun
            // 
            this.rbUrun.AutoSize = true;
            this.rbUrun.BackColor = System.Drawing.Color.Transparent;
            this.rbUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbUrun.Location = new System.Drawing.Point(890, -84);
            this.rbUrun.Name = "rbUrun";
            this.rbUrun.Size = new System.Drawing.Size(96, 17);
            this.rbUrun.TabIndex = 5;
            this.rbUrun.TabStop = true;
            this.rbUrun.Text = "ÜRÜN EKLE";
            this.rbUrun.UseVisualStyleBackColor = false;
            // 
            // panelUrun
            // 
            this.panelUrun.BackColor = System.Drawing.Color.Transparent;
            this.panelUrun.Controls.Add(this.panelAnaKategori);
            this.panelUrun.Controls.Add(this.txtUrunId);
            this.panelUrun.Controls.Add(this.txtGıdaFiyat);
            this.panelUrun.Controls.Add(this.txtGıdaAdı);
            this.panelUrun.Controls.Add(this.cbKategoriler);
            this.panelUrun.Controls.Add(this.label3);
            this.panelUrun.Controls.Add(this.label2);
            this.panelUrun.Controls.Add(this.label1);
            this.panelUrun.Location = new System.Drawing.Point(434, 164);
            this.panelUrun.Name = "panelUrun";
            this.panelUrun.Size = new System.Drawing.Size(499, 209);
            this.panelUrun.TabIndex = 6;
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(435, 69);
            this.txtUrunId.Multiline = true;
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(33, 24);
            this.txtUrunId.TabIndex = 3;
            this.txtUrunId.Visible = false;
            // 
            // txtGıdaFiyat
            // 
            this.txtGıdaFiyat.Location = new System.Drawing.Point(193, 119);
            this.txtGıdaFiyat.Multiline = true;
            this.txtGıdaFiyat.Name = "txtGıdaFiyat";
            this.txtGıdaFiyat.Size = new System.Drawing.Size(235, 25);
            this.txtGıdaFiyat.TabIndex = 2;
            // 
            // txtGıdaAdı
            // 
            this.txtGıdaAdı.Location = new System.Drawing.Point(193, 69);
            this.txtGıdaAdı.Multiline = true;
            this.txtGıdaAdı.Name = "txtGıdaAdı";
            this.txtGıdaAdı.Size = new System.Drawing.Size(235, 25);
            this.txtGıdaAdı.TabIndex = 2;
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(193, 29);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(235, 21);
            this.cbKategoriler.TabIndex = 1;
            this.cbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "FİYAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(104, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "AD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KATEGORİ";
            // 
            // panelAnaKategori
            // 
            this.panelAnaKategori.BackColor = System.Drawing.Color.Transparent;
            this.panelAnaKategori.Controls.Add(this.txtKategoriId);
            this.panelAnaKategori.Controls.Add(this.txtAcıklamaa);
            this.panelAnaKategori.Controls.Add(this.textBox2);
            this.panelAnaKategori.Controls.Add(this.txtKategoriAd);
            this.panelAnaKategori.Controls.Add(this.label5);
            this.panelAnaKategori.Controls.Add(this.label4);
            this.panelAnaKategori.Location = new System.Drawing.Point(0, 0);
            this.panelAnaKategori.Name = "panelAnaKategori";
            this.panelAnaKategori.Size = new System.Drawing.Size(499, 209);
            this.panelAnaKategori.TabIndex = 7;
            this.panelAnaKategori.Visible = false;
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.Location = new System.Drawing.Point(436, 56);
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.Size = new System.Drawing.Size(21, 20);
            this.txtKategoriId.TabIndex = 2;
            this.txtKategoriId.Visible = false;
            // 
            // txtAcıklamaa
            // 
            this.txtAcıklamaa.Location = new System.Drawing.Point(244, 106);
            this.txtAcıklamaa.Multiline = true;
            this.txtAcıklamaa.Name = "txtAcıklamaa";
            this.txtAcıklamaa.Size = new System.Drawing.Size(185, 25);
            this.txtAcıklamaa.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 107);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 25);
            this.textBox2.TabIndex = 1;
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(244, 52);
            this.txtKategoriAd.Multiline = true;
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(185, 25);
            this.txtKategoriAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(75, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "AÇIKLAMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "KATEGORİ ADI";
            // 
            // rbAltkategori
            // 
            this.rbAltkategori.AutoSize = true;
            this.rbAltkategori.BackColor = System.Drawing.Color.Transparent;
            this.rbAltkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAltkategori.Location = new System.Drawing.Point(541, 101);
            this.rbAltkategori.Name = "rbAltkategori";
            this.rbAltkategori.Size = new System.Drawing.Size(96, 17);
            this.rbAltkategori.TabIndex = 7;
            this.rbAltkategori.TabStop = true;
            this.rbAltkategori.Text = "ÜRÜN EKLE";
            this.rbAltkategori.UseVisualStyleBackColor = false;
            this.rbAltkategori.CheckedChanged += new System.EventHandler(this.rbAltkategori_CheckedChanged);
            // 
            // rbAnakategori
            // 
            this.rbAnakategori.AutoSize = true;
            this.rbAnakategori.BackColor = System.Drawing.Color.Transparent;
            this.rbAnakategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAnakategori.Location = new System.Drawing.Point(684, 101);
            this.rbAnakategori.Name = "rbAnakategori";
            this.rbAnakategori.Size = new System.Drawing.Size(123, 17);
            this.rbAnakategori.TabIndex = 7;
            this.rbAnakategori.TabStop = true;
            this.rbAnakategori.Text = "KATEGORİ EKLE";
            this.rbAnakategori.UseVisualStyleBackColor = false;
            this.rbAnakategori.CheckedChanged += new System.EventHandler(this.rbAnakategori_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.exit;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(154, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 68);
            this.button2.TabIndex = 15;
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
            this.rollback.Location = new System.Drawing.Point(237, 688);
            this.rollback.Name = "rollback";
            this.rollback.Size = new System.Drawing.Size(77, 68);
            this.rollback.TabIndex = 14;
            this.rollback.UseVisualStyleBackColor = false;
            this.rollback.Click += new System.EventHandler(this.rollback_Click);
            // 
            // frmMutfak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.indir1;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rollback);
            this.Controls.Add(this.rbAnakategori);
            this.Controls.Add(this.rbAltkategori);
            this.Controls.Add(this.panelUrun);
            this.Controls.Add(this.rbKategori);
            this.Controls.Add(this.rbUrun);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lvGidaListesi);
            this.Controls.Add(this.lvKategoriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMutfak";
            this.Text = "frmMutfak";
            this.Load += new System.EventHandler(this.frmMutfak_Load);
            this.panelUrun.ResumeLayout(false);
            this.panelUrun.PerformLayout();
            this.panelAnaKategori.ResumeLayout(false);
            this.panelAnaKategori.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvKategoriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.RadioButton rbKategori;
        private System.Windows.Forms.RadioButton rbUrun;
        private System.Windows.Forms.Panel panelUrun;
        private System.Windows.Forms.Panel panelAnaKategori;
        private System.Windows.Forms.TextBox txtKategoriId;
        private System.Windows.Forms.TextBox txtAcıklamaa;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.TextBox txtGıdaFiyat;
        private System.Windows.Forms.TextBox txtGıdaAdı;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAltkategori;
        private System.Windows.Forms.RadioButton rbAnakategori;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button rollback;
        public System.Windows.Forms.ListView lvGidaListesi;
    }
}