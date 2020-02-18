using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNKO_List
{
    class Program
    {
        static List<int> KozosOsztoList;
        static List<int> Szam1Osztok;
        static List<int> Szam2Osztok;
        static void Main(string[] args)
        {
            LNKO();
            Console.ReadKey();
        }

        private static void LNKO()
        {
            Console.Write("Kérem adjon meg egy számot: ");
            int Szam1 = int.Parse(Console.ReadLine());
            Console.Write("Kérem adjom meg még egy számot: ");
            int Szam2 = int.Parse(Console.ReadLine());
            int CiklusVege;
            if(Szam1>Szam2)
            {
                CiklusVege = Szam2;
            }
            else
            {
                CiklusVege = Szam1;
            }
            //Console.WriteLine("A cikllus vége: {0}", CiklusVege);
            Szam1Osztok = new List<int>();
            for (int i = 1; i <= CiklusVege; i++)
            {
                if(Szam1%i==0)
                {
                    Szam1Osztok.Add(i);
                }
            }
            Szam2Osztok = new List<int>();
            for (int k = 1; k <= CiklusVege; k++)
            {
                if (Szam2 % k == 0)
                {
                    Szam2Osztok.Add(k);
                }
            }
            KozosOsztoList = new List<int>();
            foreach (var s in Szam1Osztok)
            {
                foreach (var s2 in Szam2Osztok)
                {
                    if(s==s2)
                    {
                        KozosOsztoList.Add(s);
                    }
                }
            }
            int MaxOszto = int.MinValue; ;
            foreach (var k in KozosOsztoList)
            {
               // Console.WriteLine("A közös osztók: {0}", k);
               if(MaxOszto<k)
                {
                    MaxOszto = k;
                }
               
            }
            Console.WriteLine("A két szám legnagyobb közös osztója : {0}", MaxOszto);
            if(MaxOszto==1)
            {
                Console.WriteLine("A két szám RELATÍV PRÍM egymáshoz");
            }
        }
    }
}
