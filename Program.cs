using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L18_bracketExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentDepth = 0;
            int maxDepth = 0;
            char openBracket = '(';
            char closedBracket = ')';
            string userInput;

            Console.Write("Введите скобочное выражение: ");
            userInput = Console.ReadLine();

            foreach (char symbol in userInput)
            {
                if (symbol == openBracket)
                {
                    currentDepth++;

                    if (currentDepth > maxDepth)
                        maxDepth = currentDepth;
                }
                else if (symbol == closedBracket)
                {
                    currentDepth--;

                    if (currentDepth < 0)
                        break;
                }
            }

            if (currentDepth == 0)
                Console.WriteLine($"\nДанное скобочное выражение корректно.\nМаксимальная глубина вложенности составляет {maxDepth}\n");
            else
                Console.WriteLine($"\nДанное скобочное выражение некорректно.");
        }
    }
}
