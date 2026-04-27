using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Harry Potter", 102);
            movie1.Add(5);
            movie1.Add(6);
            movie1.Add(7);

            var temp = new
            {
                MovieType = movie1.GetType().Name,
                movie1.Name,
                movie1.Duration,
                movie1.Review
            };
            string json = JsonConvert.SerializeObject(temp);
            File.WriteAllText(filePath, json);
            var newJson = JsonConvert.DeserializeObject<dynamic>(content);

            Movie movie2 = new Movie(newJson.Name, newJson.Duration);
            foreach (int n in newJson.Review)
            {

            }
            //получение путей к папкие

            //абсолютный путь

            //относительный путь - короче, общая ссылка
            // "dataset/data txt

            //string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string filePath = Path.Combine(folderPath, "Test","example.txt");
            ////Console.WriteLine(folderPath);
            ////Console.WriteLine(filePath);
            //string folderPath1 = Path.Combine(folderPath, "Test");
            //string filePath1 = Path.Combine(folderPath1, "example.txt");

            //string folderPath1Check = Path.GetFullPath(filePath1);
            //string foldNameCheck = Path.GetFileName(filePath1);
            
            //if (Directory.Exists(folderPath1))
            //{
            //    Console.WriteLine("Есть папка");
            //}
            //else
            //{
            //    Console.WriteLine("нет папки");
            //    Directory.CreateDirectory(folderPath1);
            //    Console.WriteLine("Создана папка");
            //}

            ////if (File.Exists(filePath)) //всегда проверять существование перед созданием
            ////{
            ////    Console.WriteLine("существует");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("не существует");
            ////    File.Create(filePath).Close();
            ////    Console.WriteLine();
            ////}
            //File.WriteAllText(filePath1, "lalala");
            //File.WriteAllLines(filePath1, new string[] { "i", "am", "vika" });
            ////записывает файл в строку
            ////если файла не было - создает и записывает
            ////если файл был - перезаписывает содержимое
            ////чтобы каждый раз не перезаписывать а сохранить старое содержимое использовать Append
            //File.AppendAllText(filePath, "Wohoo");
            //File.AppendAllLines(filePath, new string[] { "Hello", "guys" });

            //string content = File.ReadAllText(filePath);
            //string[] lines = File.ReadAllLines(filePath);
            //Console.WriteLine(content);
            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}
            //File.Delete(filePath1);
        }
        
    }
    private bool CompareMovies(Movie m1, Movie m2)
        {
            if (m1.Name != m2.Name) return false;
            if (m1.Duration != m2.Duration) return false;
        }
    public class Movie
    {
        private string _name;
        private int _duration;
        private int[] _review;

        public string Name => _name;

        public Movie(string name, int duration)
        {
            _name = name;
            _duration = duration;
            _review = new int[0];
        }

        public void Add(int num)
        {
            Array.Resize(ref _review, num);
            _review[_review.Length - 1] = num;
        }
    }
}
