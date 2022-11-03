using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3
{
    class caffe
    {
        static void Main(string[] args)
        {
            int COMANDI = 1;
            CameraCaffe caffe = new CameraCaffe();
            Console.WriteLine("Hai a disposizione 5 comandi. :)");
            do
            {
                Console.Write("inserire comando della macchina del caffè:");
                char scelta = Convert.ToChar(Console.ReadLine());
                if (scelta == 'p')
                {
                    Console.Write("Vuoi la tazza grande?[0/1]");
                    char Grande =Convert.ToChar(Console.ReadLine());
                    bool isGrande = Grande == 's' ? true : false;
                    caffe.Prepara(isGrande);
                }else if(scelta == 'r')
                {
                    caffe.Riempi();
                }else if(scelta == 's')
                {
                    caffe.Stato();
                }
                else if (scelta == 'c')
                {
                    Console.Clear();
                }

                COMANDI++;
            }while(COMANDI!=5);
            Console.ReadKey();
        }
    }
}
