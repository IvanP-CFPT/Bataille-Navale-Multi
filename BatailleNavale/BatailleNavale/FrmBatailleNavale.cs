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
    public partial class FrmBatailleNavale : Form
    {
        // Déclaration des variables :
        private int NbLigne;
        private int NbColonne;
        private int NbBateau;

        private int groupeBoxWidth;
        private int groupeBoxHeight;

        private int FrmHeight;

        private bool preparation = true;

        public Joueur joueur;
        public Joueur ennemi;

        // Constructeur
        public FrmBatailleNavale(int nbLigne, int nbColonne, int nbBateau)
        {
            InitializeComponent();

            // Initialisation des variables
            NbLigne = nbLigne;
            NbColonne = nbColonne;
            NbBateau = nbBateau;

            groupeBoxWidth = 850;
            groupeBoxHeight = 450;

            FrmHeight = groupeBoxHeight * 2 + 70;

            // Creation des joueurs
            joueur = new Joueur(NbBateau, true, NbColonne, NbLigne);
            ennemi = new Joueur(NbBateau, false, NbColonne, NbLigne);

            // Adaptation de la taille de l'interface
            gbEnnemi.Size = new Size(groupeBoxWidth, groupeBoxHeight);
            gbJoueur.Size = new Size(groupeBoxWidth, groupeBoxHeight);

            this.Height = FrmHeight;

            // Creation du plateau de jeu
            CreationTableau(NbLigne, NbColonne);
            CreationInteface();

            gbEnnemi.Enabled = false;
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            gbJoueur.Enabled = !gbJoueur.Enabled;
            gbEnnemi.Enabled = !gbEnnemi.Enabled;
            btnJouer.Enabled = !btnJouer.Enabled;
            preparation = false;

            IaRandomBoat();



        }

        private void IaRandomBoat()
        {
            Random rnd = new Random();

            int ligne;
            int colonne;

            for (int i = 0; i < ennemi.NbBateauxMax; i++)
            {
                ligne = rnd.Next(0, NbLigne);
                colonne = rnd.Next(0, NbColonne);

                if(ennemi.Plateau[ligne, colonne].Boat)
                {
                    i-=1;
                }
                else
                {
                    ennemi.Plateau[ligne, colonne].ToggleBoat();
                    ennemi.AddBoat();
                }
            }
        }


        public void CreationTableau(int nbligne, int nbcolone)
        {
            for (int y = 0; y < nbligne; y++)
            {
                for (int x = 0; x < nbcolone; x++)
                {
                    joueur.Plateau[y, x] = new Case();
                    ennemi.Plateau[y, x] = new Case();
                }
            }         
        }

        public void CreationInteface()
        {
            for(int x = 0; x < NbColonne; x++)
            {
                for(int y = 0; y < NbLigne; y++)         
                {
                    gbEnnemi.Controls.Add(CreateButton(x, y, "Ennemi"));
                    gbJoueur.Controls.Add(CreateButton(x, y, "Joueur"));
                }
            }
        }

        // Creation d'un bouton
        public Button CreateButton(int x, int y, string type)
        {
            // Taille :
            int width = groupeBoxHeight / NbLigne;
            int height = width;

            if (width * NbColonne > groupeBoxWidth)
            {
                width = groupeBoxWidth / NbColonne;
                height = width;
            }

            // Position :
            int posX = x * width;
            int posY = y * height;

            // Objet :
            Button bouton = new Button();

            // Parametre :
            bouton.Location = new Point(posX, posY);
            bouton.Size = new Size(width, height);
            bouton.Name = Convert.ToString(x + ":" + y);
            bouton.BackColor = Color.White;

            // Méthode quand on click sur le bouton :
            if(type == "Joueur")
            {
                bouton.Click += ButtonJoueurClick;
            }
            else if(type == "Ennemi")
            {
                bouton.Click += ButtonEnemyClick;
            }
            

            return bouton;
        }

        public void ButtonJoueurClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            Case objet = joueur.Plateau[Convert.ToInt32(button.Name.Split(':')[0]), Convert.ToInt32(button.Name.Split(':')[1])];

            if (preparation)
            {
                objet.ToggleBoat();
                if (objet.Boat) // bateau
                {
                    button.BackColor = Color.Gray;
                    joueur.AddBoat();
                }
                else
                {
                    button.BackColor = Color.White;
                    joueur.RemoveBoat();
                }

                if (joueur.NbBateauxPose >= joueur.NbBateauxMax)
                {
                    btnJouer.Enabled = true;
                    BlockBoatSelection();
                }
                else
                {
                    btnJouer.Enabled = false;
                    UnblockBoatSelection();
                }
            }
        }

        public void ButtonEnemyClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            Case objet = ennemi.Plateau[Convert.ToInt32(button.Name.Split(':')[0]), Convert.ToInt32(button.Name.Split(':')[1])];

            if(!preparation){
                objet.ToggleHit();
                if (objet.Boat) // bateau
                {
                    button.BackColor = Color.Red;
                    button.Enabled = false;
                }
                else if (!objet.Boat)
                {
                    button.BackColor = Color.Blue;
                    button.Enabled = false;
                }
            }
        }

        public void BlockBoatSelection()
        {
            foreach(Button btn in gbJoueur.Controls)
            {
                if(btn.BackColor == Color.White)
                {
                    btn.Enabled = false;
                }
            }
        }

        public void UnblockBoatSelection()
        {
            foreach (Button btn in gbJoueur.Controls)
            {
                btn.Enabled = true;
            }
        }
    }
}
