namespace BD2_Travail3
{
    partial class ModifierQuantiteAssigneesDUnProjet
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
            this.dgvPieces = new System.Windows.Forms.DataGridView();
            this.lblPieces = new System.Windows.Forms.Label();
            this.grpChoisirProjet = new System.Windows.Forms.GroupBox();
            this.cmbListeProjets = new System.Windows.Forms.ComboBox();
            this.lblNomProjet = new System.Windows.Forms.Label();
            this.btnDetruire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieces)).BeginInit();
            this.grpChoisirProjet.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPieces
            // 
            this.dgvPieces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPieces.Location = new System.Drawing.Point(21, 242);
            this.dgvPieces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPieces.Name = "dgvPieces";
            this.dgvPieces.RowHeadersWidth = 51;
            this.dgvPieces.RowTemplate.Height = 24;
            this.dgvPieces.Size = new System.Drawing.Size(632, 187);
            this.dgvPieces.TabIndex = 12;
            this.dgvPieces.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPieces_CellEndEdit);
            // 
            // lblPieces
            // 
            this.lblPieces.AutoSize = true;
            this.lblPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPieces.Location = new System.Drawing.Point(17, 196);
            this.lblPieces.Name = "lblPieces";
            this.lblPieces.Size = new System.Drawing.Size(90, 29);
            this.lblPieces.TabIndex = 10;
            this.lblPieces.Text = "Pièces";
            // 
            // grpChoisirProjet
            // 
            this.grpChoisirProjet.Controls.Add(this.cmbListeProjets);
            this.grpChoisirProjet.Controls.Add(this.lblNomProjet);
            this.grpChoisirProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChoisirProjet.Location = new System.Drawing.Point(21, 22);
            this.grpChoisirProjet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChoisirProjet.Name = "grpChoisirProjet";
            this.grpChoisirProjet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpChoisirProjet.Size = new System.Drawing.Size(632, 105);
            this.grpChoisirProjet.TabIndex = 13;
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
            // btnDetruire
            // 
            this.btnDetruire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetruire.Location = new System.Drawing.Point(673, 52);
            this.btnDetruire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetruire.Name = "btnDetruire";
            this.btnDetruire.Size = new System.Drawing.Size(141, 37);
            this.btnDetruire.TabIndex = 14;
            this.btnDetruire.Text = "Détruire ce projet";
            this.btnDetruire.UseVisualStyleBackColor = true;
            this.btnDetruire.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModifierQuantiteAssigneesDUnProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.btnDetruire);
            this.Controls.Add(this.grpChoisirProjet);
            this.Controls.Add(this.dgvPieces);
            this.Controls.Add(this.lblPieces);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModifierQuantiteAssigneesDUnProjet";
            this.Text = "ModifierQuantiteAssigneesDUneImputation";
            this.Load += new System.EventHandler(this.ModifierQuantiteAssigneesDUneImputation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieces)).EndInit();
            this.grpChoisirProjet.ResumeLayout(false);
            this.grpChoisirProjet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPieces;
        private System.Windows.Forms.Label lblPieces;
        private System.Windows.Forms.GroupBox grpChoisirProjet;
        private System.Windows.Forms.ComboBox cmbListeProjets;
        private System.Windows.Forms.Label lblNomProjet;
        private System.Windows.Forms.Button btnDetruire;
    }
}