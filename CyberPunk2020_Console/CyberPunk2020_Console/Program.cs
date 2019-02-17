using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CyberPunk2020_Console
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);
        public ResourceManager rm = new ResourceManager("items", Assembly.GetExecutingAssembly());


        static void Main(string[] args)
        {
            #region Console window configuration
            Maximize();
            #endregion
            //test commit
            Start();
        }


        public static void Start()
        {
            Matrix.MatrixStart();
            Menu();
        }

        private static void Maximize()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3);
        }

        static void CreateMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            ImagesClass.LogoWritter();
            ImagesClass.WomenSoloHead_Menu();
        }

        static void Menu()
        {
            string answer;
            bool exit = false;
            while(!exit)
            {
                CreateMenu();
                answer = Console.ReadLine();
                Console.Clear();
                try
                {
                    switch (Convert.ToInt32(answer))
                    {
                        case 1:
                            InstructionClass.FightingInCyberpunk();
                            Console.Clear();
                            break;
                        case 2:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Wybrana opcja nie istnieje.");
                            Console.WriteLine("Wciśnij dowolny klawisz...");
                            Console.ReadLine();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Wybrana opcja nie istnieje.");
                    Console.WriteLine("Wciśnij dowolny klawisz...");
                    Console.ReadLine();
                }
            };

        }

    }
}
