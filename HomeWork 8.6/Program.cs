namespace HomeWork_8._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> list = new List<decimal>();

            string name = null;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Введите номер: ");
                    string numerIN = Console.ReadLine();

                    if (numerIN != "")
                    {
                        decimal numer = decimal.Parse(numerIN);
                        list.Add(numer);
                    }
                    else
                    {
                        Console.WriteLine("Номер заполнен");
                        list.Add(0); //Будет выступать в качестве конца номерей пользователя, полсе 0 будет добавлены номера других пользователей
                        break;
                    }                    
                }

                //List<decimal> numers = new List<decimal>(); 
                                
                List<string>names = new List<string>(); //Список который хранить имена
                Console.WriteLine("Введите имя: ");
                name= Console.ReadLine();
                names.Add(name);
                int nameCount = 0; //Для счёта имен

                Console.WriteLine(list.IndexOf(0));                
                decimal[] numers = new decimal[list.IndexOf(0)];   //Выступает в качестве хранилище номеров 1 пользователя                                                            
                list.CopyTo(0, numers, 0, list.IndexOf(0)-1); //Будем копировать данные туда из спика List до элемента 0

                for (int i = 0; i < numers.Length; i++)
                {
                    Console.WriteLine("Номер: {0}, Владелец: {1}", list[i], names[nameCount]);
                }
                
                nameCount++;
            }
            
        }
    }
}