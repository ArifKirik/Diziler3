namespace Diziler_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            foreach (int i in sayilar1)
            {
                if (i > 5 && i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
            int[] sayilar2 = new int[7];
            for (int i = 0; i < sayilar2.Length; i++)
            {
                Console.WriteLine("Sayıyı Girin:");
                sayilar2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Reverse(sayilar2);
            foreach (int i in sayilar2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            int[] sayilar3 = new int[6];
            for (int i = 0; i < sayilar3.Length; i++)
            {
                Console.WriteLine("sayıyı Girin:");
                sayilar3[i] = Convert.ToInt32(Console.ReadLine());
            }
                    Array.Sort(sayilar3);
            {
                Console.WriteLine("Dizinin En Küçük Elemanı:" + sayilar3[0]);
                Console.WriteLine("Dizinin En Büyük Elemanı:" + sayilar3[5]);
            }
                Console.ReadLine();
            
        }
    }
}