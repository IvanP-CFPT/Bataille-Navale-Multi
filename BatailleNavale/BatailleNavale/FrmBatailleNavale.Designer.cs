namespace BatailleNavale
{
    partial class FrmBatailleNavale
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
            this.gbEnnemi = new System.Windows.Forms.GroupBox();
            this.gbJoueur = new System.Windows.Forms.GroupBox();
            this.btnJouer = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // gbEnnemi
            // 
            this.gbEnnemi.Location = new System.Drawing.Point(12, 12);
            this.gbEnnemi.Name = "gbEnnemi";
            this.gbEnnemi.Size = new System.Drawing.Size(850, 450);
            this.gbEnnemi.TabIndex = 0;
            this.gbEnnemi.TabStop = false;
            this.gbEnnemi.Text = "Plateau Adverse";
            // 
            // gbJoueur
            // 
            this.gbJoueur.Location = new System.Drawing.Point(12, 468);
            this.gbJoueur.Name = "gbJoueur";
            this.gbJoueur.Size = new System.Drawing.Size(850, 450);
            this.gbJoueur.TabIndex = 1;
            this.gbJoueur.TabStop = false;
            this.gbJoueur.Text = "Votre Plateau";
            // 
            // btnJouer
            // 
            this.btnJouer.Enabled = false;
            this.btnJouer.Location = new System.Drawing.Point(868, 862);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(360, 56);
            this.btnJouer.TabIndex = 2;
            this.btnJouer.Text = "Commencer l\'attaque";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // FrmBatailleNavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 932);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.gbJoueur);
            this.Controls.Add(this.gbEnnemi);
            this.Name = "FrmBatailleNavale";
            this.Text = "FrmBatailleNavale";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEnnemi;
        private System.Windows.Forms.GroupBox gbJoueur;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}