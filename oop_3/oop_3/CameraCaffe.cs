using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
    class CameraCaffe
    {
        public int serbatoio = 1000;
        public int Ncaffe = 0;
        public bool tGrande;

        public void Prepara(bool Grande)
        {
            if (serbatoio - 50 < 0 || serbatoio - 80 < 0)
            {
                Console.WriteLine(@"░░░░░▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄░░░░░░░
░░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄░░░░
░░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█░░░
░░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░░█░░
░▄▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░░█░
█░▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒░█
█░▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█
░█░▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█░
░░█░░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█░░
░░░█░░░░██░░▀█▄▄▄█▄▄█▄████░█░░░
░░░░█░░░░▀▀▄░█░░░█░█▀██████░█░░
░░░░░▀▄░░░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█░░
░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░▒░░░█░
░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░░░░█░
░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░░░░█░░");
                return;
            }
                serbatoio -= Grande ? 80 : 50;
                Ncaffe++;
            Console.WriteLine(@"Pronto!

                            (  )   (   )  )
                             ) (   )  (  (
                             ( )  (    ) )
                             _____________
                            <_____________> ___
                            |             |/ _ \
                            |               | | |
                            |               |_| |
                         ___|             |\___/
                        /    \___________/    \
                        \_____________________/
            ");
        }
        public void Riempi()
        {
            serbatoio = 1000;
            Console.WriteLine("Riempito!");
        }
        public void Stato()
        {
            Console.WriteLine($"Il serbatoio contiene {serbatoio} di Acqua.");
            Console.WriteLine($"Finora ho preparato {Ncaffe} caffe'");
        }
    }
}
