using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodStudy
{
    class MainApp
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
        }
    }
    class Product
    {
        private int price = 100;
        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrinPrice()
        {
            Console.WriteLine($"Price :{price}");
        }
    }

    class MainApp
    {

        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void Main(string[] args)
            {
                Product carrot = new Product();
                ref int ref_local_price = ref carrot.GetPrice();
                int normal_local_price = carrot.GetPrice();

                carrot.PrinPrice();
                Console.WriteLine($"Ref Local Price :{ref_local_price}");
                Console.WriteLine($"Normal Local Price :{normal_local_price}");

                ref_local_price = 200;

                carrot.PrinPrice();
                Console.WriteLine($"Ref Local Price :{ref_local_price}");
                Console.WriteLine($"Normal Local Price :{normal_local_price}");

            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}");
            Swap(ref x, ref y);
            Console.WriteLine($"x:{x}, y:{y}");
        }
    }

    class Calculator
    {
        public static int Plus(int a, int b)
        {
            Console.WriteLine("Input : {0}, {1}", a, b);

            int result = a + b;
            return result;
        }
    }
