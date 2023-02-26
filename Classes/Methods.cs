using System.Threading.Tasks;

namespace Classes
{
    public class Methods
    {
        public List<string> tasks = new List<string>(); // list yaratildi

        public void ViewMenu()
        {
            Console.WriteLine("1. Vazifa qo'shish");
            Console.WriteLine("2. Vazifani tahrirlash");
            Console.WriteLine("3. Vazifani o'chirish");
            Console.WriteLine("4. Vazifalarni ko'rsatish");
            Console.WriteLine("5. Chiqish");
        }

        public void AddTask()
        {
            Console.WriteLine("Yangi vazifani kiriting!");
            string newTask = Console.ReadLine();
            tasks.Add(newTask);
            Console.WriteLine("Yangi vazifa qo'shildi!");
        }

        public void EditTask()
        {
            Console.WriteLine("Tahrirlanishi kerak bo'lgan vazifa indeksini kiriting!");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Vazifani kiriting");
            string editedTask = Console.ReadLine();
            tasks[index - 1] = editedTask;
            Console.WriteLine("Vazifa tahrirlandi!");
        }

        public void DeleteTask()
        {
            Console.WriteLine("O'chirmoqchi bo'lgan vazifa indeksini kiriting!");
            int deleteIndex = int.Parse(Console.ReadLine());
            tasks.RemoveAt(deleteIndex - 1);
            Console.WriteLine("Vazifa o'chirildi!");
        }

        public void ShowTasks()
        {
            tasks.ForEach(a => Console.WriteLine(a));
        }
    }
}