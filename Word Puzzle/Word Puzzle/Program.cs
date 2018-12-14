using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Word_Puzzle
{
    class Program
    {
        public static IList<string> SortStringLength(IList<string> stringList)
        {
            string[] strs = stringList.ToArray<string>();
            Array.Sort(strs, new Comparison<string>(delegate (string str1, string str2)
            {
                if (str1.Length < str2.Length)
                    return -1; //shorter string before longer string
                else if (str1.Length > str2.Length)
                    return 1; //longer string after shorter string
                else
                    return str1.CompareTo(str2); //alphabetical order
            }));
            return strs;
        }





        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////INPUT FILES START
            //to define paths
            string path = Directory.GetCurrentDirectory();
            string pathDictionary = path + "\\dictionary.txt";
            string pathPuzzle = path + "\\puzzle.txt";
            
            //to import .txt files
            string[] words = System.IO.File.ReadAllLines(@pathDictionary);
            string[] puzzleText = System.IO.File.ReadAllLines(@pathPuzzle);
            ///////////////////////////////////////////////////////////////////////////////////////INPUT FILES END









            ///////////////////////////////////////////////////////////////////////////////////////VARIABLES START
            bool application = true; ;
            int menu_in = 0;
            ///////////////////////////////////////////////////////////////////////////////////////VARIABLES END









            ///////////////////////////////////////////////////////////////////////////////////////PREPARE VARIABLES START
            words = (string[])SortStringLength(words);
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            ///////////////////////////////////////////////////////////////////////////////////////PREPARE VARIABLES END

            

            //////APPLICATION LOOP START
            while (application)
            {
                bool gameFinished = false;




                /////START SCREEN START
                ///
                Console.Clear();
                Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------|");
                Console.Write("|                      "); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("_          _  __   _        __    __    _  _   ___                           "); Console.ResetColor(); Console.WriteLine(" |");
                Console.Write("|                      "); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("\\ \\        / / |  _| | |      / __|  / _ \\  |  \\/  | |  __|                          "); Console.ResetColor(); Console.WriteLine(" | ");
                Console.Write("|                       "); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("\\ \\  /\\  / /  | |_ |  | |     | |      | |  | | | \\  / | | |_                             "); Console.ResetColor(); Console.WriteLine(" | ");
                Console.Write("|                        "); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("\\ \\//  \\/ /  |  _|   | |     | |      | |  | | | |\\/| | |  _|                            "); Console.ResetColor(); Console.WriteLine(" | ");
                Console.Write("|                         "); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("\\  /\\  /    | |__  | |__ | |__  | |_| | | |  | | | |_                           "); Console.ResetColor(); Console.WriteLine(" | ");
                Console.Write("|                          "); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("\\//  \\//   |__| |__| \\__|  \\_/  ||  || |__|                          "); Console.ResetColor(); Console.WriteLine(" | ");
                Console.WriteLine("|                                                                                                                    | ");
                
                
                //Console.WriteLine("|  Please upload your puzzle and words as two seperate .txt file and open program again.If you uploaded files ignore this message and continue.|");
                Console.WriteLine("| - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -|");
                Console.Write("|               |                                   "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("Menu"); Console.ResetColor(); Console.WriteLine("                                            |                |");
                Console.WriteLine("|               |- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -|                |");
                Console.Write("|               | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("1 - If you want to continue and see your solutions please press 1."); Console.ResetColor(); Console.WriteLine("                |                |");
                Console.Write("|               | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("2 - If you want to see tutorials and informations about program please press 2."); Console.ResetColor(); Console.WriteLine("   |                |");
                Console.Write("|               | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("3 - If you want to exit please press 3."); Console.ResetColor(); Console.WriteLine("                                           |                |");
                Console.WriteLine("|               |- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -|                |");
                Console.WriteLine("|--------------------------------------------------------------------------------------------------------------------|");
                
                
                //if 
                menu_in = Convert.ToInt16(Console.ReadLine());
                
                //////START SCREEN END


                
                
                
                
                
                
                //////TUTORIAL START

                if (menu_in == 2)
                {
                    Console.Clear();

                    Console.WriteLine("| - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - |");
                    Console.Write("|  |                                                "); Console.ForegroundColor = ConsoleColor.Cyan; Console.Write("Tutorial"); Console.ResetColor(); Console.WriteLine("                                                       |  |");
                    Console.WriteLine("|  |- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -|  |");
                    Console.Write("|  | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("- Program needs compatible puzzle matrix and a word list which we describe as dictionary both in .txt files."); Console.ResetColor(); Console.WriteLine("  |  |");
                    Console.Write("|  | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("- Program will draw a puzzle with given matrix and solve your puzzle step by step while filling blanks with "); Console.ResetColor(); Console.WriteLine("  |  |");
                    Console.Write("|  | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("  words in the dictionary.                                                                                  "); Console.ResetColor(); Console.WriteLine("  |  |");
                    Console.Write("|  | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("                                                                                                            "); Console.ResetColor(); Console.WriteLine("  |  |");
                    Console.Write("|  | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("- Your solution will be given to you both in the end of program and as .txt file in the program folder.     "); Console.ResetColor(); Console.WriteLine("  |  |");
                    Console.Write("|  | "); Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("- Please enter and wait.                                                                                    "); Console.ResetColor(); Console.WriteLine("  |  |");
                    Console.WriteLine("|  |- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -|  |");
                    Console.WriteLine("|---------------------------------------------------------------------------------------------------------------------|");
                    //other alternative word for compatible -congruent- 

                    Console.ReadLine();
                }

                /////TUTORIAL END


                
                
                
                
                
                ///////GAME LOOP START
                if (menu_in == 1)
                {
                    int wordCounter = 0;









                    //////TURN LOOP START
                    while (!gameFinished)
                    {
                        bool boxFound = false;



                        ////////////////////////////////////////////////////////////////////////////////////////PRINT GAME SCREEN START


                        //to write word counter
                        Console.Clear();
                        Console.WriteLine("WORD = " + wordCounter);
                        


                        //to write emty screen
                        Console.WriteLine(" 012345678901234      +-WORD-LIST--------------+");
                        Console.WriteLine("0                     |                        |");
                        Console.WriteLine("1                     |                        |");
                        Console.WriteLine("2                     |                        |");
                        Console.WriteLine("3                     |                        |");
                        Console.WriteLine("4                     |                        |");
                        Console.WriteLine("5                     |                        |");
                        Console.WriteLine("6                     |                        |");
                        Console.WriteLine("7                     |                        |");
                        Console.WriteLine("8                     |                        |");
                        Console.WriteLine("9                     |                        |");
                        Console.WriteLine("0                     |                        |");
                        Console.WriteLine("1                     |                        |");
                        Console.WriteLine("2                     |                        |");
                        Console.WriteLine("3                     |                        |");
                        Console.WriteLine("4                     +------------------------+");


                        //messages
                        Console.SetCursorPosition(0, puzzleText.GetLength(0) + 2);
                        if (wordCounter == 0)
                        {
                            Console.WriteLine("Press \"ENTER\" to start.");
                        }
                        else
                        {
                            //write the message when word counter is not 0
                        }
                        wordCounter++;



                        //to write words
                        for (int i = 0; i < words.GetLength(0); i++)
                        {
                            int xList = 0, yList = 0;
                            

                            if (i < puzzleText.GetLength(0) - 1)
                            {
                                xList = 9 + puzzleText[0].Length;
                            }
                            else
                            {
                                xList = 20 + puzzleText[0].Length;
                            }

                            yList = (i % (puzzleText[0].Length - 1)) + 2;

                            Console.SetCursorPosition(xList,yList);
                            Console.Write("[ ]" + words[i]);
                        }


                        //to print puzzle
                        for (int i = 0; i < puzzleText.GetLength(0); i++)
                        {
                            Console.SetCursorPosition(1,2+i);
                            Console.Write(puzzleText[i]);
                        }




                        Console.Read();
                        //////////////////////////////////////////////////////////////////////////////////////////PRINT GAME SCREEN START






                        ////////////////////////////////////SCAN BOXES START


                        //specify loop START
                        while (!boxFound)
                        {

                        }
                        //specify loop end


                        //box anaysis loop start
                        while (!boxFound)
                        {

                        }
                        // box alaysis loop end


                        //step by step loop start
                        while (!boxFound)
                        {

                        }
                        //step by step loop end

                        ///////////////////////////////////SCAN BOXES END







                        ///////FIT WORD START

                        ///////FIT WORD END



                        
                    
                        ///////CONTROL PUZZLE FISINHED START

                        ///////CONTROL PUZZLE FINISHED END






                    }
                    ///////TURN LOOP END
                    
                }
                ////////GAME LOOP END


                
            
            
            
                //////CREATE SOLUTION ARRAY START

                //TO TEXT

                ////////CREATE SOLUTION ARRAY END
                
                
                
                
                
                
                //////END SCREEN START

                //////END SCREEN END





            }
            ///////APPLICATION LOOP END



        }
    }
}
