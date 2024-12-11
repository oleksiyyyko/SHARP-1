using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pr1
{
    internal class Task4 : ITaskeable
    {
        private int[] arrayX = new int[36];
        private int[] arrayY = new int[36];
        public int MInput()
        {
            int M;
            Console.WriteLine("Input your number");
            M = int.Parse(Console.ReadLine());
            return M;

        }
        public int Inicalisetion_X(int M)
        {
            int not_come = 0;
            for (int i = 0; i < arrayX.Length; i++)
            {
                Console.WriteLine("Input " + (i + 1) + " element ");
                arrayX[i] = int.Parse(Console.ReadLine());
                if (arrayX[i] == 0 || Math.Abs(arrayX[i]) < M)
                {
                    not_come++;
                }
            }
            return not_come;
        }
        public void InicalisetionY(int not_come, int M)
        {
            int[] array_Y = new int[36 - not_come];
            int vel = 0;
            for (int i = 0; i < arrayX.Length; i++)
            {
                if (arrayX[i] != 0 || Math.Abs(arrayX[i]) > M)
                {
                    array_Y[vel] = arrayX[i];
                    vel++;
                }
            }
        }
        public void Output_array(int[] array)
        {
            Console.WriteLine(" Your Array : ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }
        public void StartTask()
        {
            int M = MInput();
            int not = Inicalisetion_X(M);
            Output_array(arrayX);
            InicalisetionY(not, M);
            Output_array(arrayY);
            Console.WriteLine(" Your M: " + M);

        }
    }
}
