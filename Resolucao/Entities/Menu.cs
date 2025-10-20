using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucao.Entities
{
    public static class Menu
    {
        public static int Display(string title, List<string> options)
        {
            Console.WriteLine(title);
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {options[i]}");
            }
            Console.Write("Escolha uma opção válida: ");
            return int.Parse(Console.ReadLine() ?? "0");
        }
    }
}
