namespace Task_1
{
    internal class Program
    {
        /// <summary>
        /// Вывод списка на консоль
        /// </summary>
        /// <param name="list"></param>
        static void ListPrint(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i} = {list[i]}");
            }
        }

        /// <summary>
        /// Заполнение списка случайными значениями
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        static List<int> ListFill(List<int> list) 
        {
            Random random = new Random();
            
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = random.Next(0, 100);
            }
            return list;
        }

        /// <summary>
        /// Фильтрация списка
        /// </summary>
        /// <param name="list"></param>
        /// <param name="filtr"></param>
        /// <returns></returns>
        static List<int> Filtr(List<int> list) 
        {
            for (int i = 0; i < list.Count; i++)
            {
                //Если условие будет истиной, то удаляем элемент по индексу i
                if (list[i] > 25 && list[i] < 50)
                {
                    list.RemoveAt(i);
                    i = 0;
                }                
            }
            return list;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>(); //Лист целых чисел
            list = new int[100].ToList();

            //Заполнение листа 100 случайными значениями
            list = ListFill(list);

            //Вывод на консоль
            ListPrint(list);

            //Фильтрация значений больше 25 и меньше 50
            list = Filtr(list);

            Console.WriteLine("Вывод отфильтрованного списка");         
            ListPrint(list);
        }
    }
}