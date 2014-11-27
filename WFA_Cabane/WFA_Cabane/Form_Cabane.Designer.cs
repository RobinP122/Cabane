namespace WFA_Cabane
{
    partial class Form_Cabane
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Titre = new System.Windows.Forms.Label();
            this.Btn_ListeCabane = new System.Windows.Forms.Button();
            this.Btn_ListeContact = new System.Windows.Forms.Button();
            this.btn_detail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Titre
            // 
            this.Lbl_Titre.AutoSize = true;
            this.Lbl_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titre.Location = new System.Drawing.Point(53, 46);
            this.Lbl_Titre.Name = "Lbl_Titre";
            this.Lbl_Titre.Size = new System.Drawing.Size(341, 25);
            this.Lbl_Titre.TabIndex = 0;
            this.Lbl_Titre.Text = "Gestionnaire de cabane Suisse";
            // 
            // Btn_ListeCabane
            // 
            this.Btn_ListeCabane.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ListeCabane.Location = new System.Drawing.Point(58, 134);
            this.Btn_ListeCabane.Name = "Btn_ListeCabane";
            this.Btn_ListeCabane.Size = new System.Drawing.Size(316, 55);
            this.Btn_ListeCabane.TabIndex = 1;
            this.Btn_ListeCabane.Text = "Afficher les cabanes";
            this.Btn_ListeCabane.UseVisualStyleBackColor = true;
            this.Btn_ListeCabane.Click += new System.EventHandler(this.Btn_ListeCabane_Click);
            // 
            // Btn_ListeContact
            // 
            this.Btn_ListeContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ListeContact.Location = new System.Drawing.Point(58, 206);
            this.Btn_ListeContact.Name = "Btn_ListeContact";
            this.Btn_ListeContact.Size = new System.Drawing.Size(316, 55);
            this.Btn_ListeContact.TabIndex = 2;
            this.Btn_ListeContact.Text = "Afficher les contacts";
            this.Btn_ListeContact.UseVisualStyleBackColor = true;
            this.Btn_ListeContact.Click += new System.EventHandler(this.Btn_ListeContact_Click);
            // 
            // btn_detail
            // 
            this.btn_detail.Location = new System.Drawing.Point(176, 366);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(97, 26);
            this.btn_detail.TabIndex = 4;
            this.btn_detail.Text = "Cabane detaillee";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // Form_Cabane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 425);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.Btn_ListeContact);
            this.Controls.Add(this.Btn_ListeCabane);
            this.Controls.Add(this.Lbl_Titre);
            this.Name = "Form_Cabane";
            this.Text = "Cabanes Suisse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titre;
        private System.Windows.Forms.Button Btn_ListeCabane;
        private System.Windows.Forms.Button Btn_ListeContact;
        private System.Windows.Forms.Button btn_detail;

    }
}

