using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatrancSorusu
{
    class Satranc
    {
        static void Main(string[] args)
        {
            List<string> a = GetMoves('d', '5');
            foreach(string yazi in a)
            {
                Console.WriteLine(yazi);
            }
            Console.ReadLine();
        }

        static List<string> GetMoves(char harf, char sayi)
        {
            List<string> liste = new List<string>();
            int h = harf - 'a' + 1;
            int s = int.Parse(sayi.ToString());

            //
            //                 *  *  *
            //                       *    
            //
            if (h - 2 >= 1 && s - 1 >= 1) liste.Add((char)(harf - 2) + ("") + (s - 1));// Sol Alt
            if (h - 2 >= 1 && s + 1 <= 8) liste.Add((char)(harf - 2) + ("") + (s + 1));// Sol üst
            if (h + 2 <= 8 && s - 1 >= 1) liste.Add((char)(harf + 2) + ("") + (s - 1));// sag alt
            if (h + 2 <= 8 && s + 1 <= 8) liste.Add((char)(harf + 2) + ("") + (s + 1));// sag üst

            //
            //                    *  *
            //                       *
            //                       *
            if (h - 1 >= 1 && s - 2 >= 1) liste.Add((char)(harf - 1) + ("") + (s - 2));// sol alt
            if (h - 1 >= 1 && s + 2 <= 8) liste.Add((char)(harf - 1) + ("") + (s + 2));// sol üst
            if (h + 1 <= 8 && s - 2 >= 1) liste.Add((char)(harf + 1) + ("") + (s - 2));// sag alt
            if (h + 1 <= 8 && s + 2 <= 8) liste.Add((char)(harf + 1) + ("") + (s + 2));// sag üst

            return liste;
        }
    }
}
