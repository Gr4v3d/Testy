using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_2A_Testy
{
    public class DLzPliku
    {
        static public List<object[]> Pobieracz(string path)
        {
            List<object[]> lista = new List<object[]>();
            string[] temp = File.ReadAllLines(path);
            foreach (string line in temp)
            {
                string[] temp2 = line.Split(',');
                lista.Add(new object[] { int.Parse(temp2[0]), int.Parse(temp2[1]), int.Parse(temp2[2]) });
            }
            return lista;
        }
    }
}
