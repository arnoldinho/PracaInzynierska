using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross
{
    public static class Policz
    {
        public static int[] wezel ={ 0, 1, 2, 3, 4, 5, 6,};
        public static float[] X = new float[7];
        public static float[] Y = new float[7];
        public static int[] dzialka = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        public static int[] petla = { 0, 1, 2, 3, 4, 5 };
        public static int[,] wezlyDzialki = new int[11, 2];
        public static int[,] kierunekPrzeplywu = new int[6, 11];
        public static int[,] dzialkawPetli = new int[6, 11];
        public static float[] stratyNaJednostke = new float[11];
        public static float[] przeplyw = new float[11];
        public static float[] przeplywPoczatkowy = new float[11];
        public static float[] korekcjaPrzeplywu = new float[6];
        public static int liczbaWezlow, liczbaPetli, liczbaDzialek;
        public static int ilosciteracji;

        public static string Oblicz()
        {
            int exp = 2;
            for (int i = 0; i < ilosciteracji ; i++)
            {
                for (int lp = 1; lp < liczbaPetli + 1; lp++)
                {
                    float nrq = 0.00f;
                    float rq = 0.00f;
                    for (int p = 1; p < liczbaDzialek + 1; p++)
                    {
                        if (dzialkawPetli[lp, dzialka[p]] == lp)
                        {
                            nrq = nrq + (float)(exp * stratyNaJednostke[dzialka[p]] * Math.Pow(przeplyw[dzialka[p]], exp - 1));
                            if (kierunekPrzeplywu[lp, dzialka[p]] == 1)
                            {
                                rq = rq + (float)(stratyNaJednostke[dzialka[p]] * Math.Pow(przeplyw[dzialka[p]], exp));
                            }
                            else
                            {
                                rq = rq - (float)(stratyNaJednostke[dzialka[p]] * Math.Pow(przeplyw[dzialka[p]], exp));
                            }
                        }
                    }
                    korekcjaPrzeplywu[lp] = rq / nrq;
                    for (int p = 1; p < liczbaDzialek + 1; p++)
                    {
                        if (dzialkawPetli[lp, dzialka[p]] == lp)
                        {
                            if (kierunekPrzeplywu[lp, dzialka[p]] == 1)
                            {
                                przeplyw[dzialka[p]] = przeplyw[dzialka[p]] - korekcjaPrzeplywu[lp];
                            }
                            else
                            {
                                przeplyw[dzialka[p]] = przeplyw[dzialka[p]] + korekcjaPrzeplywu[lp];
                            }
                        }
                    }
                }
            }
            for (int lp = 1; lp < liczbaPetli + 1; lp++)
            {
                korekcjaPrzeplywu[lp] = 0.00f;
            }
            string wynik = "";
            for (int p = 1; p < liczbaDzialek + 1; p++)
            {
                wynik = wynik + "dzialka[" + p + "] wezly " + wezlyDzialki[dzialka[p], 0] + "," + wezlyDzialki[dzialka[p], 1]
                        + " Przepływ początkowy = " + przeplywPoczatkowy[dzialka[p]] + " [m3/s] Koncowy przeplyw = " + przeplyw[dzialka[p]] + " [m3/s]\n";
            }
            return wynik;
        }
    }
}