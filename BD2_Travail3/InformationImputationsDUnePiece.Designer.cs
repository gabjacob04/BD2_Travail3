namespace BD2_Travail3
{
    partial class InformationImputationsDUnePiece
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
            this.grpRechercherPiece = new System.Windows.Forms.GroupBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.dgvAfficherPiece = new System.Windows.Forms.DataGridView();
            this.txtRechercheNumeroPiece = new System.Windows.Forms.TextBox();
            this.lblSelectionPieceDesiree = new System.Windows.Forms.Label();
            this.lblNoPiece = new System.Windows.Forms.Label();
            this.grpSelectionMois = new System.Windows.Forms.GroupBox();
            this.nudAnnee = new System.Windows.Forms.NumericUpDown();
            this.nudMois = new System.Windows.Forms.NumericUpDown();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.lblMois = new System.Windows.Forms.Label();
            this.lblImputationPiece = new System.Windows.Forms.Label();
            this.btnAfficherInformations = new System.Windows.Forms.Button();
            this.dgvImputationDUnePiece = new System.Windows.Forms.DataGridView();
            this.grpRechercherPiece.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficherPiece)).BeginInit();
            this.grpSelectionMois.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImputationDUnePiece)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRechercherPiece
            // 
            this.grpRechercherPiece.Controls.Add(this.btnRechercher);
            this.grpRechercherPiece.Controls.Add(this.dgvAfficherPiece);
            this.grpRechercherPiece.Controls.Add(this.txtRechercheNumeroPiece);
            this.grpRechercherPiece.Controls.Add(this.lblSelectionPieceDesiree);
            this.grpRechercherPiece.Controls.Add(this.lblNoPiece);
            this.grpRechercherPiece.Location = new System.Drawing.Point(30, 12);
            this.grpRechercherPiece.Name = "grpRechercherPiece";
            this.grpRechercherPiece.Size = new System.Drawing.Size(735, 252);
            this.grpRechercherPiece.TabIndex = 1;
            this.grpRechercherPiece.TabStop = false;
            this.grpRechercherPiece.Text = "Rechercher une pièce avec ou sans scanneur";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(505, 38);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(176, 29);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // dgvAfficherPiece
            // 
            this.dgvAfficherPiece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfficherPiece.Location = new System.Drawing.Point(37, 112);
            this.dgvAfficherPiece.Name = "dgvAfficherPiece";
            this.dgvAfficherPiece.RowHeadersWidth = 51;
            this.dgvAfficherPiece.RowTemplate.Height = 24;
            this.dgvAfficherPiece.Size = new System.Drawing.Size(644, 125);
            this.dgvAfficherPiece.TabIndex = 4;
            // 
            // txtRechercheNumeroPiece
            // 
            this.txtRechercheNumeroPiece.Location = new System.Drawing.Point(314, 39);
            this.txtRechercheNumeroPiece.Name = "txtRechercheNumeroPiece";
            this.txtRechercheNumeroPiece.Size = new System.Drawing.Size(170, 27);
            this.txtRechercheNumeroPiece.TabIndex = 2;
            // 
            // lblSelectionPieceDesiree
            // 
            this.lblSelectionPieceDesiree.AutoSize = true;
            this.lblSelectionPieceDesiree.Location = new System.Drawing.Point(37, 76);
            this.lblSelectionPieceDesiree.Name = "lblSelectionPieceDesiree";
            this.lblSelectionPieceDesiree.Size = new System.Drawing.Size(199, 20);
            this.lblSelectionPieceDesiree.TabIndex = 1;
            this.lblSelectionPieceDesiree.Text = "Sélectionner la pièce désirée";
            // 
            // lblNoPiece
            // 
            this.lblNoPiece.AutoSize = true;
            this.lblNoPiece.Location = new System.Drawing.Point(37, 42);
            this.lblNoPiece.Name = "lblNoPiece";
            this.lblNoPiece.Size = new System.Drawing.Size(271, 20);
            this.lblNoPiece.TabIndex = 0;
            this.lblNoPiece.Text = "numéro de pièce (ou partie de numéro)";
            // 
            // grpSelectionMois
            // 
            this.grpSelectionMois.Controls.Add(this.nudAnnee);
            this.grpSelectionMois.Controls.Add(this.nudMois);
            this.grpSelectionMois.Controls.Add(this.lblAnnee);
            this.grpSelectionMois.Controls.Add(this.lblMois);
            this.grpSelectionMois.Location = new System.Drawing.Point(30, 285);
            this.grpSelectionMois.Name = "grpSelectionMois";
            this.grpSelectionMois.Size = new System.Drawing.Size(735, 105);
            this.grpSelectionMois.TabIndex = 2;
            this.grpSelectionMois.TabStop = false;
            this.grpSelectionMois.Text = "Sélectionner le mois";
            // 
            // nudAnnee
            // 
            this.nudAnnee.Location = new System.Drawing.Point(138, 66);
            this.nudAnnee.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nudAnnee.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudAnnee.Name = "nudAnnee";
            this.nudAnnee.Size = new System.Drawing.Size(150, 27);
            this.nudAnnee.TabIndex = 7;
            this.nudAnnee.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nudMois
            // 
            this.nudMois.Location = new System.Drawing.Point(138, 32);
            this.nudMois.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMois.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMois.Name = "nudMois";
            this.nudMois.Size = new System.Drawing.Size(150, 27);
            this.nudMois.TabIndex = 6;
            this.nudMois.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Location = new System.Drawing.Point(37, 68);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(51, 20);
            this.lblAnnee.TabIndex = 5;
            this.lblAnnee.Text = "Année";
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Location = new System.Drawing.Point(37, 34);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(41, 20);
            this.lblMois.TabIndex = 0;
            this.lblMois.Text = "Mois";
            // 
            // lblImputationPiece
            // 
            this.lblImputationPiece.AutoSize = true;
            this.lblImputationPiece.Location = new System.Drawing.Point(30, 408);
            this.lblImputationPiece.Name = "lblImputationPiece";
            this.lblImputationPiece.Size = new System.Drawing.Size(180, 20);
            this.lblImputationPiece.TabIndex = 3;
            this.lblImputationPiece.Text = "Imputation de cette pièce";
            // 
            // btnAfficherInformations
            // 
            this.btnAfficherInformations.Location = new System.Drawing.Point(535, 404);
            this.btnAfficherInformations.Name = "btnAfficherInformations";
            this.btnAfficherInformations.Size = new System.Drawing.Size(230, 29);
            this.btnAfficherInformations.TabIndex = 8;
            this.btnAfficherInformations.Text = "Afficher les informations";
            this.btnAfficherInformations.UseVisualStyleBackColor = true;
            // 
            // dgvImputationDUnePiece
            // 
            this.dgvImputationDUnePiece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImputationDUnePiece.Location = new System.Drawing.Point(30, 439);
            this.dgvImputationDUnePiece.Name = "dgvImputationDUnePiece";
            this.dgvImputationDUnePiece.RowHeadersWidth = 51;
            this.dgvImputationDUnePiece.RowTemplate.Height = 24;
            this.dgvImputationDUnePiece.Size = new System.Drawing.Size(735, 147);
            this.dgvImputationDUnePiece.TabIndex = 9;
            // 
            // InformationImputationsDUnePiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.dgvImputationDUnePiece);
            this.Controls.Add(this.btnAfficherInformations);
            this.Controls.Add(this.lblImputationPiece);
            this.Controls.Add(this.grpSelectionMois);
            this.Controls.Add(this.grpRechercherPiece);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InformationImputationsDUnePiece";
            this.Text = "informationImputationsDUnePiece";
            this.Load += new System.EventHandler(this.InformationImputationsDUnePiece_Load);
            this.grpRechercherPiece.ResumeLayout(false);
            this.grpRechercherPiece.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficherPiece)).EndInit();
            this.grpSelectionMois.ResumeLayout(false);
            this.grpSelectionMois.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImputationDUnePiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRechercherPiece;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.DataGridView dgvAfficherPiece;
        private System.Windows.Forms.TextBox txtRechercheNumeroPiece;
        private System.Windows.Forms.Label lblSelectionPieceDesiree;
        private System.Windows.Forms.Label lblNoPiece;
        private System.Windows.Forms.GroupBox grpSelectionMois;
        private System.Windows.Forms.NumericUpDown nudAnnee;
        private System.Windows.Forms.NumericUpDown nudMois;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.Label lblImputationPiece;
        private System.Windows.Forms.Button btnAfficherInformations;
        private System.Windows.Forms.DataGridView dgvImputationDUnePiece;
    }
}