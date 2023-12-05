using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_burge.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        
        static void Burger()
        {
            double flavour_price;
            bool choose = true;

            while (choose)
            {
                string meal_choice = "Burger";
                Console.WriteLine("Flavour \n 1. Chicken R35 \n 2. Beef R40 \n 3. Vegan R45");
                Console.Write("Please enter your flavour choice: ");
                int flavour = Convert.ToInt32(Console.ReadLine());

                if (flavour == 1)
                {
                    string flavour_choice = "Chicken";
                    flavour_price = 35;
                    break;
                }
                else if (flavour == 2)
                {
                    string flavour_choice = "Beef";
                    double flavour_price = 40;
                    break;
                }
                else if (flavour == 2)
                {
                    string flavour_choice = "Beef";
                    double flavour_price = 40;
                    break;
                }
                else if (flavour == 3)
                {
                    string flavour_choice = "Vegan";
                    double flavour_price = 45;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option...");
                }
            }
            Console.WriteLine("Please enter quantity: ");
            int food_quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Would you like a drink? (Y/N): ");
            string drink = Console.ReadLine();

            if (drink.ToUpper() == "Y")
            {
                bool drink_ = true;

                while (drink_)
                {
                    Console.WriteLine("1. Cola R10 \n 2. Juice R13 \n 3. Coffee R16");
                    Console.Write("Please enter choice: ");
                    int drinkcho = Convert.ToInt32(Console.ReadLine());

                    if (drinkcho == 1)
                    {
                        string drink_choice = "Cola";
                        double drink_price = 10;
                        break;
                    }
                    else if (drinkcho == 2)
                    {
                        string drink_choice = "Juice";
                        double drink_price = 20;
                        break;
                    }
                    else if (drinkcho == 3)
                    {
                        string drink_choice = "Coffee";
                        double drink_price = 30;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid option...");
                    }
                }
                Console.WriteLine("Please enter quantity: ");
                int drink_quantity = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine($"You ordered the following items: \n - {food_quantity} x {flavour_choice} {mealchoice} {flavour_price} \n );




                print("You ordered the following items: \n -", quantity, "x", flavour_choice,
                              meal_choice, flavour_price, "\n -", drink_quantity, "x", drink_cho, drink_price)

                        food = quantity * flavour_price
                        drinks = drink_quantity * drink_price

                        total = food + drinks
                        print("Total = ", total)
                        print("Your order will be delivered soon, have a lovely day!")

                    elif drink.upper() == 'N':
                        print("You ordered the following items: \n -", quantity,
                              "x", flavour_choice, meal_choice, flavour_price)

                        total = quantity * flavour_price

                        print("Total = ", total)
                        print("Your order will be delivered soon,have a lovely day!")

            }
        

        }
        static void menu()
        {
            bool pick = true;

            while (pick)
            {
                Console.WriteLine("MENU \n 1) Buge \n 2) Pizza \n 3) Quit");
                Console.WriteLine();
                Console.WriteLine("Enter: ");
                int option = Convert.ToInt32(Console.ReadLine());
                
                 
            }
        }
    }
}
