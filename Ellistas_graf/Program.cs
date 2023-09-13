using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ellistas_graf
{
    internal class Program
    {
        class Ellistas_graf
        {
            private List<List<int>> ellista;
            public int csucsszam;
            public int elszam;
            public Ellistas_graf()
            {
                ellista = new List<List<int>>();
                csucsszam = 0;
                elszam = 0;
            }
            public void Mesteres_feltoltes()
            {
                string sor = Console.ReadLine();
                string[] sortomb = sor.Split(' ');
                csucsszam = int.Parse(sortomb[0])+1;
                elszam = int.Parse(sortomb[1]);
                for (int i = 0; i < elszam; i++)
                {
                    sor = Console.ReadLine();
                    sortomb = sor.Split(' ');
                    ellista.Add(new List<int> { int.Parse(sortomb[0]), int.Parse(sortomb[1]) });
                }
            }
            public string Graphviz_output()
            {

            }
        }
        static void Main(string[] args)
        {
            Ellistas_graf graf = new Ellistas_graf();
        }
    }
}
