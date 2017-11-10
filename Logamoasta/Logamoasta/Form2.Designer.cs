namespace Logamoasta
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_hauptmenue = new System.Windows.Forms.Label();
            this.btn_lagerbestand = new System.Windows.Forms.Button();
            this.btn_lagerverlauf = new System.Windows.Forms.Button();
            this.btn_mitarbeiter = new System.Windows.Forms.Button();
            this.btn_abmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_hauptmenue
            // 
            this.lbl_hauptmenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hauptmenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_hauptmenue.Location = new System.Drawing.Point(12, 9);
            this.lbl_hauptmenue.Name = "lbl_hauptmenue";
            this.lbl_hauptmenue.Size = new System.Drawing.Size(312, 57);
            this.lbl_hauptmenue.TabIndex = 3;
            this.lbl_hauptmenue.Text = "Hauptmenü";
            this.lbl_hauptmenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_lagerbestand
            // 
            this.btn_lagerbestand.AutoSize = true;
            this.btn_lagerbestand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lagerbestand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lagerbestand.Location = new System.Drawing.Point(12, 69);
            this.btn_lagerbestand.Name = "btn_lagerbestand";
            this.btn_lagerbestand.Size = new System.Drawing.Size(312, 32);
            this.btn_lagerbestand.TabIndex = 6;
            this.btn_lagerbestand.Text = "Lagerbestände anzeigen und bearbeiten";
            this.btn_lagerbestand.UseVisualStyleBackColor = true;
            this.btn_lagerbestand.Click += new System.EventHandler(this.btn_lagerbestand_Click);
            // 
            // btn_lagerverlauf
            // 
            this.btn_lagerverlauf.AutoSize = true;
            this.btn_lagerverlauf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lagerverlauf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lagerverlauf.Location = new System.Drawing.Point(12, 107);
            this.btn_lagerverlauf.Name = "btn_lagerverlauf";
            this.btn_lagerverlauf.Size = new System.Drawing.Size(312, 32);
            this.btn_lagerverlauf.TabIndex = 7;
            this.btn_lagerverlauf.Text = "Lagerveränderungen anzeigen und filtern";
            this.btn_lagerverlauf.UseVisualStyleBackColor = true;
            this.btn_lagerverlauf.Click += new System.EventHandler(this.btn_lagerverlauf_Click);
            // 
            // btn_mitarbeiter
            // 
            this.btn_mitarbeiter.AutoSize = true;
            this.btn_mitarbeiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mitarbeiter.Location = new System.Drawing.Point(12, 145);
            this.btn_mitarbeiter.Name = "btn_mitarbeiter";
            this.btn_mitarbeiter.Size = new System.Drawing.Size(312, 32);
            this.btn_mitarbeiter.TabIndex = 8;
            this.btn_mitarbeiter.Text = "Mitarbeiter anzeigen und verwalten";
            this.btn_mitarbeiter.UseVisualStyleBackColor = true;
            this.btn_mitarbeiter.Click += new System.EventHandler(this.btn_mitarbeiter_Click);
            // 
            // btn_abmelden
            // 
            this.btn_abmelden.AutoSize = true;
            this.btn_abmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abmelden.Location = new System.Drawing.Point(12, 183);
            this.btn_abmelden.Name = "btn_abmelden";
            this.btn_abmelden.Size = new System.Drawing.Size(312, 32);
            this.btn_abmelden.TabIndex = 9;
            this.btn_abmelden.Text = "Abmelden";
            this.btn_abmelden.UseVisualStyleBackColor = true;
            this.btn_abmelden.Click += new System.EventHandler(this.btn_abmelden_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(336, 229);
            this.Controls.Add(this.btn_abmelden);
            this.Controls.Add(this.btn_mitarbeiter);
            this.Controls.Add(this.btn_lagerverlauf);
            this.Controls.Add(this.btn_lagerbestand);
            this.Controls.Add(this.lbl_hauptmenue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hauptmenü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hauptmenue;
        private System.Windows.Forms.Button btn_lagerbestand;
        private System.Windows.Forms.Button btn_lagerverlauf;
        private System.Windows.Forms.Button btn_mitarbeiter;
        private System.Windows.Forms.Button btn_abmelden;
    }
}