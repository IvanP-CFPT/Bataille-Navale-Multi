namespace BatailleNavale
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudLigne = new System.Windows.Forms.NumericUpDown();
            this.nudColone = new System.Windows.Forms.NumericUpDown();
            this.btnValider = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBateaux = new System.Windows.Forms.Label();
            this.nudBateaux = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColone)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBateaux)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lignes :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Colonnes :";
            // 
            // nudLigne
            // 
            this.nudLigne.Location = new System.Drawing.Point(74, 21);
            this.nudLigne.Name = "nudLigne";
            this.nudLigne.Size = new System.Drawing.Size(120, 20);
            this.nudLigne.TabIndex = 2;
            this.nudLigne.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudColone
            // 
            this.nudColone.Location = new System.Drawing.Point(74, 47);
            this.nudColone.Name = "nudColone";
            this.nudColone.Size = new System.Drawing.Size(120, 20);
            this.nudColone.TabIndex = 3;
            this.nudColone.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(219, 63);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(90, 23);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudLigne);
            this.groupBox1.Controls.Add(this.nudColone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametres de Generation du Plateau";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(329, 63);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(90, 23);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBateaux);
            this.groupBox2.Controls.Add(this.nudBateaux);
            this.groupBox2.Location = new System.Drawing.Point(219, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 47);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametres de la partie";
            // 
            // lblBateaux
            // 
            this.lblBateaux.AutoSize = true;
            this.lblBateaux.Location = new System.Drawing.Point(16, 23);
            this.lblBateaux.Name = "lblBateaux";
            this.lblBateaux.Size = new System.Drawing.Size(52, 13);
            this.lblBateaux.TabIndex = 5;
            this.lblBateaux.Text = "Bateaux :";
            // 
            // nudBateaux
            // 
            this.nudBateaux.Location = new System.Drawing.Point(74, 21);
            this.nudBateaux.Name = "nudBateaux";
            this.nudBateaux.Size = new System.Drawing.Size(120, 20);
            this.nudBateaux.TabIndex = 4;
            this.nudBateaux.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 93);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnValider);
            this.Name = "FrmMain";
            this.Text = "Parametres Du Jeu";
            ((System.ComponentModel.ISupportInitialize)(this.nudLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColone)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBateaux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudLigne;
        private System.Windows.Forms.NumericUpDown nudColone;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBateaux;
        private System.Windows.Forms.NumericUpDown nudBateaux;
    }
}

