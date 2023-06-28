using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesstion21.Tools
{
    public class Menu
    {
        public List<string> Items { get; set; } = new List<string>();

        public int Show()
        {
            Items.ForEach(i => Console.WriteLine(i));
            Console.Write("Your choice: ");
            return int.Parse(Console.ReadLine() ?? "0");
        }
    }
}
