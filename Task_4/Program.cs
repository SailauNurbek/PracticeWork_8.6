using System.Xml.Linq;
using System.Xml.Serialization;

namespace Task_4
{
    internal class Program
    {

        /// <summary>
        /// Метод сериализации Worker
        /// </summary>
        /// <param name="СoncreteWorker">Экземпляр для сериализации</param>
        /// <param name="Path">Путь к файлу</param>
        static void SerializePerson(Person СoncreteWorker, string Path)
        {
            // Создаем сериализатор на основе указанного типа 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            // Создаем поток для сохранения данных
            Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);

            // Запускаем процесс сериализации
            xmlSerializer.Serialize(fStream, СoncreteWorker);

            // Закрываем поток
            fStream.Close();
        }

        static void Main(string[] args)
        {
            Person user = new Person();
            string path = @"C:\\Users\\nurbe\\Desktop\\Person.xml";

            Console.WriteLine("ФИО: ");
            user.Name = Console.ReadLine();
            Console.WriteLine("Street: ");
            user.Street = Console.ReadLine();
            Console.WriteLine("Home: ");
            user.HouseNumber = Console.ReadLine();
            Console.WriteLine("Appartment: ");
            user.FlatNumber = Console.ReadLine();
            Console.WriteLine("Numer: ");
            user.MobilePhone = Console.ReadLine();
            Console.WriteLine("Flat Phone: ");
            user.FlatPhone = Console.ReadLine();            

            #region Xml Create
            XDocument xdoc = new XDocument(new XElement("person", new XAttribute("name", user.Name),
                    new XElement("Adress",
                        new XElement("Street", user.Street),
                        new XElement("HouseNumber", user.HouseNumber),
                        new XElement("FlatNumber", user.FlatNumber)),
                    new XElement("Phones",
                        new XElement("MobilePhone", user.MobilePhone),
                        new XElement("FlatPhone", user.FlatPhone))));
            xdoc.Save(path);
            Console.WriteLine("Complete");
            #endregion

        }
    }
}