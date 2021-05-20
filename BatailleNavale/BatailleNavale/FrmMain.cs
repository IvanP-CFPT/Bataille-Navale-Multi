using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatailleNavale
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            int ligne = Convert.ToInt32(nudLigne.Value);
            int colonne = Convert.ToInt32(nudColone.Value);
            int bateau = Convert.ToInt32(nudBateaux.Value);

            if (ligne >= 5 && colonne >= 5)
            {
                FrmBatailleNavale BatailleNavale = new FrmBatailleNavale(ligne, colonne, bateau);



                BatailleNavale.ShowDialog();
            }
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
