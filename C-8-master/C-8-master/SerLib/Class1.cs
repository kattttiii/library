using Newtonsoft.Json;

namespace SerLib
{
    public class Class1
    {
        // Метод для сериализации объекта в JSON и сохранения его в файл.
        public static void MySerialize<T>(T humans, string filename)
        {
            // Получаем путь к рабочему столу пользователя.
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Сериализуем объект humans в строку JSON.
            string json = JsonConvert.SerializeObject(humans);

            // Записываем строку JSON в файл на рабочем столе.
            File.WriteAllText(desktop + "\\" + filename, json);
        }

        // Метод для десериализации JSON из файла в объект.
        public static T MyDeserialize<T>(string filename)
        {
            // Получаем путь к рабочему столу пользователя.
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Читаем строку JSON из файла на рабочем столе.
            string json = File.ReadAllText(desktop + "\\" + filename);

            // Десериализуем строку JSON в объект типа T.
            T humans = JsonConvert.DeserializeObject<T>(json);

            // Возвращаем десериализованный объект.
            return humans;
        }
    }
}