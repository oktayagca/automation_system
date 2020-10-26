namespace Royal_Resteurant_Oto
{
    partial class frmMusteriAra
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
            this.lvMusteriler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnYeniMusteri = new System.Windows.Forms.Button();
            this.btnMuşteriGuncelle = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.rollback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMusteriler
            // 
            this.lvMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvMusteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvMusteriler.FullRowSelect = true;
            this.lvMusteriler.GridLines = true;
            this.lvMusteriler.Location = new System.Drawing.Point(268, 121);
            this.lvMusteriler.Name = "lvMusteriler";
            this.lvMusteriler.Size = new System.Drawing.Size(830, 446);
            this.lvMusteriler.TabIndex = 2;
            this.lvMusteriler.UseCompatibleStateImageBehavior = false;
            this.lvMusteriler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri No";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AD";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "SOYAD";
            this.columnHeader3.Width = 151;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TELEFON";
            this.columnHeader4.Width = 148;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ADRES";
            this.columnHeader5.Width = 156;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "E-MAIL";
            this.columnHeader6.Width = 449;
            // 
            // btnYeniMusteri
            // 
            this.btnYeniMusteri.BackColor = System.Drawing.Color.Transparent;
            this.btnYeniMusteri.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.depositphotos_110610080_stock_illustration_royal_crown_symbol_icon1;
            this.btnYeniMusteri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYeniMusteri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniMusteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniMusteri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYeniMusteri.Location = new System.Drawing.Point(559, 583);
            this.btnYeniMusteri.Name = "btnYeniMusteri";
            this.btnYeniMusteri.Size = new System.Drawing.Size(129, 64);
            this.btnYeniMusteri.TabIndex = 3;
            this.btnYeniMusteri.Text = "Yeni Müşteri";
            this.btnYeniMusteri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnYeniMusteri.UseVisualStyleBackColor = false;
            this.btnYeniMusteri.Click += new System.EventHandler(this.btnYeniMusteri_Click);
            // 
            // btnMuşteriGuncelle
            // 
            this.btnMuşteriGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnMuşteriGuncelle.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.depositphotos_110610080_stock_illustration_royal_crown_symbol_icon1;
            this.btnMuşteriGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMuşteriGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuşteriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMuşteriGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMuşteriGuncelle.Location = new System.Drawing.Point(694, 583);
            this.btnMuşteriGuncelle.Name = "btnMuşteriGuncelle";
            this.btnMuşteriGuncelle.Size = new System.Drawing.Size(129, 64);
            this.btnMuşteriGuncelle.TabIndex = 3;
            this.btnMuşteriGuncelle.Text = "Güncelle";
            this.btnMuşteriGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMuşteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMuşteriGuncelle.Click += new System.EventHandler(this.btnMuşteriGuncelle_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.exit;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(268, 688);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 68);
            this.button5.TabIndex = 15;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // rollback
            // 
            this.rollback.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rollback.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.rollback;
            this.rollback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rollback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollback.Location = new System.Drawing.Point(352, 688);
            this.rollback.Name = "rollback";
            this.rollback.Size = new System.Drawing.Size(77, 68);
            this.rollback.TabIndex = 14;
            this.rollback.UseVisualStyleBackColor = false;
            this.rollback.Click += new System.EventHandler(this.rollback_Click);
            // 
            // frmMusteriAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.indir1;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.rollback);
            this.Controls.Add(this.btnMuşteriGuncelle);
            this.Controls.Add(this.btnYeniMusteri);
            this.Controls.Add(this.lvMusteriler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteriAra";
            this.Text = "Müşteri Ekleme";
            this.Load += new System.EventHandler(this.frmMusteriAra_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvMusteriler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnYeniMusteri;
        private System.Windows.Forms.Button btnMuşteriGuncelle;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button rollback;
    }
}