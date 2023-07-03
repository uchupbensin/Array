using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //membuat array sekaligus inisialisasi nilai
            string[] arrNama = { "Erick", "Wely", "Sony" };
            int[] arrNim = { 1234, 1235, 1236 };
            int[] arrNilai = { 75, 80, 90 };

            Console.WriteLine("No\tNama\tNIM\tNilai");
            Console.WriteLine("===============================");

            //menampilkan semua elemen array
            for (int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine((i + 1) + ".\t" + arrNama[i] + "\t" + arrNim[i] + "\t" + arrNilai[i]);
            }
            Console.ReadKey();
        }
    }
}