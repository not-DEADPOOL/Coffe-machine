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
            bool continua;
            CameraCaffe caffe = new CameraCaffe();

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

                Console.WriteLine("Vuoi continuare?[s/n]");
                continua = Console.ReadLine() == "s" ? true : false;
            }while(continua);
            Console.ReadKey();
        }
    }
}
