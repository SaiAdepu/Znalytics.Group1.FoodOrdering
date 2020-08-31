//using System;

//namespace FoodOrdering.PresentationLayer
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool again = false;
//            do
//            {
//                FoodTypeMenuPresentationLayer ftpl = new FoodTypeMenuPresentationLayer();
//                ftpl.DisplayMenu();
//            one:
//                Console.WriteLine("\nDo you wanna Continue..?");
//                Console.Write("Press Y->Yes OR Press any Key->No: ");
//                string input = Console.ReadLine();
//                if (input.Length > 1)
//                {
//                    Console.WriteLine("\n****** Please enter only 1 Character ******");
//                    goto one;
//                }

//                input = input.ToLower();
//                if (input.Equals("y"))
//                    again = true;
//            } while (again);
//            Console.WriteLine("\n**** Thank You ****");
//            Console.ReadKey();
//        }
//    }
//}
