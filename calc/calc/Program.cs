using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {

            int count;
            Console.WriteLine("choose your function");
            Console.WriteLine("1. * \n2. - \n3. /  \n4. + \n5. %");
            string user = Console.ReadLine();
            if (int.TryParse(user , out count)) {
                switch (count) {
                    case 1:
                        Console.WriteLine("input first: ");
                        string first = Console.ReadLine();
                        Console.WriteLine("input second: ");
                        string second = Console.ReadLine();
                        double total;
                        total = Convert.ToInt32(first) * Convert.ToInt32(second);
                        Console.WriteLine("output: ");
                        Console.WriteLine(total);
                        Console.Read();

                        break;

                    case 2:
                        Console.WriteLine("input first: ");
                        string third = Console.ReadLine();
                        Console.WriteLine("input second: ");
                        string fourth = Console.ReadLine();
                        double total;
                        total = Convert.ToInt32(third) - Convert.ToInt32(fourth);
                        Console.WriteLine("output: ");
                        Console.WriteLine(total);
                        Console.Read();

                        break;

                    case 3:
                        Console.WriteLine("input first: ");
                        string first = Console.ReadLine();
                        Console.WriteLine("input second: ");
                        string second = Console.ReadLine();
                        double total;
                        total = Convert.ToInt32(first) / Convert.ToInt32(second);
                        Console.WriteLine("output: ");
                        Console.WriteLine(total);
                        Console.Read();

                        break;

                    case 4:
                        Console.WriteLine("input first: ");
                        string first = Console.ReadLine();
                        Console.WriteLine("input second: ");
                        string second = Console.ReadLine();
                        double total;
                        total = Convert.ToInt32(first) + Convert.ToInt32(second);
                        Console.WriteLine("output: ");
                        Console.WriteLine(total);
                        Console.Read();

                        break;

                    case 5:
                        Console.WriteLine("input first: ");
                        string first = Console.ReadLine();
                        Console.WriteLine("input second: ");
                        string second = Console.ReadLine();
                        double total;
                        total = Convert.ToInt32(first) % Convert.ToInt32(second);
                        Console.WriteLine("output: ");
                        Console.WriteLine(total);
                        Console.Read();

                        break;

                }
            }
            else {
            }

        }           
        
    }
}
