using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ProVodnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажмите F1 для удаления доты 2");

        while (true) { 
            
            Diski();
            }
        }

        static void Diski()
        {
            DriveInfo[] AllDrives = DriveInfo.GetDrives();

            Console.Clear();
            foreach (var drive in AllDrives)
            {
                Console.WriteLine("  " + drive.Name + "Всего места: " + drive.TotalSize / 1024 / 1024 / 1024 + "Гб   " + "Свободное место: " + drive.AvailableFreeSpace / 1024 / 1024 / 1024 + " Гб");
            }
            
               int pos = Menu.Show(1,AllDrives.Length);
            if(pos == 1)
            {
                return;
            }
            else
            {
                SJ.Papka(AllDrives[pos].RootDirectory.FullName);
            }

        }

        
        }
    }

