using System;
using System.Collections.Generic;

namespace AT1_BingoNumberGenerator_DanDavison
{
    class Program
    {

        static void Main()
        {
            int limit = 0;
            List<int> list = new List<int>();
            bool limitCheck = false;
            
            Console.WriteLine("");
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("");
            Console.WriteLine("Please enter a number limit: (Max 100)");
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("");

                while (!limitCheck)
                {
                    string input1 = Console.ReadLine();
                    
                    if (int.TryParse(input1, out limit))
                    {

                        if (limit >= 0 && limit <= 100)
                        {
                          limitCheck = true;
                        }
                        
                        else
                        {
                            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * *");
                            Console.WriteLine("Please enter a number within constraint parameters (1 - 100)");
                            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * *");
                        }

                    }
                    
                    else
                    {
                        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                        Console.WriteLine("Input must contain no characters, Please try again: ");
                        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * * *");
                    }
                }

            Console.WriteLine("");
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("Thank you, the number limit for this game is " + limit);
            Console.WriteLine("_______________________________________________________");
            Console.WriteLine("");


//*****************************************************************************************************************************

            int input2 = 0;

            while (input2 != 4)
            {
                Console.WriteLine("Welcome to the Swinburne Bingo Club");
                Console.WriteLine("1. Draw next number");
                Console.WriteLine("2. View all drawn numbers");
                Console.WriteLine("3. Check specific number");
                Console.WriteLine("4. Exit");

                bool inputCheck = false;
                
                while (!inputCheck)
                {
                    string user = Console.ReadLine();
                    
                    if (int.TryParse(user, out input2))
                    {
                        if (input2 >= 0 && input2 <= 4)
                        {
                          inputCheck = true;
                        }
                        else
                        {
                            Console.WriteLine("* * * * * * * * * * * * * * * * * * *");
                            Console.WriteLine("Selection invalid, Please try again: ");
                            Console.WriteLine("* * * * * * * * * * * * * * * * * * *");
                        }

                    }

                    else
                    {
                        Console.WriteLine("* * * * * * * * * * * * * * * * * * *");
                        Console.WriteLine("Selection invalid, Please try again: ");
                        Console.WriteLine("* * * * * * * * * * * * * * * * * * *");
                    }
                }
//*****************************************************************************************************************************
                //Draw next number
                if (input2 == 1)
                {

                    Random random1 = new Random();
                    int RNG = random1.Next(1, limit);

                    if(list.Contains(RNG))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________");
                        Console.WriteLine("");
                        System.Console.WriteLine("Duplicate drawn, Draw again: ");
                        Console.WriteLine("_____________________________________________");
                        Console.WriteLine("");
                    }

                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("The number drawn is " + RNG);
                        Console.WriteLine("_____________________________________________");
                        Console.WriteLine("");
                        list.Add(RNG);
                    }    
                }
//*****************************************************************************************************************************
                //View all drawn numbers
                else if (input2 == 2)
                {
                    int input3 =0;

                    Console.WriteLine("");
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("1. Print all numbers in the order that they were drawn: ");
                    Console.WriteLine("2. Print all numbers in numerical order: ");
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine("");

                    bool optionCheck = false;

                    while (!optionCheck)
                    {
                        string option = Console.ReadLine();

                        if (int.TryParse(option, out input3))
                        {
                            if (input3 >=1 && input3 <=4)
                            {
                            optionCheck = true;
                            }

                            else
                            {
                                Console.WriteLine("* * * * * * * * * * * * * * * * * * *");
                                Console.WriteLine("Selection invalid, Please try again: ");
                                Console.WriteLine("* * * * * * * * * * * * * * * * * * *");
                            }
                        }

                        else 
                        {
                            Console.WriteLine("* * * * * * * * * * * * * * * * * * *");
                            Console.WriteLine("Selection invalid, Please try again: ");
                            Console.WriteLine("* * * * * * * * * * * * * * * * * * *");
                        }
                    }

                    if (input3 == 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("Numbers in the order previously drawn: ");

                        foreach (int num in list)
                        {
                            Console.Write(num +" ");
                        }

                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________");
                        Console.WriteLine("");
                    }

                    else if (input3 == 2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________");
                        Console.WriteLine("");
                        Console.WriteLine("Numbers drawn displayed in numerical order: ");

                        list.Sort();

                        foreach (int numb in list)
                        {
                            Console.Write(numb +" ");
                        }

                        Console.WriteLine("");
                        Console.WriteLine("_____________________________________________");
                        Console.WriteLine("");
                    }

                    else 
                    {
                        Console.WriteLine("");
                        Console.WriteLine("* * * * * * * * * * * * * * * * * * *");
                        Console.WriteLine("Selection invalid, Returned to menu: ");
                        Console.WriteLine("* * * * * * * * * * * * * * * * * * *");
                        Console.WriteLine("");
                    }
                }

//*****************************************************************************************************************************
                //Check specific number
                else if (input2 == 3)
                {
                    int input4 = 0;

                    Console.WriteLine("");
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("Please enter a number to see if it has been drawn: ");
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine("");

                    string search = Console.ReadLine();

                    if (int.TryParse(search, out input4))
                    {
                        if(list.Contains(input4))
                        {
                            Console.WriteLine("");
                            Console.WriteLine("_____________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine(search + " -This number HAS been drawn.");
                            Console.WriteLine("_____________________________________________");
                            Console.WriteLine("");
                        }

                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("_____________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine(search + " -This number HAS NOT been drawn");
                            Console.WriteLine("_____________________________________________");
                            Console.WriteLine("");
                            

                        }
                    }

                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("* * * * * * * * * * * * * * * * * * *");
                        Console.WriteLine("Selection invalid, Returned to menu: ");
                        Console.WriteLine("* * * * * * * * * * * * * * * * * * *");
                        Console.WriteLine("");
                    }
                        
                }

//*****************************************************************************************************************************                
                //Exit
                else if (input2 == 4)
                {
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("Goodbye");
                    Console.WriteLine("_____________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("         AT1 Bingo Number Generator");
                    Console.WriteLine("           Dan Davison, 103009408");
                    Console.WriteLine("_____________________________________________");
                    
                    break;
                }  
            }
        }
    }
}
