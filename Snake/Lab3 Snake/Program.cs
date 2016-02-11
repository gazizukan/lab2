using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameG1W4
{
    class Program
    {
        public static Models.Game game;
        static void Main(string[] args)
        {
            Console.SetWindowSize(48, 48);
            game = new Models.Game();
            Console.ReadKey();

        }
    }
}