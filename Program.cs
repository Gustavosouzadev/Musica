using System;

namespace Musica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.Clear();

            string titulo = "Os Barões da Pisadinha - Esquema Preferido";
            string L1 = "Tá vendo aí, ela já tá falando";
            string L2 = "Que tá com saudade tá me procurando";
            string L3 = "Daqui a pouco ela tá aí coçando";
            string L4 = "Sabe que eu sou louco e sem coração";
            string L5 = "Quando ela liga eu dou atenção";
            string L6 = "Eu mando logo a localização";
            string L7 = "Hoje vai ter festa no colchão";
            string L8 = "Ela roda a cidade inteira pra ficar comigo";
            string L9 = "Porque eu sou seu esquema preferido";
            string L10 = "Eu sou seu esquema preferido";
            string L11 = "Ela dispensa a balada, as amigas, pra ficar comigo";
            string L12 = "Eu sou seu esquema preferido";
            string L13 = "Porque eu sou seu esquema preferido";



            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("         ------------");
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Titulo");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("------------        ");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(titulo);
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("         ------------");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Letra");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("------------         ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(L1); 
            Console.WriteLine(L2);       
            Console.WriteLine(L3);
            Console.WriteLine(L4);
            Console.WriteLine(L5);
            Console.WriteLine(L6);

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(L7);
            Console.WriteLine(L8);
            Console.WriteLine(L9);
            Console.WriteLine(L10);
            Console.WriteLine(L11);
            Console.WriteLine(L12);
            Console.WriteLine(L13);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("     Link da musica"    );

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("https://www.youtube.com//watch?v=TCLGN6m6AMI");
            Console.ResetColor();
            
            Console.Beep();
        }
    }
}
