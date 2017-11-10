namespace Logamoasta
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_benutzername = new System.Windows.Forms.Label();
            this.txt_benutzername = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.txt_passwort = new System.Windows.Forms.TextBox();
            this.lbl_passwort = new System.Windows.Forms.Label();
            this.btn_anmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_benutzername
            // 
            this.lbl_benutzername.AutoSize = true;
            this.lbl_benutzername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_benutzername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_benutzername.Location = new System.Drawing.Point(12, 69);
            this.lbl_benutzername.Name = "lbl_benutzername";
            this.lbl_benutzername.Size = new System.Drawing.Size(131, 20);
            this.lbl_benutzername.TabIndex = 0;
            this.lbl_benutzername.Text = "Benutzername:";
            // 
            // txt_benutzername
            // 
            this.txt_benutzername.Location = new System.Drawing.Point(149, 69);
            this.txt_benutzername.Name = "txt_benutzername";
            this.txt_benutzername.Size = new System.Drawing.Size(305, 20);
            this.txt_benutzername.TabIndex = 1;
            this.txt_benutzername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_benutzername_KeyDown);
            // 
            // lbl_login
            // 
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_login.Location = new System.Drawing.Point(12, 9);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(442, 57);
            this.lbl_login.TabIndex = 2;
            this.lbl_login.Text = "Login";
            this.lbl_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_passwort
            // 
            this.txt_passwort.Location = new System.Drawing.Point(149, 95);
            this.txt_passwort.Name = "txt_passwort";
            this.txt_passwort.Size = new System.Drawing.Size(311, 20);
            this.txt_passwort.TabIndex = 4;
            this.txt_passwort.UseSystemPasswordChar = true;
            this.txt_passwort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_passwort_KeyDown);
            // 
            // lbl_passwort
            // 
            this.lbl_passwort.AutoSize = true;
            this.lbl_passwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(237)))), ((int)(((byte)(1)))));
            this.lbl_passwort.Location = new System.Drawing.Point(12, 95);
            this.lbl_passwort.Name = "lbl_passwort";
            this.lbl_passwort.Size = new System.Drawing.Size(87, 20);
            this.lbl_passwort.TabIndex = 3;
            this.lbl_passwort.Text = "Passwort:";
            // 
            // btn_anmelden
            // 
            this.btn_anmelden.AutoSize = true;
            this.btn_anmelden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anmelden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anmelden.Location = new System.Drawing.Point(367, 121);
            this.btn_anmelden.Name = "btn_anmelden";
            this.btn_anmelden.Size = new System.Drawing.Size(93, 32);
            this.btn_anmelden.TabIndex = 5;
            this.btn_anmelden.Text = "Anmelden";
            this.btn_anmelden.UseVisualStyleBackColor = true;
            this.btn_anmelden.Click += new System.EventHandler(this.btn_anmelden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(475, 162);
            this.Controls.Add(this.btn_anmelden);
            this.Controls.Add(this.txt_passwort);
            this.Controls.Add(this.lbl_passwort);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.txt_benutzername);
            this.Controls.Add(this.lbl_benutzername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_benutzername;
        private System.Windows.Forms.TextBox txt_benutzername;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox txt_passwort;
        private System.Windows.Forms.Label lbl_passwort;
        private System.Windows.Forms.Button btn_anmelden;
    }
}

