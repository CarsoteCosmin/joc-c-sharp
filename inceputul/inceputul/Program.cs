using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joc_in_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {           
            //Partea de inceput
            GetAppInfo();
            //Numele jucatorului
            GreetUser();
            
            while (true)
            {               
                //Genereaza un numar aleatoriu
                Random random = new Random();
                int CorrectNumber = random.Next(1, 51);
                //Console.WriteLine(CorrectNumber);
                int Guess = 0;
                int c = 0;
                int limita = 0;
                int money = 500;
                int attempts1 = 7;
                Console.WriteLine("You want to bet on some money?");
                string Answer2 = Console.ReadLine().ToUpper();
                if (Answer2 == "YES")
                {
                    Console.WriteLine("Ok you have {0}$, how much do you want to bet?", money);
                    int bet = Convert.ToInt32(Console.ReadLine());                   
                    while (bet > money && bet > 0)
                    {
                            Console.WriteLine("You dont have enough money...try again.");
                            bet = Convert.ToInt32(Console.ReadLine());           
                    }
                    if(bet < money)
                    {   Console.WriteLine("Guess a number between 1 and 50.");
                        Console.WriteLine("You have {0} attempts.", attempts1);
                            Programm();
                            if(attempts1 == 0)
                            {
                                Console.WriteLine("Sorry you lost :(...");
                                money = money - bet;
                                Console.WriteLine("You still have {0}$ money left.", money);
                            }
                    }
                    
                }
               if(Answer2=="NO")
                {
                    Console.WriteLine("Guess a number between 1 and 50.");
                    Programsimplu();
                    //Joaca iar?
                    Console.WriteLine("Do you want to play again?");
                    string Answer3 = Console.ReadLine().ToUpper();
                    if (Answer3 == "YES")
                    {
                        continue;
                    }
                    else if (Answer3 == "NO")
                    {
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                
                
            }

        }
        //Programul simplu
        static void Programsimplu()
        {
            int Guess = 0;
            int c = 0;
            Random random = new Random();
            int CorrectNumber = random.Next(1, 51);
            while (Guess != CorrectNumber)
            {
                string input = Console.ReadLine();

                //In caz ca nu este o cifra
                if (!int.TryParse(input, out Guess))
                {
                    c++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have to enter a number!");
                    Console.ResetColor();
                    continue;
                }
                //Schimbare de la string la int
                Guess = Int32.Parse(input);
                //Daca numarul este gresit/corect de cel generat aleatoriu
                if (Guess <= CorrectNumber)
                {
                    c++;
                    NumberHigher();
                }
                else
                {
                    c++;
                    NumberLower();
                }
                if (Guess == CorrectNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You won!");
                    Console.WriteLine("You have succeeded in {0} attempts!", c);
                    Console.ResetColor();
                }
            }
        }
        //Partea de inceput
        static void GetAppInfo()
        {
            string appName = "Guess the number";
            string version = "1.0.0";
            string appAuthor = "Carsote Cosmin";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0}: Version  {1}  by  {2}", appName, version, appAuthor);
            Console.ResetColor();
        }
        //Numele jucatorului
        static void GreetUser()
        {
            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Ok {0} let's play a game!", inputName);
        }
        //Numarul este mai mare
        static void NumberHigher()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The number is higher, try again!");
            Console.ResetColor();
        }
        //Numarul este mai mic
        static void NumberLower()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The number is lower, try again!");
            Console.ResetColor();
        }
        //Programul pentru cazul 1
        static void Programm()
        {
            int attempts1 = 7;
            int Guess = 0;
            int c = 0;
            Random random = new Random();
            int CorrectNumber = random.Next(1, 51);                                
              while (Guess != CorrectNumber || attempts1 <=7 )
              {
                string input = Console.ReadLine();

                //In caz ca nu este o cifra
                if (!int.TryParse(input, out Guess))
                {
                    c++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have to enter a number!");
                    Console.ResetColor();
                    continue;
                }
                //Schimbare de la string la int
                Guess = Int32.Parse(input);
                //Daca numarul este gresit de cel generat aleatoriu
                if (Guess <= CorrectNumber && attempts1 > 0)
                {
                    attempts1--;
                    c++;
                    NumberHigher();
                }else
                    {
                        return;
                    }
                if(Guess >= CorrectNumber && attempts1 > 0)
                {
                    attempts1--;
                    c++;
                    NumberLower();
                }
                else
                    {
                        return;
                    }
                if (Guess == CorrectNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You won!");
                    Console.WriteLine("You have succeeded in {0} attempts!", c);
                    Console.ResetColor();
                    
                    
                }
              }
            
              
            
          

        }

    }
}
