namespace BD2_Travail3
{
    partial class GererErreurDeConcurrence
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserNomProjet = new System.Windows.Forms.TextBox();
            this.txtDatabaseNomProjet = new System.Windows.Forms.TextBox();
            this.txtOriginalNomProjet = new System.Windows.Forms.TextBox();
            this.btn_prendre_valeur_bd = new System.Windows.Forms.Button();
            this.btn_prendre_valeur_proposé = new System.Windows.Forms.Button();
            this.txtUserDescription = new System.Windows.Forms.TextBox();
            this.txtOriginalDescription = new System.Windows.Forms.TextBox();
            this.txtDatabaseDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre valeur proposée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "La valeur originale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "La valeur qui a été changé dans la BD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(848, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Problème de Concurrence voulez-vous quand même enregistrer votre valeur ?";
            // 
            // txtUserNomProjet
            // 
            this.txtUserNomProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNomProjet.Location = new System.Drawing.Point(509, 117);
            this.txtUserNomProjet.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserNomProjet.Name = "txtUserNomProjet";
            this.txtUserNomProjet.Size = new System.Drawing.Size(524, 34);
            this.txtUserNomProjet.TabIndex = 4;
            // 
            // txtDatabaseNomProjet
            // 
            this.txtDatabaseNomProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabaseNomProjet.Location = new System.Drawing.Point(509, 328);
            this.txtDatabaseNomProjet.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabaseNomProjet.Name = "txtDatabaseNomProjet";
            this.txtDatabaseNomProjet.Size = new System.Drawing.Size(524, 34);
            this.txtDatabaseNomProjet.TabIndex = 5;
            // 
            // txtOriginalNomProjet
            // 
            this.txtOriginalNomProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalNomProjet.Location = new System.Drawing.Point(509, 221);
            this.txtOriginalNomProjet.Margin = new System.Windows.Forms.Padding(4);
            this.txtOriginalNomProjet.Name = "txtOriginalNomProjet";
            this.txtOriginalNomProjet.Size = new System.Drawing.Size(524, 34);
            this.txtOriginalNomProjet.TabIndex = 6;
            // 
            // btn_prendre_valeur_bd
            // 
            this.btn_prendre_valeur_bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prendre_valeur_bd.Location = new System.Drawing.Point(509, 449);
            this.btn_prendre_valeur_bd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_prendre_valeur_bd.Name = "btn_prendre_valeur_bd";
            this.btn_prendre_valeur_bd.Size = new System.Drawing.Size(360, 59);
            this.btn_prendre_valeur_bd.TabIndex = 7;
            this.btn_prendre_valeur_bd.Text = "Prendre la valeur de la BD";
            this.btn_prendre_valeur_bd.UseVisualStyleBackColor = true;
            this.btn_prendre_valeur_bd.Click += new System.EventHandler(this.btn_prendre_valeur_bd_Click);
            // 
            // btn_prendre_valeur_proposé
            // 
            this.btn_prendre_valeur_proposé.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prendre_valeur_proposé.Location = new System.Drawing.Point(112, 449);
            this.btn_prendre_valeur_proposé.Margin = new System.Windows.Forms.Padding(4);
            this.btn_prendre_valeur_proposé.Name = "btn_prendre_valeur_proposé";
            this.btn_prendre_valeur_proposé.Size = new System.Drawing.Size(360, 59);
            this.btn_prendre_valeur_proposé.TabIndex = 8;
            this.btn_prendre_valeur_proposé.Text = "Prendre ma valeur proposée";
            this.btn_prendre_valeur_proposé.UseVisualStyleBackColor = true;
            this.btn_prendre_valeur_proposé.Click += new System.EventHandler(this.btn_prendre_valeur_proposé_Click);
            // 
            // txtUserDescription
            // 
            this.txtUserDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserDescription.Location = new System.Drawing.Point(509, 159);
            this.txtUserDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserDescription.Name = "txtUserDescription";
            this.txtUserDescription.Size = new System.Drawing.Size(524, 34);
            this.txtUserDescription.TabIndex = 9;
            // 
            // txtOriginalDescription
            // 
            this.txtOriginalDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalDescription.Location = new System.Drawing.Point(509, 263);
            this.txtOriginalDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtOriginalDescription.Name = "txtOriginalDescription";
            this.txtOriginalDescription.Size = new System.Drawing.Size(524, 34);
            this.txtOriginalDescription.TabIndex = 10;
            // 
            // txtDatabaseDescription
            // 
            this.txtDatabaseDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabaseDescription.Location = new System.Drawing.Point(509, 370);
            this.txtDatabaseDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDatabaseDescription.Name = "txtDatabaseDescription";
            this.txtDatabaseDescription.Size = new System.Drawing.Size(524, 34);
            this.txtDatabaseDescription.TabIndex = 11;
            // 
            // GererErreurDeConcurrence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtDatabaseDescription);
            this.Controls.Add(this.txtOriginalDescription);
            this.Controls.Add(this.txtUserDescription);
            this.Controls.Add(this.btn_prendre_valeur_proposé);
            this.Controls.Add(this.btn_prendre_valeur_bd);
            this.Controls.Add(this.txtOriginalNomProjet);
            this.Controls.Add(this.txtDatabaseNomProjet);
            this.Controls.Add(this.txtUserNomProjet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GererErreurDeConcurrence";
            this.Text = "comment gérer l\'erreur de concurrence";
            this.Load += new System.EventHandler(this.GererErreurDeConcurrence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserNomProjet;
        private System.Windows.Forms.TextBox txtDatabaseNomProjet;
        private System.Windows.Forms.TextBox txtOriginalNomProjet;
        private System.Windows.Forms.Button btn_prendre_valeur_bd;
        private System.Windows.Forms.Button btn_prendre_valeur_proposé;
        private System.Windows.Forms.TextBox txtUserDescription;
        private System.Windows.Forms.TextBox txtOriginalDescription;
        private System.Windows.Forms.TextBox txtDatabaseDescription;
    }
}