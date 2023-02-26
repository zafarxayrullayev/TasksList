using Classes;
using System.Reflection;

namespace TaskList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods(); 

            Console.WriteLine("TaskList ga xush kelibsiz!!!");

            while (true)
            {
                Console.WriteLine("Xush kelibsiz!");

                methods.ViewMenu();

                Console.WriteLine("Raqamlardan birini tanlang!");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        methods.AddTask();
                        break;
                    case 2:
                        methods.EditTask();
                        break;
                    case 3:
                        methods.DeleteTask();
                        break;
                    case 4:
                        methods.ShowTasks();
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