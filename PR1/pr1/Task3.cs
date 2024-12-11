using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Task3 : ITaskeable
    {
        private int[] array = new int [36];
        
        public void Inicelisation()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Input " + (i + 1) + " element ");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public int Min() 
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            return min;

        }
        public int Max() 
        {
             int max = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }

            }
            return max;
        }
        public void Output_array()
        {
             Console.WriteLine(" Your Array: ");
            for (int i = 0; i < array.Length; i++)
            {
               Console.Write(array [i]+ ", ");
            }
        }

        public void StartTask()
        {
            Inicelisation();
            Output_array();
            Console.WriteLine();
            Console.WriteLine(" Your Min num is: " + Min());
            Console.WriteLine(" Your Max num is: " + Max());
        } 
       
    }
}
