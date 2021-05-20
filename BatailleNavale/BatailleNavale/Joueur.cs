using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    public class Joueur
    {
        private int _nbBateauxMax;

        private int _nbBateauxPose;

        private bool _playing;

        private Case[,] _plateau;

        public int NbBateauxMax { get => _nbBateauxMax; set => _nbBateauxMax = value; }
        public int NbBateauxPose { get => _nbBateauxPose; set => _nbBateauxPose = value; }
        public bool Playing { get => _playing; set => _playing = value; }
        public Case[,] Plateau { get => _plateau; set => _plateau = value; }

        public Joueur(int nbBateauxMax, bool playing, int nbColonne, int nbLigne)
        {
            Plateau = new Case[nbLigne, nbColonne];

            NbBateauxMax = nbBateauxMax;
            NbBateauxPose = 0;
            Playing = playing;
        }

        public void TogglePlaying()
        {
            Playing = !Playing;
        }

        public void AddBoat()
        {
            if (NbBateauxPose < NbBateauxMax)
            {
                NbBateauxPose += 1;
            }
        }

        public void RemoveBoat()
        {
            if (NbBateauxPose > 0)
            {
                NbBateauxPose -= 1;
            }
        }
    }
}
