using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalModul5_103022330070
{
    internal class PemrosesData
    {
        public void DapatkanNilaiTerbesar<T>(T nilai1, T nilai2, T nilai3 ) where T: IComparable
        {
            dynamic max = nilai1;
            if (nilai2.CompareTo(max) > 0) max = nilai2;
            if (nilai3.CompareTo(max) > 0) max = nilai3;
            Console.WriteLine($"nilai tertinggi: {max}");


        }   
    }
}
