namespace Logamoasta
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.btn_zurueck = new System.Windows.Forms.Button();
            this.lbl_ekvk = new System.Windows.Forms.Label();
            this.lbl_vkpreis = new System.Windows.Forms.Label();
            this.lbl_ekpreis = new System.Windows.Forms.Label();
            this.lbl_bezeichnung = new System.Windows.Forms.Label();
            this.lbl_artikelnr = new System.Windows.Forms.Label();
            this.lst_lagerbestand = new System.Windows.Forms.ListBox();
            this.lbl_lagerbestand = new System.Windows.Forms.Label();
            this.btn_filtern = new System.Windows.Forms.Button();
            this.lbl_benutzer = new System.Windows.Forms.Label();
            this.cmb_artikelnr = new System.Windows.Forms.ComboBox();
            this.cmb_bezeichnung = new System.Windows.Forms.ComboBox();
            this.cmb_ekpreis = new System.Windows.Forms.ComboBox();
            this.cmb_vkpreis = new System.Windows.Forms.ComboBox();
            this.cmb_ekvk = new System.Windows.Forms.ComboBox();
            this.cmb_benutzer = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_zurueck
            // 
            this.btn_zurueck.AutoSize = true;
            this.btn_zurueck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zurueck.Location = new System.Drawing.Point(12, 536);
            this.btn_zurueck.Name = "btn_zurueck";
            this.btn_zurueck.Size = new System.Drawing.Size(77, 32);
            this.btn_zurueck.TabIndex = 42;
            this.btn_zurueck.Text = "Zurück";
            this.btn_zurueck.UseVisualStyleBackColor = true;
            this.btn_zurueck.Click += new System.EventHandler(this.btn_zurueck_Click);
            // 
            // lbl_ekvk
            // 
            this.lbl_ekvk.AutoSize = true;
            this.lbl_ekvk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ekvk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_ekvk.Location = new System.Drawing.Point(181, 176);
            this.lbl_ekvk.Name = "lbl_ekvk";
            this.lbl_ekvk.Size = new System.Drawing.Size(143, 20);
            this.lbl_ekvk.TabIndex = 37;
            this.lbl_ekvk.Text = "Einkauf/Verkauf:";
            // 
            // lbl_vkpreis
            // 
            this.lbl_vkpreis.AutoSize = true;
            this.lbl_vkpreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vkpreis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_vkpreis.Location = new System.Drawing.Point(199, 149);
            this.lbl_vkpreis.Name = "lbl_vkpreis";
            this.lbl_vkpreis.Size = new System.Drawing.Size(125, 20);
            this.lbl_vkpreis.TabIndex = 35;
            this.lbl_vkpreis.Text = "Verkaufspreis:";
            // 
            // lbl_ekpreis
            // 
            this.lbl_ekpreis.AutoSize = true;
            this.lbl_ekpreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ekpreis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_ekpreis.Location = new System.Drawing.Point(201, 123);
            this.lbl_ekpreis.Name = "lbl_ekpreis";
            this.lbl_ekpreis.Size = new System.Drawing.Size(123, 20);
            this.lbl_ekpreis.TabIndex = 33;
            this.lbl_ekpreis.Text = "Einkaufspreis:";
            // 
            // lbl_bezeichnung
            // 
            this.lbl_bezeichnung.AutoSize = true;
            this.lbl_bezeichnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bezeichnung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_bezeichnung.Location = new System.Drawing.Point(206, 97);
            this.lbl_bezeichnung.Name = "lbl_bezeichnung";
            this.lbl_bezeichnung.Size = new System.Drawing.Size(118, 20);
            this.lbl_bezeichnung.TabIndex = 32;
            this.lbl_bezeichnung.Text = "Bezeichnung:";
            // 
            // lbl_artikelnr
            // 
            this.lbl_artikelnr.AutoSize = true;
            this.lbl_artikelnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_artikelnr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_artikelnr.Location = new System.Drawing.Point(243, 71);
            this.lbl_artikelnr.Name = "lbl_artikelnr";
            this.lbl_artikelnr.Size = new System.Drawing.Size(81, 20);
            this.lbl_artikelnr.TabIndex = 31;
            this.lbl_artikelnr.Text = "Artikelnr:";
            // 
            // lst_lagerbestand
            // 
            this.lst_lagerbestand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(54)))));
            this.lst_lagerbestand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_lagerbestand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_lagerbestand.FormattingEnabled = true;
            this.lst_lagerbestand.ItemHeight = 24;
            this.lst_lagerbestand.Items.AddRange(new object[] {
            "Artikelnr\tBezeichnung\tEinkaufspreis\tVerkaufspreis\tAnzahl\tBenutzer",
            "1\tHolzschuhe\t49.99\t\t99.99\t\t19\tm.riedmann",
            "2\tBlumentopferde\t9.99\t\t29,99\t\t-34\ta.schoenacher",
            "3\tGustaf Bier\t-9,99\t\t-3,99\t\t1000\tg.bier"});
            this.lst_lagerbestand.Location = new System.Drawing.Point(12, 263);
            this.lst_lagerbestand.Name = "lst_lagerbestand";
            this.lst_lagerbestand.Size = new System.Drawing.Size(860, 264);
            this.lst_lagerbestand.TabIndex = 30;
            // 
            // lbl_lagerbestand
            // 
            this.lbl_lagerbestand.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lagerbestand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_lagerbestand.Location = new System.Drawing.Point(101, 11);
            this.lbl_lagerbestand.Name = "lbl_lagerbestand";
            this.lbl_lagerbestand.Size = new System.Drawing.Size(683, 57);
            this.lbl_lagerbestand.TabIndex = 29;
            this.lbl_lagerbestand.Text = "Lagerverlauf";
            this.lbl_lagerbestand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_filtern
            // 
            this.btn_filtern.AutoSize = true;
            this.btn_filtern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtern.Location = new System.Drawing.Point(392, 229);
            this.btn_filtern.Name = "btn_filtern";
            this.btn_filtern.Size = new System.Drawing.Size(112, 32);
            this.btn_filtern.TabIndex = 48;
            this.btn_filtern.Text = "Filtern";
            this.btn_filtern.UseVisualStyleBackColor = true;
            // 
            // lbl_benutzer
            // 
            this.lbl_benutzer.AutoSize = true;
            this.lbl_benutzer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_benutzer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_benutzer.Location = new System.Drawing.Point(237, 203);
            this.lbl_benutzer.Name = "lbl_benutzer";
            this.lbl_benutzer.Size = new System.Drawing.Size(87, 20);
            this.lbl_benutzer.TabIndex = 49;
            this.lbl_benutzer.Text = "Benutzer:";
            // 
            // cmb_artikelnr
            // 
            this.cmb_artikelnr.FormattingEnabled = true;
            this.cmb_artikelnr.Items.AddRange(new object[] {
            "hghzgfd",
            "hgfdhd",
            "dgfhfdhg"});
            this.cmb_artikelnr.Location = new System.Drawing.Point(330, 70);
            this.cmb_artikelnr.Name = "cmb_artikelnr";
            this.cmb_artikelnr.Size = new System.Drawing.Size(311, 21);
            this.cmb_artikelnr.TabIndex = 50;
            // 
            // cmb_bezeichnung
            // 
            this.cmb_bezeichnung.FormattingEnabled = true;
            this.cmb_bezeichnung.Items.AddRange(new object[] {
            "hghzgfd",
            "hgfdhd",
            "dgfhfdhg"});
            this.cmb_bezeichnung.Location = new System.Drawing.Point(330, 96);
            this.cmb_bezeichnung.Name = "cmb_bezeichnung";
            this.cmb_bezeichnung.Size = new System.Drawing.Size(311, 21);
            this.cmb_bezeichnung.TabIndex = 51;
            // 
            // cmb_ekpreis
            // 
            this.cmb_ekpreis.FormattingEnabled = true;
            this.cmb_ekpreis.Items.AddRange(new object[] {
            "hghzgfd",
            "hgfdhd",
            "dgfhfdhg"});
            this.cmb_ekpreis.Location = new System.Drawing.Point(330, 122);
            this.cmb_ekpreis.Name = "cmb_ekpreis";
            this.cmb_ekpreis.Size = new System.Drawing.Size(311, 21);
            this.cmb_ekpreis.TabIndex = 52;
            // 
            // cmb_vkpreis
            // 
            this.cmb_vkpreis.FormattingEnabled = true;
            this.cmb_vkpreis.Items.AddRange(new object[] {
            "hghzgfd",
            "hgfdhd",
            "dgfhfdhg"});
            this.cmb_vkpreis.Location = new System.Drawing.Point(330, 148);
            this.cmb_vkpreis.Name = "cmb_vkpreis";
            this.cmb_vkpreis.Size = new System.Drawing.Size(311, 21);
            this.cmb_vkpreis.TabIndex = 53;
            // 
            // cmb_ekvk
            // 
            this.cmb_ekvk.FormattingEnabled = true;
            this.cmb_ekvk.Items.AddRange(new object[] {
            "Einkauf",
            "Verkauf"});
            this.cmb_ekvk.Location = new System.Drawing.Point(330, 175);
            this.cmb_ekvk.Name = "cmb_ekvk";
            this.cmb_ekvk.Size = new System.Drawing.Size(311, 21);
            this.cmb_ekvk.TabIndex = 54;
            // 
            // cmb_benutzer
            // 
            this.cmb_benutzer.FormattingEnabled = true;
            this.cmb_benutzer.Items.AddRange(new object[] {
            "hghzgfd",
            "hgfdhd",
            "dgfhfdhg"});
            this.cmb_benutzer.Location = new System.Drawing.Point(330, 202);
            this.cmb_benutzer.Name = "cmb_benutzer";
            this.cmb_benutzer.Size = new System.Drawing.Size(311, 21);
            this.cmb_benutzer.TabIndex = 55;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(884, 580);
            this.Controls.Add(this.cmb_benutzer);
            this.Controls.Add(this.cmb_ekvk);
            this.Controls.Add(this.cmb_vkpreis);
            this.Controls.Add(this.cmb_ekpreis);
            this.Controls.Add(this.cmb_bezeichnung);
            this.Controls.Add(this.cmb_artikelnr);
            this.Controls.Add(this.lbl_benutzer);
            this.Controls.Add(this.btn_filtern);
            this.Controls.Add(this.btn_zurueck);
            this.Controls.Add(this.lbl_ekvk);
            this.Controls.Add(this.lbl_vkpreis);
            this.Controls.Add(this.lbl_ekpreis);
            this.Controls.Add(this.lbl_bezeichnung);
            this.Controls.Add(this.lbl_artikelnr);
            this.Controls.Add(this.lst_lagerbestand);
            this.Controls.Add(this.lbl_lagerbestand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lagerverlauf";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_zurueck;
        private System.Windows.Forms.Label lbl_ekvk;
        private System.Windows.Forms.Label lbl_vkpreis;
        private System.Windows.Forms.Label lbl_ekpreis;
        private System.Windows.Forms.Label lbl_bezeichnung;
        private System.Windows.Forms.Label lbl_artikelnr;
        private System.Windows.Forms.ListBox lst_lagerbestand;
        private System.Windows.Forms.Label lbl_lagerbestand;
        private System.Windows.Forms.Button btn_filtern;
        private System.Windows.Forms.Label lbl_benutzer;
        private System.Windows.Forms.ComboBox cmb_artikelnr;
        private System.Windows.Forms.ComboBox cmb_bezeichnung;
        private System.Windows.Forms.ComboBox cmb_ekpreis;
        private System.Windows.Forms.ComboBox cmb_vkpreis;
        private System.Windows.Forms.ComboBox cmb_ekvk;
        private System.Windows.Forms.ComboBox cmb_benutzer;
    }
}