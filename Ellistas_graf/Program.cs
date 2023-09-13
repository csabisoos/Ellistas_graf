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
            public Ellistas_graf()//konstruktor
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
                string result = "graph G {\n";
                foreach (List<int> el in ellista)
                {
                    result += "\t" + el[0] + " -- " + el[1] + ";\n";
                }
                return result + "}";
            }
            public bool Van_el(int a, int b)
            {
                for (int i = 0; i < ellista.Count; i++)
                {
                    if (ellista[i][0] == a && ellista[i][1] == b)
                        return true;

                    else if(ellista[i][0] == b && ellista[i][1] == a)
                        return true;
                }
                return false;
            }
            public int Fokszam(int a)
            {
                if (!Vane(a))
                {
                    return -1;
                }
                int db = 0;
                for (int i = 0; i < ellista.Count; i++)
                {
                    if (ellista[i][0] == a)
                        db++;
                    if (ellista[i][1] == a)
                        db++;
                }
                return db;
            }
            public bool Vane(int a)
            {
                return a < csucsszam;
            }
            public bool Izolalt(int a)
            {
                return Fokszam(a) == 0;
            }
        }
        static void Main(string[] args)
        {
            Ellistas_graf graf = new Ellistas_graf();
            graf.Mesteres_feltoltes();
            Console.WriteLine(graf.Graphviz_output());
            Console.ReadKey();
        }
    }
}
