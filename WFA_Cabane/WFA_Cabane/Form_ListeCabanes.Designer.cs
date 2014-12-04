namespace WFA_Cabane
{
    partial class Form_ListeCabanes
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
            this.Btn_Recherche = new System.Windows.Forms.Button();
            this.TxtBx_Recherche = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LstBx_ListeCabane = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Recherche
            // 
            this.Btn_Recherche.Location = new System.Drawing.Point(296, 10);
            this.Btn_Recherche.Name = "Btn_Recherche";
            this.Btn_Recherche.Size = new System.Drawing.Size(136, 23);
            this.Btn_Recherche.TabIndex = 0;
            this.Btn_Recherche.Text = "Rechercher une cabane";
            this.Btn_Recherche.UseVisualStyleBackColor = true;
            this.Btn_Recherche.Click += new System.EventHandler(this.Btn_Recherche_Click);
            // 
            // TxtBx_Recherche
            // 
            this.TxtBx_Recherche.Location = new System.Drawing.Point(12, 12);
            this.TxtBx_Recherche.Name = "TxtBx_Recherche";
            this.TxtBx_Recherche.Size = new System.Drawing.Size(278, 20);
            this.TxtBx_Recherche.TabIndex = 1;
            this.TxtBx_Recherche.TextChanged += new System.EventHandler(this.TxtBx_Recherche_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LstBx_ListeCabane);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 422);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des Cabanes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LstBx_ListeCabane
            // 
            this.LstBx_ListeCabane.DisplayMember = "Nom";
            this.LstBx_ListeCabane.FormattingEnabled = true;
            this.LstBx_ListeCabane.Location = new System.Drawing.Point(6, 34);
            this.LstBx_ListeCabane.Name = "LstBx_ListeCabane";
            this.LstBx_ListeCabane.Size = new System.Drawing.Size(408, 381);
            this.LstBx_ListeCabane.TabIndex = 0;
            this.LstBx_ListeCabane.SelectedIndexChanged += new System.EventHandler(this.LstBx_ListeCabane_SelectedIndexChanged);
            this.LstBx_ListeCabane.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstBx_ListeCabane_MouseDoubleClick);
            // 
            // Form_ListeCabanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtBx_Recherche);
            this.Controls.Add(this.Btn_Recherche);
            this.Name = "Form_ListeCabanes";
            this.Text = "Form_ListeCabanes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_ListeCabanes_FormClosed);
            this.Load += new System.EventHandler(this.Form_ListeCabanes_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Recherche;
        private System.Windows.Forms.TextBox TxtBx_Recherche;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LstBx_ListeCabane;
    }
}