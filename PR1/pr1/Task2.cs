using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Task2 : ITaskeable
    {
        private int[] trengle = new int[3];
        public void Inicelisation()
        {

            for (int i = 0; i < trengle.Length; i++)
            {
                Console.WriteLine("input " + (i + 1) + " Storonu");
                trengle[i] = int.Parse(Console.ReadLine());
                if (trengle[i] <= 0)
                {
                    Console.WriteLine("Incorrect size");
                    break;
                }

            }
        }
        public bool Check()
        {
            return trengle[1] <= 0 || trengle[0] <= 0 || trengle[2] <= 0;
        }
        public void Typ_of_trengle()
        {
            if (trengle[0] == trengle[1] && trengle[2] == trengle[1])
            {
                Console.WriteLine("Your trengle is  Ровностороный");
            }
            else if (trengle[0] == trengle[1] && trengle[2] != trengle[1])
            {
                Console.WriteLine("Your trengle is  Ровнобедреный");
            }

            else
            {
                Console.WriteLine("your trengle is Разносоронный");
            }
        }
        public int Funktion()
        {
            return trengle[1] + trengle[2] + trengle[0];

        }
        public void Perimetr()
        {
            int P = Funktion();
            Console.WriteLine("Your Perimetr is :" + P);
        }
        public void Plosha()
        {
            int P = Funktion();
            int p = P / 2;
            int Form = p * (p - trengle[0]) * (p - trengle[1]) * (p - trengle[2]);
            double S = Math.Sqrt(Form);
            Console.WriteLine("Your Plosha is:" + S);
        }
        public void StartTask()
        {
            Inicelisation();
            if (Check())
            {
                Typ_of_trengle();
                Perimetr();
                Plosha();
            }

        }
    }
}
