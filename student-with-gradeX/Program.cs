using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_with_gradeX_10v_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students in your class: ");
            int numbers = int.Parse(Console.ReadLine());
            double[] grades = new double[numbers];

            string [] names = new string[numbers];
            Console.WriteLine("Enter x: ");
            double x = double.Parse(Console.ReadLine());
            string target = "";
            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine("Enter a name: ");
                string name = Console.ReadLine();
                names[i] = name;
          
                Console.WriteLine("Enter a grade: ");
                double grad = double.Parse(Console.ReadLine());
                grades[i] = grad;
                if (grad < 2 && grad > 6)
                {
                    break;
                }
                else
                {
                    if (grad == x)
                    {
                        target = name;
                    }
                }
            }
            Console.WriteLine("x is " + target);
        }
    }
}
