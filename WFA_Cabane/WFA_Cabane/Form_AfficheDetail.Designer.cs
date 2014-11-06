namespace WFA_Cabane
{
    partial class Form_AfficheDetail
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
            this.Img_Cabane = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Nom = new System.Windows.Forms.Label();
            this.Lbl_Altitude = new System.Windows.Forms.Label();
            this.Lbl_GPS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Cabane)).BeginInit();
            this.SuspendLayout();
            // 
            // Img_Cabane
            // 
            this.Img_Cabane.Location = new System.Drawing.Point(12, 12);
            this.Img_Cabane.Name = "Img_Cabane";
            this.Img_Cabane.Size = new System.Drawing.Size(235, 232);
            this.Img_Cabane.TabIndex = 0;
            this.Img_Cabane.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altitude";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coordonnées GPS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Nom
            // 
            this.Lbl_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nom.Location = new System.Drawing.Point(300, 48);
            this.Lbl_Nom.Name = "Lbl_Nom";
            this.Lbl_Nom.Size = new System.Drawing.Size(152, 24);
            this.Lbl_Nom.TabIndex = 4;
            this.Lbl_Nom.Text = "Nom Cabane";
            // 
            // Lbl_Altitude
            // 
            this.Lbl_Altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Altitude.Location = new System.Drawing.Point(300, 113);
            this.Lbl_Altitude.Name = "Lbl_Altitude";
            this.Lbl_Altitude.Size = new System.Drawing.Size(152, 24);
            this.Lbl_Altitude.TabIndex = 5;
            this.Lbl_Altitude.Text = "Altitude";
            // 
            // Lbl_GPS
            // 
            this.Lbl_GPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GPS.Location = new System.Drawing.Point(300, 178);
            this.Lbl_GPS.Name = "Lbl_GPS";
            this.Lbl_GPS.Size = new System.Drawing.Size(152, 24);
            this.Lbl_GPS.TabIndex = 6;
            this.Lbl_GPS.Text = "GPS";
            this.Lbl_GPS.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form_AfficheDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.Lbl_GPS);
            this.Controls.Add(this.Lbl_Altitude);
            this.Controls.Add(this.Lbl_Nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Img_Cabane);
            this.Name = "Form_AfficheDetail";
            this.Text = "Form_AfficheDetail";
            ((System.ComponentModel.ISupportInitialize)(this.Img_Cabane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Img_Cabane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_Nom;
        private System.Windows.Forms.Label Lbl_Altitude;
        private System.Windows.Forms.Label Lbl_GPS;
    }
}