using System.Diagnostics;
using System;
using System.ComponentModel.Design;

namespace pr1 {
   
    internal class Program
    {
        
        private static void Main(string[] args)
        {
            ITaskeable task1 = new Task1();
            ITaskeable task2 = new Task2();
            ITaskeable task3 = new Task3();
            ITaskeable task4 = new Task4();

            ITaskeable[] array = { task1,task2, task3, task4 };

            foreach (ITaskeable task in array) 
            {
                task.StartTask();
            }
        }
    }
}
