using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace OOPConsoleGame
{
    public static class Util
    {
        // 다음으로 진행 전 대기 (계속하려면 아무 키나 누르세요.)
        public static void Wait()
        {
            Console.WriteLine();
            Console.WriteLine("계속 진행하려면 아무 키나 누르세요.");
            Console.ReadKey();
        }
        public static void PrintS(string line, int delay = 10)
        {
            bool interrupt = false;
            foreach (char c in line)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKey input = Console.ReadKey(true).Key;
                    if (input == ConsoleKey.Spacebar)
                    {
                        interrupt = true;
                    }
                }
                
                if (interrupt == false)
                {
                    Thread.Sleep(delay);
                }
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
