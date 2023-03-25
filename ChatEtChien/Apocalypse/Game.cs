using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apocalypse
{
    internal class Game
    {
        public Usine Usine { get; set; }    
        public Ville LaVille { get; set; }

        public Game(Usine usine, Ville laVille)
        {
            Usine = usine;
            LaVille = laVille;
        }   
        // creer ma ville et mon usine , faire une surchage sans param
        public Ville InitialiserBatiment()
        {
            Batiment bat1 = new Batiment("Bt1",Statut.parfait,1);
            Batiment bat2 = new Batiment("Bt2",Statut.necc_reparation,4,55);
            Batiment bat3 = new Batiment("Bt3",Statut.etre_demoli,2);
            Batiment bat4 = new Batiment("Bt4",Statut.necc_reparation,5,115);
            Batiment bat5 = new Batiment("Bt5",Statut.etre_demoli,3);
            Ville city = new Ville("Yaounde", bat1, bat2, bat3, bat4, bat5);

            return city;
        }
    }
}
