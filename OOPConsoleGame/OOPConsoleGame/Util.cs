using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
