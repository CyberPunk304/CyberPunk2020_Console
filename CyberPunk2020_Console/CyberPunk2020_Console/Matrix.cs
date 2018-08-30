using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberPunk2020_Console
{
    class Matrix
    {
        private static bool thistime;
        private static readonly Random r = new Random();

        private static char R
        {
            get
            {
                var t = r.Next(10);
                if (t <= 2)
                    return (char)('0' + r.Next(10));
                if (t <= 4)
                    return (char)('a' + r.Next(27));
                if (t <= 6)
                    return (char)('A' + r.Next(27));
                return (char)(r.Next(32, 255));
            }
        }

        public static void MatrixStart()
        {
            Console.Title = "CyberPunk2020_Console";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WindowLeft = Console.WindowTop = 0;
            Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();

            Console.CursorVisible = false;
            int width, height;
            int[] y;
            int[] l;
            Initialize(out width, out height, out y, out l);
            int ms;
            while (true)
            {
                
                var t1 = DateTime.Now;
                MatrixStep(width, height, y, l);
                ms = 10 - (int)(DateTime.Now - t1).TotalMilliseconds;
                if (ms > 0)
                    Thread.Sleep(ms);
                if (Console.KeyAvailable)
                    if (Console.ReadKey().Key != ConsoleKey.LeftWindows)
                        break;
                       
            }
            
        }

        private static void MatrixStep(int width, int height, int[] y, int[] l)
        {
            int x;
            thistime = !thistime;
            for (x = 0; x < width; ++x)
            {
                
                if (x % 11 == 10)
                {
                    if (!thistime)
                        continue;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(x, inBoxY(y[x] - 2 - (l[x] / 40 * 2), height));
                    Console.Write(R);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.SetCursorPosition(x, y[x]);
                Console.Write(R);
                y[x] = inBoxY(y[x] + 1, height);
                Console.SetCursorPosition(x, inBoxY(y[x] - l[x], height));
                Console.Write(' ');
                MessageOnMatrix("NACIŚNIJ DOWOLNY KLAWISZ ABY PRZEJŚĆ DO PROGRAMU...", Console.BufferWidth/2, Console.BufferHeight/2);
               
            }
        }

        private static void MessageOnMatrix(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(message);
        }


        private static void Initialize(out int width, out int height, out int[] y, out int[] l)
        {
            int h1;
            var h2 = (h1 = (height = Console.WindowHeight) / 2) / 2;
            width = Console.WindowWidth - 1;
            y = new int[width];
            l = new int[width];
            int x;
            Console.Clear();
            for (x = 0; x < width; ++x)
            {
                y[x] = r.Next(height);
                l[x] = r.Next(h2 * ((x % 11 != 10) ? 2 : 1), h1 * ((x % 11 != 10) ? 2 : 1));
            }
        }

        public static int inBoxY(int n, int height)
        {
            n = n % height;
            if (n < 0)
                return n + height;
            return n;
        }
    }

}

