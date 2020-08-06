using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Markup;
using System.Xml.Schema;

namespace GuessingAndTestingAndValidating
{
    /*
2	
//	Project Name:Interactivity: Guessing Game
3	
// Contribution: John C. Barrows
4	
//	Feature: Not familur enough with this part but, console game, menu, loops & functions?
5	
//	Start & End dates:  Sun Aug 2 / Sun Aug 9 @ 9:59 pm MDT
6	
//	References:In order of code appearance:
Pendulum movement: Michal Bialecki @ michalbialecki.com
ASCII text "WHAT NUMBERS": http://patorjk.com/
ASCII text "Aloha..": http://patorjk.com/
ASCII text "I WIN": http://patorjk.com/
Starwars beeps: https://code.sololearn.com/cN9GCp8sxk8L/#cs
ASCII text "YOU WIN": http://patorjk.com/
Mario beeps:By Akash Agrawal https://hashtagakash.wordpress.com/2014/01/22/182/
7	
//	Links: See #6
8	
//*/

    class Program
    {
        // private static string quitKey;
        // private static bool quitting;

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            //ASCII text "WHAT NUMBERS": http://patorjk.com/
            Console.WriteLine(@"Welcome to 
                 __          ___    _       _______          
                 \ \        / / |  | |   /\|__   __|         
                  \ \  /\  / /| |__| |  /  \  | |            
                   \ \/  \/ / |  __  | / /\ \ | |            
                    \  /\  /  | |  | |/ ____ \| |            
              _   _ _\/  \/__ |_| _|_/_/____\_\_|___   _____ 
             | \ | | |  | |  \/  |  _ \|  ____|  __ \ / ____|
             |  \| | |  | | \  / | |_) | |__  | |__) | (___  
             | . ` | |  | | |\/| |  _ <|  __| |  _  / \___ \ 
             | |\  | |__| | |  | | |_) | |____| | \ \ ____) |
             |_| \_|\____/|_|  |_|____/|______|_|  \_\_____/ 
                                                            
                                                            
" + "\nCreated by: John C. Barrows\n August 5, 2020 (Year of the great quarantine)");
            
            {
                intro();
            }
            static void intro()//Having fun with tunes
            {
                Console.Beep(600, 200);
                Thread.Sleep(25);
                Console.Beep(600, 200);
                Thread.Sleep(25);
                Console.Beep(600, 200);
                Thread.Sleep(25);

                Console.Beep(200, 1000);
                Thread.Sleep(25);

                Console.Beep(500, 200);
                Thread.Sleep(25);
                Console.Beep(500, 200);
                Thread.Sleep(25);
                Console.Beep(500, 200);
                Thread.Sleep(25);

                Console.Beep(100, 1000);
                Thread.Sleep(25);
            }


                {//Cool, fun intro to a console game I got from Michal Bialecki @ michalbialecki.com
                var counter = 0;
                for (int i = 0; i < 30; i++)
                {
                    Console.Clear();

                    switch (counter % 4)
                    {
                        case 0:
                            {
                                Console.WriteLine("                             ╔════╤╤╤╤════╗");
                                Console.WriteLine("                             ║    │││ \\  ║");
                                Console.WriteLine("                             ║    │││  O  ║");
                                Console.WriteLine("                             ║    OOO     ║");
                                break;
                            };
                        case 1:
                            {
                                Console.WriteLine("                             ╔════╤╤╤╤════╗");
                                Console.WriteLine("                             ║    ││││    ║");
                                Console.WriteLine("                             ║    ││││    ║");
                                Console.WriteLine("                             ║    OOOO    ║");
                                break;
                            };
                        case 2:
                            {
                                Console.WriteLine("                             ╔════╤╤╤╤════╗");
                                Console.WriteLine("                             ║   / │││    ║");
                                Console.WriteLine("                             ║  O  │││    ║");
                                Console.WriteLine("                             ║     OOO    ║");
                                break;
                            };
                        case 3:
                            {
                                Console.WriteLine("                             ╔════╤╤╤╤════╗");
                                Console.WriteLine("                             ║    ││││    ║");
                                Console.WriteLine("                             ║    ││││    ║");
                                Console.WriteLine("                             ║    OOOO    ║");
                                break;
                            };
                    }

                    counter++;
                    Thread.Sleep(100);
                }
            }

            //Console.WriteLine("Press any button to continue");
            //ASCII Text Generator from http://patorjk.com/
            string artWin3 = @"


                                   _       _                 
                             /\   | |     | |                
                            /  \  | | ___ | |__   __ _       
                           / /\ \ | |/ _ \| '_ \ / _` |      
                          / ____ \| | (_) | | | | (_| |      
                         /_/____\_\_|\___/|_|_|_|\__,_| _ _  
                         |  ____|   | | |  / ____|     (_) | 
                         | |__ _   _| | | | (___   __ _ _| | 
                         |  __| | | | | |  \___ \ / _` | | | 
                         | |  | |_| | | |  ____) | (_| | | | 
                         |_|__ \__,_|_|_| |_____/ \__,_|_|_| 
                         |  _ \          | |                 
                         | |_) |_ __ ___ | |                 
                         |  _ <| '__/ _ \| |                 
                         | |_) | | | (_) |_|                 
                         |____/|_|  \___/(_)                 
";
            Console.WriteLine(artWin3);
            Console.Beep();
            Console.WriteLine("Interested in playing a new, simple guessing game with me?\n " +
                "I know I'm a computer but I'm not AI, you still have a chance of winning.\n" +
                " Let's just think of me as player 1 and you as player 2...\n" +
                "Now, I'm thinking of a number between 0 & 100.\n" +
                " All you need to do is use whole numbers to guess what I'm thinking." +
                "Easy enough? Hey just in case you want to exit feel free to type\n  (quit) or  (exit) and you'll vanish in ninja smoke. \n");

            

            Console.WriteLine("Just let me know by either  pressing (y) to give it a go or (n) to run away.");
            string answer = string.Empty;
            answer = Console.ReadKey().KeyChar.ToString().ToLower();
            //Console.WriteLine(answer); Don't think I need this displayed after all
            string qOre = Console.ReadLine();
            string bAnswer;
            bool restart = true;
            int countLimit = 5;
            bool easy = false;

            while (restart)
            {
            if (easy == true)
            {
                countLimit = 20000;
            }
                if (answer != "y")
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    {
                        sadBeep();
                    }
                    static void sadBeep()
                    {
                        Console.Beep(300, 400);
                        Thread.Sleep(300);
                        Console.Beep(200, 400);
                        Thread.Sleep(300);
                        Console.Beep(100, 1000);
                    }
                    Console.WriteLine("No!!! Whyyyyyyy?!?!? \n\n Thanks for dropping by, maybe next time you'll have the intestinal fortitude to proceed?", ConsoleColor.Cyan);
                    return;
                }
                else
                {
                    if (qOre == "quit" || qOre == "exit")
                    {
                        Console.WriteLine("Sorry to see you leave, hope you come back soon");
                        {
                            sadBeep();
                        }
                        static void sadBeep()
                        {
                            Console.Beep(300, 400);
                            Thread.Sleep(300);
                            Console.Beep(200, 400);
                            Thread.Sleep(300);
                            Console.Beep(100, 1000);
                        }
                        Environment.Exit(0);
                    }
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.Beep();
                    Console.WriteLine($"\n\n Okay, kewl. I will give you a total of {countLimit} guesses, go!");
                }
                string tString = string.Empty;
                Random dice = new Random();
                int chickenDinner = dice.Next(0, 100);
                int iGuess;

                int count = 1;
                //int countLimit = 5;

                bool strikeOut = false;
                bool convert = Int32.TryParse(Console.ReadLine(), out iGuess);
                if (convert == false)
                {
                    Console.WriteLine("What the heck is that, try again. This time use a number between 0 and 100. Like 23, 63, 94 maybe?");
                    count--;
                    restart = true;
                }
                int guess = iGuess;
                if (qOre == "quit" || qOre == "exit")
                {
                    Console.WriteLine("Sorry to see you leave, hope you come back soon");
                    Environment.Exit(0);
                }
                while (guess != chickenDinner && !strikeOut)
                {
                    if (count < countLimit)
                    {
                        if (guess > chickenDinner)
                        {
                            {
                                highNote();
                            }
                            static void highNote()
                            {
                                Console.Beep(1000, 300);
                                Thread.Sleep(150);
                                Console.Beep(1000, 300);
                            }
                            Console.WriteLine($"\nThe number you guessed is a little on the high side...\n Let's try a number that's lower than {guess}");
                            Console.Write("How about you gimme another number \n");
                            guess = int.Parse(Console.ReadLine());
                            //guess = Convert.ToInt32(Console.ReadLine());
                            //guess = Console.ReadLine();
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            count++;
                            Console.WriteLine($"\nThat's guess #{count}, be careful you only have {countLimit - count} guesses left...\n");
                        }
                        else if (guess < chickenDinner)
                        {
                            {
                                lowNote();
                            }
                            static void lowNote()
                            {
                                Console.Beep(100, 300);
                                Thread.Sleep(150);
                                Console.Beep(100, 300);
                            }
                            Console.WriteLine($"The number you guessed is a little on the low side...\n Let's try a number that's higher than {guess}");
                            Console.Write("How about you gimme another number \n");


                            guess = Convert.ToInt32(Console.ReadLine());
                            //guess = int.Parse(Console.ReadLine());
                            //guess = Console.ReadLine();
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            count++;
                            Console.WriteLine($"\nThat's guess #{count}, be careful you only have {countLimit - count} guesses left...\n");

                        }
                    }
                    else 
                    {
                        strikeOut = true;
                    }
                }
                if (strikeOut)
                {
                    int compute = Math.Abs(chickenDinner - guess);
                    //ASCII Text Generator from http://patorjk.com/
                    string winArt = @"
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                                                                     
                     __     ____    __    ____  __  .__   __.        
                    |  |    \   \  /  \  /   / |  | |  \ |  |        
                    |  |     \   \/    \/   /  |  | |   \|  |        
                    |  |      \            /   |  | |  . `  |        
                    |  |       \    /\    /    |  | |  |\   |        
                    |__|        \__/  \__/     |__| |__| \__|        
                                                                     
                                                                     
                                                                     
                                                                     


";
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(winArt);
                    Console.WriteLine($"                        Aha! You lose!                             " +
                        $"\n                        The number I chose was {chickenDinner} :-P                        " +
                        $"\n                        You missed by {compute} tiny numbers.                        ");

                    //Beeps courtesy of https://code.sololearn.com/cN9GCp8sxk8L/#cs
                    {
                        starWars();
                    }
                    static void starWars()
                    {
                        Console.Beep(300, 500);
                        Thread.Sleep(50);
                        Console.Beep(300, 500);
                        Thread.Sleep(50);
                        Console.Beep(300, 500);
                        Thread.Sleep(50);
                        Console.Beep(250, 500);
                        Thread.Sleep(50);
                        Console.Beep(350, 250);
                        Console.Beep(300, 500);
                        Thread.Sleep(50);
                        Console.Beep(250, 500);
                        Thread.Sleep(50);
                        Console.Beep(350, 250);
                        Console.Beep(300, 500);
                        Thread.Sleep(50);
                    }
                    Console.WriteLine("\nWould you like to play again? Same as before, enter (y) for yes or (n) for no.\n\n Or type 'e' for easy to play again and have a plethora of guesses...");
                    bAnswer = Console.ReadKey().KeyChar.ToString().ToLower();
                    if (bAnswer == "y")
                    {
                        restart = true;
                    }
                    else if (bAnswer == "e" || bAnswer  == "easy")
                    {
                        easy = true;
                    }
                    else
                    {
                        Console.WriteLine("\nThanks for playing, please do come back to play again in the future!\n", Color.DarkOliveGreen);
                        restart = false;
                    }
                }
                if (!strikeOut)
                {
                    //ASCII Text Generator from http://patorjk.com/
                    string artWin2 = @"
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
    ____    ____  ______    __    __     ____    __    ____  __  .__   __.    
    \   \  /   / /  __  \  |  |  |  |    \   \  /  \  /   / |  | |  \ |  |    
     \   \/   / |  |  |  | |  |  |  |     \   \/    \/   /  |  | |   \|  |    
      \_    _/  |  |  |  | |  |  |  |      \            /   |  | |  . `  |    
        |  |    |  `--'  | |  `--'  |       \    /\    /    |  | |  |\   |    
        |__|     \______/   \______/         \__/  \__/     |__| |__| \__|    
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
                                                                              
";
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(artWin2);
                    //Beeps courtesy of Akash Agrawal https://hashtagakash.wordpress.com/2014/01/22/182/
                    Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125);

                    
                    Console.WriteLine($"\nDang, you guessed {guess} which was correct :'( \n You got it on guess #{count}. You win :'(");
                    Console.WriteLine("Would you like to play again? Same as before, enter (y) for yes or (n) for no.\n\n Or type 'e' for easy to play again and have a plethora of guesses...");
                    bAnswer = Console.ReadKey().KeyChar.ToString().ToLower();
                    //Console.WriteLine(bAnswer);
                    if (bAnswer == "y")
                    {
                        restart = true;
                    }
                    else if (bAnswer == "e" || bAnswer == "easy")
                    {
                        easy = true;
                    }
                    else
                    {
                        Console.WriteLine("\nThanks for playing, please do come back to play again in the future!\n", Color.DarkOliveGreen);
                        //Thread.Sleep(50); I wanted to try to make the console stay up for a short while before closing.
                        restart = false;
                    }
                }



            }
        }
    }
}
