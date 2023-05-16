using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_MarvinSantos
{
    internal class Desk
    {
        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public decimal NumberOfDrawers { get; set; }

        public string DeskMaterial { get; set; }

        //Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINNUMOFDRAWERS = 0;
        public const int MAXNUMOFDRAWERS = 7;

        //Matrials
        //[Flags]
        public enum Material
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        }


    }
}
