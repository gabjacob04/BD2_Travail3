namespace BD2_Travail3
{
    partial class ModifierProjetConcurrence
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
            this.btnDetruire = new System.Windows.Forms.Button();
            this.grpChoisirProjet = new System.Windows.Forms.GroupBox();
            this.cmbListeProjets = new System.Windows.Forms.ComboBox();
            this.lblNomProjet = new System.Windows.Forms.Label();
            this.dgvInfoSurProjet = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpChoisirProjet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoSurProjet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetruire
            // 
            this.btnDetruire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetruire.Location = new System.Drawing.Point(508, 182);
            this.btnDetruire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetruire.Name = "btnDetruire";
            this.btnDetruire.Size = new System.Drawing.Size(141, 37);
            this.btnDetruire.TabIndex = 18;
            this.btnDetruire.Text = "Détruire ce projet";
            this.btnDetruire.UseVisualStyleBackColor = true;
            // 
            // grpChoisirProjet
            // 
            this.grpChoisirProjet.Controls.Add(this.cmbListeProjets);
            this.grpChoisirProjet.Controls.Add(this.lblNomProjet);
            this.grpChoisirProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChoisirProjet.Location = new System.Drawing.Point(17, 16);
            this.grpChoisirProjet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChoisirProjet.Name = "grpChoisirProjet";
            this.grpChoisirProjet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChoisirProjet.Size = new System.Drawing.Size(632, 105);
            this.grpChoisirProjet.TabIndex = 17;
            this.grpChoisirProjet.TabStop = false;
            this.grpChoisirProjet.Text = "Rechercher un projet";
            // 
            // cmbListeProjets
            // 
            this.cmbListeProjets.FormattingEnabled = true;
            this.cmbListeProjets.Location = new System.Drawing.Point(219, 36);
            this.cmbListeProjets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbListeProjets.Name = "cmbListeProjets";
            this.cmbListeProjets.Size = new System.Drawing.Size(399, 26);
            this.cmbListeProjets.TabIndex = 1;
            this.cmbListeProjets.SelectionChangeCommitted += new System.EventHandler(this.cmbListeProjets_SelectionChangeCommitted);
            // 
            // lblNomProjet
            // 
            this.lblNomProjet.AutoSize = true;
            this.lblNomProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProjet.Location = new System.Drawing.Point(37, 34);
            this.lblNomProjet.Name = "lblNomProjet";
            this.lblNomProjet.Size = new System.Drawing.Size(133, 25);
            this.lblNomProjet.TabIndex = 0;
            this.lblNomProjet.Text = "Nom du projet";
            // 
            // dgvInfoSurProjet
            // 
            this.dgvInfoSurProjet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoSurProjet.Location = new System.Drawing.Point(17, 236);
            this.dgvInfoSurProjet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInfoSurProjet.Name = "dgvInfoSurProjet";
            this.dgvInfoSurProjet.RowHeadersWidth = 51;
            this.dgvInfoSurProjet.RowTemplate.Height = 24;
            this.dgvInfoSurProjet.Size = new System.Drawing.Size(632, 187);
            this.dgvInfoSurProjet.TabIndex = 16;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(13, 190);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(291, 29);
            this.lblInfo.TabIndex = 15;
            this.lblInfo.Text = "Informations sur le projet";
            // 
            // ModifierProjetConcurrence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 441);
            this.Controls.Add(this.btnDetruire);
            this.Controls.Add(this.grpChoisirProjet);
            this.Controls.Add(this.dgvInfoSurProjet);
            this.Controls.Add(this.lblInfo);
            this.Name = "ModifierProjetConcurrence";
            this.Text = "ModifierProjetConcurrence";
            this.Load += new System.EventHandler(this.ModifierProjetConcurrence_Load);
            this.grpChoisirProjet.ResumeLayout(false);
            this.grpChoisirProjet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoSurProjet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetruire;
        private System.Windows.Forms.GroupBox grpChoisirProjet;
        private System.Windows.Forms.ComboBox cmbListeProjets;
        private System.Windows.Forms.Label lblNomProjet;
        private System.Windows.Forms.DataGridView dgvInfoSurProjet;
        private System.Windows.Forms.Label lblInfo;
    }
}