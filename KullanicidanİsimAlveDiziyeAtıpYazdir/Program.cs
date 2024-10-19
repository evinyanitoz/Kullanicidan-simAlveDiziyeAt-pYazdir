namespace KullanicidanİsimAlveDiziyeAtıpYazdir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            string isim;
            List<string> isimler = new List<string>();
            do
            {
                sayac++;
                Console.WriteLine($"{sayac}.İsimi Giriniz :");

                isim = Console.ReadLine();
                isimler.Add(isim);

            }
            while (isim != "");

            Console.WriteLine("OLUŞTURDUĞUN DİZİ ;");

            foreach (var array in isimler)
            {

                Console.WriteLine($"{array}");

            }
        }
    }
}
