using System;

namespace OOPPolymorphisme
{
    class program
    {
        static void Main(string[] args)
        {
            persegi totalLuas = new persegi(4);
            Console.WriteLine(" Luas Persegi Adalah : " + totalLuas.LuasBangunRuang());
        }
    }

    public abstract class BangunRuang
    {
        public double luas;

        public abstract double LuasBangunRuang();
    }

    public class persegi : BangunRuang
    {
        double sisi;

        public persegi(double s)
        {
            sisi = s;
        }

        public override double LuasBangunRuang()
        {
            luas = 4 * sisi;
            // return di gunakan untuk mengembalikan nilai
            return luas;
        }
    }
}