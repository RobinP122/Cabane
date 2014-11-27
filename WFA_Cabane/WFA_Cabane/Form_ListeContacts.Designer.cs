namespace WFA_Cabane
{
    partial class Form_ListeContacts
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
            this.LstBx_ListeContact = new System.Windows.Forms.ListBox();
            this.TxtBx_Recherche = new System.Windows.Forms.TextBox();
            this.Btn_Recherche = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LstBx_ListeContact);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 422);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des Contacts";
            // 
            // LstBx_ListeContact
            // 
            this.LstBx_ListeContact.FormattingEnabled = true;
            this.LstBx_ListeContact.Location = new System.Drawing.Point(6, 34);
            this.LstBx_ListeContact.Name = "LstBx_ListeContact";
            this.LstBx_ListeContact.Size = new System.Drawing.Size(408, 381);
            this.LstBx_ListeContact.TabIndex = 0;
            // 
            // TxtBx_Recherche
            // 
            this.TxtBx_Recherche.Location = new System.Drawing.Point(12, 12);
            this.TxtBx_Recherche.Name = "TxtBx_Recherche";
            this.TxtBx_Recherche.Size = new System.Drawing.Size(278, 20);
            this.TxtBx_Recherche.TabIndex = 4;
            this.TxtBx_Recherche.TextChanged += new System.EventHandler(this.TxtBx_Recherche_TextChanged);
            // 
            // Btn_Recherche
            // 
            this.Btn_Recherche.Location = new System.Drawing.Point(296, 10);
            this.Btn_Recherche.Name = "Btn_Recherche";
            this.Btn_Recherche.Size = new System.Drawing.Size(136, 23);
            this.Btn_Recherche.TabIndex = 3;
            this.Btn_Recherche.Text = "Rechercher un Contact";
            this.Btn_Recherche.UseVisualStyleBackColor = true;
            this.Btn_Recherche.Click += new System.EventHandler(this.Btn_Recherche_Click);
            // 
            // Form_ListeContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtBx_Recherche);
            this.Controls.Add(this.Btn_Recherche);
            this.Name = "Form_ListeContacts";
            this.Text = "Form_ListeContacts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_ListeContacts_FormClosed);
            this.Load += new System.EventHandler(this.Form_ListeContacts_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LstBx_ListeContact;
        private System.Windows.Forms.TextBox TxtBx_Recherche;
        private System.Windows.Forms.Button Btn_Recherche;
    }
}