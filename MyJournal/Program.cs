using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal test = new Journal();
            Console.WriteLine(Journal.journalMessage);
            int choice;
            do
            {
                Console.WriteLine(" \nMenu\n");
                Console.WriteLine("1) Unlock");
                Console.WriteLine("2) Create Entry");
                Console.WriteLine("3) Read Entry");
                Console.WriteLine("4) Lock");
                Console.WriteLine("5) Quit");
                Console.WriteLine("----------------------------------------------------\n");
                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Password:\n");
                            string password = Console.ReadLine();
                            if(Journal.UnlockJournal(password))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You opened the journal");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Your password is incorrect");
                            }
                            break;
                        }
                    case 2:
                        {
                            if(Journal.Entry==null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You must unlock the journal");
                            }
                            else
                            {
                                Console.WriteLine("Enter the journal text");
                                string journalMessage = Console.ReadLine();
                                Journal.Entry.Text = journalMessage;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (Journal.Entry == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("You must unlock the journal");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(Journal.Entry.Text);
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("Last Edit Date & Time:"+Journal.Entry.LastEditTime.ToShortDateString() + " " + Journal.Entry.LastEditTime.ToLongTimeString());
                            }
                            break;
                        }
                    case 4:
                        {
                            Journal.LockJournal();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                Console.ResetColor();

            }
            while (choice != 5);
        }
    }
}
