using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProVodnik
{
    internal class SJ
    {
       public static void Papka(string papulya)
            {
                while (true)
                {
                    string[] path = Directory.GetDirectories(papulya);
                    string[] filepath = Directory.GetFiles(papulya);
                    List<string> allfiles = new List<string>();

                    Console.Clear();

                    foreach (string file in filepath)
                    {
                        allfiles.Add(file);
                    }
                    foreach (string file in path)
                    {
                        allfiles.Add(file);
                    }
                    foreach (string file in allfiles)
                    {

                        var type = Path.GetExtension(file);
                        var datacr = Directory.GetCreationTime(file);
                        Console.Write("  " + file);

                        Console.SetCursorPosition(50, Console.CursorTop);
                        Console.Write(datacr);

                        Console.SetCursorPosition(70, Console.CursorTop);
                        Console.WriteLine(type);
                    }
                    int pos = Menu.Show(0, path.Length + filepath.Length);
                    if (pos == -1)
                    {
                        return;
                    }
                    else
                    {
                        try
                        {
                            Papka(allfiles[pos]);
                        }
                        catch (IOException)
                        {
                            Process.Start(new ProcessStartInfo { FileName = allfiles[pos], UseShellExecute = true });
                        }
                    }
                }
            }


        }
    }

