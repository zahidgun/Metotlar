using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar1 = new int[] {10, 20, 30, };
            int[] sayilar2 = new int[] { 100, 200, 300, };
            sayilar1 = sayilar2;
            sayilar2[0] = 999; //?
            //sayılar2 nin 0. elemanı kaçtır ?
            

        }
    }
}
