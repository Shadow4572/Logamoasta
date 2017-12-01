namespace Logamoasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lbl_lagerbestand = new System.Windows.Forms.Label();
            this.lbl_artikelnr = new System.Windows.Forms.Label();
            this.lbl_bezeichnung = new System.Windows.Forms.Label();
            this.txt_ekpreis = new System.Windows.Forms.TextBox();
            this.lbl_ekpreis = new System.Windows.Forms.Label();
            this.txt_vkpreis = new System.Windows.Forms.TextBox();
            this.lbl_vkpreis = new System.Windows.Forms.Label();
            this.lbl_anzahl = new System.Windows.Forms.Label();
            this.num_anzahl = new System.Windows.Forms.NumericUpDown();
            this.txt_bezeichnung = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_zurueck = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_aktualisieren = new System.Windows.Forms.RadioButton();
            this.rbtn_neuerartikel = new System.Windows.Forms.RadioButton();
            this.cmb_artikelnr = new System.Windows.Forms.ComboBox();
            this.cmb_bezeichnung = new System.Windows.Forms.ComboBox();
            this.cmb_ekpreis = new System.Windows.Forms.ComboBox();
            this.cmb_vkpreis = new System.Windows.Forms.ComboBox();
            this.dat_lagerbestand = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.num_anzahl)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_lagerbestand)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_lagerbestand
            // 
            this.lbl_lagerbestand.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lagerbestand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_lagerbestand.Location = new System.Drawing.Point(12, 9);
            this.lbl_lagerbestand.Name = "lbl_lagerbestand";
            this.lbl_lagerbestand.Size = new System.Drawing.Size(683, 57);
            this.lbl_lagerbestand.TabIndex = 4;
            this.lbl_lagerbestand.Text = "Lagerbestand";
            this.lbl_lagerbestand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_artikelnr
            // 
            this.lbl_artikelnr.AutoSize = true;
            this.lbl_artikelnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_artikelnr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_artikelnr.Location = new System.Drawing.Point(154, 69);
            this.lbl_artikelnr.Name = "lbl_artikelnr";
            this.lbl_artikelnr.Size = new System.Drawing.Size(81, 20);
            this.lbl_artikelnr.TabIndex = 8;
            this.lbl_artikelnr.Text = "Artikelnr:";
            // 
            // lbl_bezeichnung
            // 
            this.lbl_bezeichnung.AutoSize = true;
            this.lbl_bezeichnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bezeichnung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_bezeichnung.Location = new System.Drawing.Point(117, 95);
            this.lbl_bezeichnung.Name = "lbl_bezeichnung";
            this.lbl_bezeichnung.Size = new System.Drawing.Size(118, 20);
            this.lbl_bezeichnung.TabIndex = 10;
            this.lbl_bezeichnung.Text = "Bezeichnung:";
            // 
            // txt_ekpreis
            // 
            this.txt_ekpreis.Location = new System.Drawing.Point(241, 121);
            this.txt_ekpreis.Name = "txt_ekpreis";
            this.txt_ekpreis.Size = new System.Drawing.Size(311, 20);
            this.txt_ekpreis.TabIndex = 13;
            this.txt_ekpreis.Visible = false;
            // 
            // lbl_ekpreis
            // 
            this.lbl_ekpreis.AutoSize = true;
            this.lbl_ekpreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ekpreis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_ekpreis.Location = new System.Drawing.Point(112, 121);
            this.lbl_ekpreis.Name = "lbl_ekpreis";
            this.lbl_ekpreis.Size = new System.Drawing.Size(123, 20);
            this.lbl_ekpreis.TabIndex = 12;
            this.lbl_ekpreis.Text = "Einkaufspreis:";
            // 
            // txt_vkpreis
            // 
            this.txt_vkpreis.Location = new System.Drawing.Point(241, 147);
            this.txt_vkpreis.Name = "txt_vkpreis";
            this.txt_vkpreis.Size = new System.Drawing.Size(311, 20);
            this.txt_vkpreis.TabIndex = 15;
            this.txt_vkpreis.Visible = false;
            // 
            // lbl_vkpreis
            // 
            this.lbl_vkpreis.AutoSize = true;
            this.lbl_vkpreis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vkpreis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_vkpreis.Location = new System.Drawing.Point(110, 147);
            this.lbl_vkpreis.Name = "lbl_vkpreis";
            this.lbl_vkpreis.Size = new System.Drawing.Size(125, 20);
            this.lbl_vkpreis.TabIndex = 14;
            this.lbl_vkpreis.Text = "Verkaufspreis:";
            // 
            // lbl_anzahl
            // 
            this.lbl_anzahl.AutoSize = true;
            this.lbl_anzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anzahl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_anzahl.Location = new System.Drawing.Point(166, 173);
            this.lbl_anzahl.Name = "lbl_anzahl";
            this.lbl_anzahl.Size = new System.Drawing.Size(69, 20);
            this.lbl_anzahl.TabIndex = 16;
            this.lbl_anzahl.Text = "Anzahl:";
            // 
            // num_anzahl
            // 
            this.num_anzahl.Location = new System.Drawing.Point(241, 173);
            this.num_anzahl.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.num_anzahl.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.num_anzahl.Name = "num_anzahl";
            this.num_anzahl.Size = new System.Drawing.Size(311, 20);
            this.num_anzahl.TabIndex = 17;
            this.num_anzahl.Visible = false;
            // 
            // txt_bezeichnung
            // 
            this.txt_bezeichnung.Location = new System.Drawing.Point(241, 95);
            this.txt_bezeichnung.MaxLength = 20;
            this.txt_bezeichnung.Name = "txt_bezeichnung";
            this.txt_bezeichnung.Size = new System.Drawing.Size(311, 20);
            this.txt_bezeichnung.TabIndex = 18;
            this.txt_bezeichnung.Visible = false;
            // 
            // btn_ok
            // 
            this.btn_ok.AutoSize = true;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(558, 214);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(112, 32);
            this.btn_ok.TabIndex = 22;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_zurueck
            // 
            this.btn_zurueck.AutoSize = true;
            this.btn_zurueck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zurueck.Location = new System.Drawing.Point(12, 536);
            this.btn_zurueck.Name = "btn_zurueck";
            this.btn_zurueck.Size = new System.Drawing.Size(77, 32);
            this.btn_zurueck.TabIndex = 23;
            this.btn_zurueck.Text = "Zurück";
            this.btn_zurueck.UseVisualStyleBackColor = true;
            this.btn_zurueck.Click += new System.EventHandler(this.btn_zurueck_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_aktualisieren);
            this.groupBox1.Controls.Add(this.rbtn_neuerartikel);
            this.groupBox1.Location = new System.Drawing.Point(241, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 56);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // rbtn_aktualisieren
            // 
            this.rbtn_aktualisieren.AutoSize = true;
            this.rbtn_aktualisieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_aktualisieren.Location = new System.Drawing.Point(154, 19);
            this.rbtn_aktualisieren.Name = "rbtn_aktualisieren";
            this.rbtn_aktualisieren.Size = new System.Drawing.Size(151, 24);
            this.rbtn_aktualisieren.TabIndex = 1;
            this.rbtn_aktualisieren.Text = "Artikel bearbeiten";
            this.rbtn_aktualisieren.UseVisualStyleBackColor = true;
            this.rbtn_aktualisieren.CheckedChanged += new System.EventHandler(this.rbtn_aktualisieren_CheckedChanged);
            // 
            // rbtn_neuerartikel
            // 
            this.rbtn_neuerartikel.AutoSize = true;
            this.rbtn_neuerartikel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_neuerartikel.Location = new System.Drawing.Point(6, 19);
            this.rbtn_neuerartikel.Name = "rbtn_neuerartikel";
            this.rbtn_neuerartikel.Size = new System.Drawing.Size(118, 24);
            this.rbtn_neuerartikel.TabIndex = 0;
            this.rbtn_neuerartikel.Text = "Neuer Artikel";
            this.rbtn_neuerartikel.UseVisualStyleBackColor = true;
            this.rbtn_neuerartikel.CheckedChanged += new System.EventHandler(this.rbtn_neuerartikel_CheckedChanged);
            // 
            // cmb_artikelnr
            // 
            this.cmb_artikelnr.FormattingEnabled = true;
            this.cmb_artikelnr.Items.AddRange(new object[] {
            "hghzgfd",
            "hgfdhd",
            "dgfhfdhg"});
            this.cmb_artikelnr.Location = new System.Drawing.Point(241, 69);
            this.cmb_artikelnr.Name = "cmb_artikelnr";
            this.cmb_artikelnr.Size = new System.Drawing.Size(311, 21);
            this.cmb_artikelnr.TabIndex = 25;
            this.cmb_artikelnr.Visible = false;
            // 
            // cmb_bezeichnung
            // 
            this.cmb_bezeichnung.FormattingEnabled = true;
            this.cmb_bezeichnung.Items.AddRange(new object[] {
            "ghgdfhujztjt",
            "ztuztjgd",
            "edstert"});
            this.cmb_bezeichnung.Location = new System.Drawing.Point(241, 95);
            this.cmb_bezeichnung.Name = "cmb_bezeichnung";
            this.cmb_bezeichnung.Size = new System.Drawing.Size(311, 21);
            this.cmb_bezeichnung.TabIndex = 26;
            this.cmb_bezeichnung.Visible = false;
            // 
            // cmb_ekpreis
            // 
            this.cmb_ekpreis.FormattingEnabled = true;
            this.cmb_ekpreis.Items.AddRange(new object[] {
            "jz7u765",
            "ztrz654",
            "er435"});
            this.cmb_ekpreis.Location = new System.Drawing.Point(241, 121);
            this.cmb_ekpreis.Name = "cmb_ekpreis";
            this.cmb_ekpreis.Size = new System.Drawing.Size(311, 21);
            this.cmb_ekpreis.TabIndex = 27;
            this.cmb_ekpreis.Visible = false;
            // 
            // cmb_vkpreis
            // 
            this.cmb_vkpreis.FormattingEnabled = true;
            this.cmb_vkpreis.Items.AddRange(new object[] {
            "äpoköo",
            "i876iu",
            "jholiuzi"});
            this.cmb_vkpreis.Location = new System.Drawing.Point(241, 147);
            this.cmb_vkpreis.Name = "cmb_vkpreis";
            this.cmb_vkpreis.Size = new System.Drawing.Size(311, 21);
            this.cmb_vkpreis.TabIndex = 28;
            this.cmb_vkpreis.Visible = false;
            // 
            // dat_lagerbestand
            // 
            this.dat_lagerbestand.AllowUserToAddRows = false;
            this.dat_lagerbestand.AllowUserToDeleteRows = false;
            this.dat_lagerbestand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_lagerbestand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_lagerbestand.Location = new System.Drawing.Point(12, 261);
            this.dat_lagerbestand.Name = "dat_lagerbestand";
            this.dat_lagerbestand.Size = new System.Drawing.Size(683, 264);
            this.dat_lagerbestand.TabIndex = 29;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(707, 580);
            this.Controls.Add(this.dat_lagerbestand);
            this.Controls.Add(this.cmb_vkpreis);
            this.Controls.Add(this.cmb_ekpreis);
            this.Controls.Add(this.cmb_bezeichnung);
            this.Controls.Add(this.cmb_artikelnr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_zurueck);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_bezeichnung);
            this.Controls.Add(this.num_anzahl);
            this.Controls.Add(this.lbl_anzahl);
            this.Controls.Add(this.txt_vkpreis);
            this.Controls.Add(this.lbl_vkpreis);
            this.Controls.Add(this.txt_ekpreis);
            this.Controls.Add(this.lbl_ekpreis);
            this.Controls.Add(this.lbl_bezeichnung);
            this.Controls.Add(this.lbl_artikelnr);
            this.Controls.Add(this.lbl_lagerbestand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lagerbestand";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_anzahl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_lagerbestand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lagerbestand;
        private System.Windows.Forms.Label lbl_artikelnr;
        private System.Windows.Forms.Label lbl_bezeichnung;
        private System.Windows.Forms.TextBox txt_ekpreis;
        private System.Windows.Forms.Label lbl_ekpreis;
        private System.Windows.Forms.TextBox txt_vkpreis;
        private System.Windows.Forms.Label lbl_vkpreis;
        private System.Windows.Forms.Label lbl_anzahl;
        private System.Windows.Forms.NumericUpDown num_anzahl;
        private System.Windows.Forms.TextBox txt_bezeichnung;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_zurueck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_aktualisieren;
        private System.Windows.Forms.RadioButton rbtn_neuerartikel;
        private System.Windows.Forms.ComboBox cmb_artikelnr;
        private System.Windows.Forms.ComboBox cmb_bezeichnung;
        private System.Windows.Forms.ComboBox cmb_ekpreis;
        private System.Windows.Forms.ComboBox cmb_vkpreis;
        private System.Windows.Forms.DataGridView dat_lagerbestand;
    }
}