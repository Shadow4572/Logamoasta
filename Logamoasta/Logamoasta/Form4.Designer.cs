namespace Logamoasta
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_masuchen = new System.Windows.Forms.RadioButton();
            this.rbtn_maloeschen = new System.Windows.Forms.RadioButton();
            this.rbtn_mabearbeiten = new System.Windows.Forms.RadioButton();
            this.rbtn_maanlegen = new System.Windows.Forms.RadioButton();
            this.btn_zurueck = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_passwort = new System.Windows.Forms.Label();
            this.lbl_gruppe = new System.Windows.Forms.Label();
            this.lbl_benutzername = new System.Windows.Forms.Label();
            this.lbl_bid = new System.Windows.Forms.Label();
            this.lbl_mitarbeiter = new System.Windows.Forms.Label();
            this.txt_benutzername = new System.Windows.Forms.TextBox();
            this.txt_gruppe = new System.Windows.Forms.TextBox();
            this.txt_passwort = new System.Windows.Forms.TextBox();
            this.cmb_bid = new System.Windows.Forms.ComboBox();
            this.cmb_benutzername = new System.Windows.Forms.ComboBox();
            this.cmb_gruppe = new System.Windows.Forms.ComboBox();
            this.mitarbeiter_lst = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_masuchen);
            this.groupBox1.Controls.Add(this.rbtn_maloeschen);
            this.groupBox1.Controls.Add(this.rbtn_mabearbeiten);
            this.groupBox1.Controls.Add(this.rbtn_maanlegen);
            this.groupBox1.Location = new System.Drawing.Point(12, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 56);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // rbtn_masuchen
            // 
            this.rbtn_masuchen.AutoSize = true;
            this.rbtn_masuchen.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_masuchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_masuchen.Location = new System.Drawing.Point(529, 19);
            this.rbtn_masuchen.Name = "rbtn_masuchen";
            this.rbtn_masuchen.Size = new System.Drawing.Size(158, 24);
            this.rbtn_masuchen.TabIndex = 3;
            this.rbtn_masuchen.Text = "Mitarbeiter suchen";
            this.rbtn_masuchen.UseVisualStyleBackColor = false;
            this.rbtn_masuchen.CheckedChanged += new System.EventHandler(this.rbtn_masuchen_CheckedChanged);
            // 
            // rbtn_maloeschen
            // 
            this.rbtn_maloeschen.AutoSize = true;
            this.rbtn_maloeschen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_maloeschen.Location = new System.Drawing.Point(362, 19);
            this.rbtn_maloeschen.Name = "rbtn_maloeschen";
            this.rbtn_maloeschen.Size = new System.Drawing.Size(161, 24);
            this.rbtn_maloeschen.TabIndex = 2;
            this.rbtn_maloeschen.Text = "Mitarbeiter löschen";
            this.rbtn_maloeschen.UseVisualStyleBackColor = true;
            this.rbtn_maloeschen.CheckedChanged += new System.EventHandler(this.rbtn_maloeschen_CheckedChanged);
            // 
            // rbtn_mabearbeiten
            // 
            this.rbtn_mabearbeiten.AutoSize = true;
            this.rbtn_mabearbeiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_mabearbeiten.Location = new System.Drawing.Point(174, 19);
            this.rbtn_mabearbeiten.Name = "rbtn_mabearbeiten";
            this.rbtn_mabearbeiten.Size = new System.Drawing.Size(182, 24);
            this.rbtn_mabearbeiten.TabIndex = 1;
            this.rbtn_mabearbeiten.Text = "Mitarbeiter bearbeiten";
            this.rbtn_mabearbeiten.UseVisualStyleBackColor = true;
            this.rbtn_mabearbeiten.CheckedChanged += new System.EventHandler(this.rbtn_mabearbeiten_CheckedChanged);
            // 
            // rbtn_maanlegen
            // 
            this.rbtn_maanlegen.AutoSize = true;
            this.rbtn_maanlegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_maanlegen.Location = new System.Drawing.Point(5, 19);
            this.rbtn_maanlegen.Name = "rbtn_maanlegen";
            this.rbtn_maanlegen.Size = new System.Drawing.Size(163, 24);
            this.rbtn_maanlegen.TabIndex = 0;
            this.rbtn_maanlegen.Text = "Mitarbeiter anlegen";
            this.rbtn_maanlegen.UseVisualStyleBackColor = true;
            this.rbtn_maanlegen.CheckedChanged += new System.EventHandler(this.rbtn_maanlegen_CheckedChanged);
            // 
            // btn_zurueck
            // 
            this.btn_zurueck.AutoSize = true;
            this.btn_zurueck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zurueck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zurueck.Location = new System.Drawing.Point(12, 538);
            this.btn_zurueck.Name = "btn_zurueck";
            this.btn_zurueck.Size = new System.Drawing.Size(77, 32);
            this.btn_zurueck.TabIndex = 42;
            this.btn_zurueck.Text = "Zurück";
            this.btn_zurueck.UseVisualStyleBackColor = true;
            this.btn_zurueck.Click += new System.EventHandler(this.btn_zurueck_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.AutoSize = true;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(12, 243);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(112, 32);
            this.btn_ok.TabIndex = 41;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_passwort
            // 
            this.lbl_passwort.AutoSize = true;
            this.lbl_passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_passwort.Location = new System.Drawing.Point(148, 155);
            this.lbl_passwort.Name = "lbl_passwort";
            this.lbl_passwort.Size = new System.Drawing.Size(87, 20);
            this.lbl_passwort.TabIndex = 35;
            this.lbl_passwort.Text = "Passwort:";
            // 
            // lbl_gruppe
            // 
            this.lbl_gruppe.AutoSize = true;
            this.lbl_gruppe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gruppe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_gruppe.Location = new System.Drawing.Point(161, 129);
            this.lbl_gruppe.Name = "lbl_gruppe";
            this.lbl_gruppe.Size = new System.Drawing.Size(74, 20);
            this.lbl_gruppe.TabIndex = 33;
            this.lbl_gruppe.Text = "Gruppe:";
            // 
            // lbl_benutzername
            // 
            this.lbl_benutzername.AutoSize = true;
            this.lbl_benutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_benutzername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_benutzername.Location = new System.Drawing.Point(104, 103);
            this.lbl_benutzername.Name = "lbl_benutzername";
            this.lbl_benutzername.Size = new System.Drawing.Size(131, 20);
            this.lbl_benutzername.TabIndex = 32;
            this.lbl_benutzername.Text = "Benutzername:";
            // 
            // lbl_bid
            // 
            this.lbl_bid.AutoSize = true;
            this.lbl_bid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_bid.Location = new System.Drawing.Point(190, 77);
            this.lbl_bid.Name = "lbl_bid";
            this.lbl_bid.Size = new System.Drawing.Size(45, 20);
            this.lbl_bid.TabIndex = 31;
            this.lbl_bid.Text = "BID:";
            // 
            // lbl_mitarbeiter
            // 
            this.lbl_mitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mitarbeiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_mitarbeiter.Location = new System.Drawing.Point(12, 11);
            this.lbl_mitarbeiter.Name = "lbl_mitarbeiter";
            this.lbl_mitarbeiter.Size = new System.Drawing.Size(683, 57);
            this.lbl_mitarbeiter.TabIndex = 29;
            this.lbl_mitarbeiter.Text = "Mitarbeiter";
            this.lbl_mitarbeiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_benutzername
            // 
            this.txt_benutzername.Location = new System.Drawing.Point(241, 103);
            this.txt_benutzername.Name = "txt_benutzername";
            this.txt_benutzername.Size = new System.Drawing.Size(311, 20);
            this.txt_benutzername.TabIndex = 45;
            this.txt_benutzername.Visible = false;
            // 
            // txt_gruppe
            // 
            this.txt_gruppe.Location = new System.Drawing.Point(241, 129);
            this.txt_gruppe.Name = "txt_gruppe";
            this.txt_gruppe.Size = new System.Drawing.Size(311, 20);
            this.txt_gruppe.TabIndex = 46;
            this.txt_gruppe.Visible = false;
            // 
            // txt_passwort
            // 
            this.txt_passwort.Location = new System.Drawing.Point(241, 155);
            this.txt_passwort.Name = "txt_passwort";
            this.txt_passwort.Size = new System.Drawing.Size(311, 20);
            this.txt_passwort.TabIndex = 47;
            this.txt_passwort.Visible = false;
            // 
            // cmb_bid
            // 
            this.cmb_bid.FormattingEnabled = true;
            this.cmb_bid.Location = new System.Drawing.Point(241, 76);
            this.cmb_bid.Name = "cmb_bid";
            this.cmb_bid.Size = new System.Drawing.Size(311, 21);
            this.cmb_bid.TabIndex = 48;
            this.cmb_bid.Visible = false;
            // 
            // cmb_benutzername
            // 
            this.cmb_benutzername.FormattingEnabled = true;
            this.cmb_benutzername.Location = new System.Drawing.Point(241, 102);
            this.cmb_benutzername.Name = "cmb_benutzername";
            this.cmb_benutzername.Size = new System.Drawing.Size(311, 21);
            this.cmb_benutzername.TabIndex = 49;
            this.cmb_benutzername.Visible = false;
            // 
            // cmb_gruppe
            // 
            this.cmb_gruppe.FormattingEnabled = true;
            this.cmb_gruppe.Location = new System.Drawing.Point(241, 129);
            this.cmb_gruppe.Name = "cmb_gruppe";
            this.cmb_gruppe.Size = new System.Drawing.Size(311, 21);
            this.cmb_gruppe.TabIndex = 50;
            this.cmb_gruppe.Visible = false;
            // 
            // mitarbeiter_lst
            // 
            this.mitarbeiter_lst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(54)))));
            this.mitarbeiter_lst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mitarbeiter_lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mitarbeiter_lst.FormattingEnabled = true;
            this.mitarbeiter_lst.ItemHeight = 20;
            this.mitarbeiter_lst.Items.AddRange(new object[] {
            "BID\tBenutername\tGruppe"});
            this.mitarbeiter_lst.Location = new System.Drawing.Point(233, 274);
            this.mitarbeiter_lst.Name = "mitarbeiter_lst";
            this.mitarbeiter_lst.Size = new System.Drawing.Size(319, 280);
            this.mitarbeiter_lst.TabIndex = 51;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(707, 580);
            this.Controls.Add(this.mitarbeiter_lst);
            this.Controls.Add(this.cmb_gruppe);
            this.Controls.Add(this.cmb_benutzername);
            this.Controls.Add(this.cmb_bid);
            this.Controls.Add(this.txt_passwort);
            this.Controls.Add(this.txt_gruppe);
            this.Controls.Add(this.txt_benutzername);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_zurueck);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_passwort);
            this.Controls.Add(this.lbl_gruppe);
            this.Controls.Add(this.lbl_benutzername);
            this.Controls.Add(this.lbl_bid);
            this.Controls.Add(this.lbl_mitarbeiter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitarbeiter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_mabearbeiten;
        private System.Windows.Forms.RadioButton rbtn_maanlegen;
        private System.Windows.Forms.Button btn_zurueck;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_passwort;
        private System.Windows.Forms.Label lbl_gruppe;
        private System.Windows.Forms.Label lbl_benutzername;
        private System.Windows.Forms.Label lbl_bid;
        private System.Windows.Forms.Label lbl_mitarbeiter;
        private System.Windows.Forms.RadioButton rbtn_masuchen;
        private System.Windows.Forms.RadioButton rbtn_maloeschen;
        private System.Windows.Forms.TextBox txt_benutzername;
        private System.Windows.Forms.TextBox txt_gruppe;
        private System.Windows.Forms.TextBox txt_passwort;
        private System.Windows.Forms.ComboBox cmb_bid;
        private System.Windows.Forms.ComboBox cmb_benutzername;
        private System.Windows.Forms.ComboBox cmb_gruppe;
        private System.Windows.Forms.ListBox mitarbeiter_lst;
    }
}