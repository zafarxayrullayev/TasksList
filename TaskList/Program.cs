namespace TaskList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>(); // list yaratildi

            Console.WriteLine("TaskList ga xush kelibsiz!!!");

            while (true)
            {
                Console.WriteLine("Xush kelibsiz!");

                Console.WriteLine("1. Vazifa qo'shish");
                Console.WriteLine("2. Vazifani tahrirlash");
                Console.WriteLine("3. Vazifani o'chirish");
                Console.WriteLine("4. Vazifalarni ko'rsatish");
                Console.WriteLine("5. Chiqish");

                Console.WriteLine("Raqamlardan birini tanlang!");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        Console.WriteLine("Yangi vazifani kiriting!");
                        string newTask = Console.ReadLine();
                        tasks.Add(newTask);
                        Console.WriteLine("Yangi vazifa qo'shildi!");
                        break;
                    case 2:
                        Console.WriteLine("Tahrirlanishi kerak bo'lgan vazifa indeksini kiriting!");
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine("Vazifani kiriting");
                        string editedTask = Console.ReadLine();
                        tasks[index - 1] = editedTask;
                        Console.WriteLine("Vazifa tahrirlandi!");
                        break;
                    case 3:
                        Console.WriteLine("O'chirmoqchi bo'lgan vazifa indeksini kiriting!");
                        int deleteIndex = int.Parse(Console.ReadLine());
                        tasks.RemoveAt(deleteIndex - 1);
                        Console.WriteLine("Vazifa o'chirildi!");
                        break;
                    case 4:
                        tasks.ForEach(a => Console.WriteLine(a));
                        break;
                    case 5:
                        Console.WriteLine("Good bye!");
                        return;
                    default:
                        break;
                }

            }

        }
    }
}