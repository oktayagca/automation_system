namespace Royal_Resteurant_Oto
{
    partial class frmRapor
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
            this.rollback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.exit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(127, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 68);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rollback
            // 
            this.rollback.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rollback.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.rollback;
            this.rollback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rollback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rollback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollback.Location = new System.Drawing.Point(210, 650);
            this.rollback.Name = "rollback";
            this.rollback.Size = new System.Drawing.Size(77, 68);
            this.rollback.TabIndex = 16;
            this.rollback.UseVisualStyleBackColor = false;
            this.rollback.Click += new System.EventHandler(this.rollback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(508, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "COMING SOON...";
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Royal_Resteurant_Oto.Properties.Resources.indir1;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rollback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRapor";
            this.Text = "frmRapor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rollback;
        private System.Windows.Forms.Label label1;
    }
}