namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            Console.WriteLine("Введите число: ");
            int numer = int.Parse(Console.ReadLine());
            set.Add(numer);
            Console.WriteLine("Число сохранено");

            int i = 0;
            while (i<5)
            {
                Console.WriteLine("Введите число: ");
                numer = int.Parse(Console.ReadLine());
                if (set.Contains(numer))
                {
                    Console.WriteLine("Такое число существует");
                }
                else
                {
                    set.Add(numer);
                    Console.WriteLine("Число сохранено");
                }
                i++;
            }          
        }
    }
}