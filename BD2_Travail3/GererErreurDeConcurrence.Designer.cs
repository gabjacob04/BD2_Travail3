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
            this.txt_valeur_proposé = new System.Windows.Forms.TextBox();
            this.txt_valeur_changee_de_bd = new System.Windows.Forms.TextBox();
            this.txt_valeur_proposee = new System.Windows.Forms.TextBox();
            this.btn_prendre_valeur_bd = new System.Windows.Forms.Button();
            this.btn_prendre_valeur_proposé = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Votre valeur proposée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "La valeur originale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "La valeur qui a été changé dans la BD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(671, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Problème de Concurrence voulez-vous quand même enregistrer votre valeur ?";
            // 
            // txt_valeur_proposé
            // 
            this.txt_valeur_proposé.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valeur_proposé.Location = new System.Drawing.Point(423, 132);
            this.txt_valeur_proposé.Name = "txt_valeur_proposé";
            this.txt_valeur_proposé.Size = new System.Drawing.Size(342, 29);
            this.txt_valeur_proposé.TabIndex = 4;
            this.txt_valeur_proposé.TextChanged += new System.EventHandler(this.txt_valeur_proposé_TextChanged);
            // 
            // txt_valeur_changee_de_bd
            // 
            this.txt_valeur_changee_de_bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valeur_changee_de_bd.Location = new System.Drawing.Point(423, 265);
            this.txt_valeur_changee_de_bd.Name = "txt_valeur_changee_de_bd";
            this.txt_valeur_changee_de_bd.Size = new System.Drawing.Size(342, 29);
            this.txt_valeur_changee_de_bd.TabIndex = 5;
            this.txt_valeur_changee_de_bd.TextChanged += new System.EventHandler(this.txt_valeur_changee_de_bd_TextChanged);
            // 
            // txt_valeur_proposee
            // 
            this.txt_valeur_proposee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valeur_proposee.Location = new System.Drawing.Point(423, 196);
            this.txt_valeur_proposee.Name = "txt_valeur_proposee";
            this.txt_valeur_proposee.Size = new System.Drawing.Size(342, 29);
            this.txt_valeur_proposee.TabIndex = 6;
            // 
            // btn_prendre_valeur_bd
            // 
            this.btn_prendre_valeur_bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prendre_valeur_bd.Location = new System.Drawing.Point(371, 348);
            this.btn_prendre_valeur_bd.Name = "btn_prendre_valeur_bd";
            this.btn_prendre_valeur_bd.Size = new System.Drawing.Size(270, 48);
            this.btn_prendre_valeur_bd.TabIndex = 7;
            this.btn_prendre_valeur_bd.Text = "Prendre la valeur de la BD";
            this.btn_prendre_valeur_bd.UseVisualStyleBackColor = true;
            // 
            // btn_prendre_valeur_proposé
            // 
            this.btn_prendre_valeur_proposé.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prendre_valeur_proposé.Location = new System.Drawing.Point(95, 348);
            this.btn_prendre_valeur_proposé.Name = "btn_prendre_valeur_proposé";
            this.btn_prendre_valeur_proposé.Size = new System.Drawing.Size(270, 48);
            this.btn_prendre_valeur_proposé.TabIndex = 8;
            this.btn_prendre_valeur_proposé.Text = "Prendre ma valeur proposée";
            this.btn_prendre_valeur_proposé.UseVisualStyleBackColor = true;
            // 
            // GéréErreurDeConcurrence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_prendre_valeur_proposé);
            this.Controls.Add(this.btn_prendre_valeur_bd);
            this.Controls.Add(this.txt_valeur_proposee);
            this.Controls.Add(this.txt_valeur_changee_de_bd);
            this.Controls.Add(this.txt_valeur_proposé);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GéréErreurDeConcurrence";
            this.Text = "comment gérer l\'erreur de concurrence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_valeur_proposé;
        private System.Windows.Forms.TextBox txt_valeur_changee_de_bd;
        private System.Windows.Forms.TextBox txt_valeur_proposee;
        private System.Windows.Forms.Button btn_prendre_valeur_bd;
        private System.Windows.Forms.Button btn_prendre_valeur_proposé;
    }
}