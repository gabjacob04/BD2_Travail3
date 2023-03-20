namespace BD2_Travail3
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherModificationEmployeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneImputationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationSurLesImputationsDunePieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercherModificationEmployeToolStripMenuItem,
            this.ajouterUneImputationToolStripMenuItem,
            this.informationSurLesImputationsDunePieceToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // rechercherModificationEmployeToolStripMenuItem
            // 
            this.rechercherModificationEmployeToolStripMenuItem.Name = "rechercherModificationEmployeToolStripMenuItem";
            this.rechercherModificationEmployeToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.rechercherModificationEmployeToolStripMenuItem.Text = "Rechercher/Modification employé";
            this.rechercherModificationEmployeToolStripMenuItem.Click += new System.EventHandler(this.rechercherModificationEmployeToolStripMenuItem_Click);
            // 
            // ajouterUneImputationToolStripMenuItem
            // 
            this.ajouterUneImputationToolStripMenuItem.Name = "ajouterUneImputationToolStripMenuItem";
            this.ajouterUneImputationToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.ajouterUneImputationToolStripMenuItem.Text = "Ajouter une imputation";
            this.ajouterUneImputationToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneImputationToolStripMenuItem_Click);
            // 
            // informationSurLesImputationsDunePieceToolStripMenuItem
            // 
            this.informationSurLesImputationsDunePieceToolStripMenuItem.Name = "informationSurLesImputationsDunePieceToolStripMenuItem";
            this.informationSurLesImputationsDunePieceToolStripMenuItem.Size = new System.Drawing.Size(378, 26);
            this.informationSurLesImputationsDunePieceToolStripMenuItem.Text = "Information sur les imputations d\'une pièce";
            this.informationSurLesImputationsDunePieceToolStripMenuItem.Click += new System.EventHandler(this.informationSurLesImputationsDunePieceToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 195);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherModificationEmployeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneImputationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationSurLesImputationsDunePieceToolStripMenuItem;
    }
}

