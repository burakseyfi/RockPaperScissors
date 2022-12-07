using TasKagıtMakas.Services;

namespace TasKagıtMakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TasKagitMakasService servis = new TasKagitMakasService();
            Console.Write("Kağıt (0), Taş (1), Makas(2), Çıkış (3): ");
            int giris = Convert.ToInt32(Console.ReadLine());
            while(giris != 3)
            {
                Console.WriteLine(servis.Oyna(giris));
                Console.Write("Kağıt (0), Taş (1), Makas(2), Çıkış (3): ");
                giris = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}