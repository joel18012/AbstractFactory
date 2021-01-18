using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    public class Menu
    {
        public static string  MultipleChoice(bool canCancel, List<string> options,string Titulo)
        {
            const int startX = 15;
            const int startY = 8;
            const int optionsPerLine = 1;
            const int spacingPerLine = 14;

            int currentSelection = 0;

            ConsoleKey key;
            Console.CursorVisible = false;

            do
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(startX, startY - 2);
                Console.WriteLine(Titulo);
                Console.ForegroundColor = ConsoleColor.White;


                for (int i = 0; i < options.Count; i++)
                {
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(options[i]);

                    Console.ResetColor();
                }
                Console.SetCursorPosition(startX,Console.CursorTop+2);

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                currentSelection++;
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection >= optionsPerLine)
                                currentSelection -= optionsPerLine;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection + optionsPerLine < options.Count)
                                currentSelection += optionsPerLine;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (canCancel)
                                return "Salir";
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;

            return options[currentSelection];
        }
    }
}
