using System;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opt;
            do
            {
                Console.WriteLine("1. Tapshiriq yarat");
                Console.WriteLine("2. Butun tapshiriqlara bax");
                Console.WriteLine("3. Vaxti kechmish tapshiriqlara bax");
                Console.WriteLine("4. Sechilmish statuslu tapshiriqlara bax");
                Console.WriteLine("5. Tarix intervalina gore axtar");
                Console.WriteLine("6. Tapshirigin statusunu deyishmek");
                Console.WriteLine("7. Tapshirigi edirlemek");
                Console.WriteLine("8. Tapshirigi silmek");
                Console.WriteLine("9. Tapshiriglarda axtarish");
                Console.WriteLine("0. Exit");
                opt = Console.ReadLine();
                TodoItem newItem = new TodoItem();
                TodoManager newManager = new TodoManager();


                
                

                switch (opt)
                {
                    case "1":
                        Console.WriteLine("Tapshirigin title-ni daxil et");
                        string titleStr = Console.ReadLine();
                        Console.WriteLine("Tapshirigin description-unu daxil et");
                        string descriptionStr = Console.ReadLine();
                        Console.WriteLine("Tapshirigin deadline-ni daxil et Formati ay/gun/il/saat/deqiqe olaraq daxil edin");
                        DateTime deadLine = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Tapshirigin status-unu daxil et");
                        string statusStr = Console.ReadLine();

                        newItem.Title = titleStr;
                        newItem.Description = descriptionStr;
                        newItem.Deadline = deadLine;
                       
                        break;
                    case "2":
                        TodoItem[] items = newManager.GetAllTodoItems();
                        for (int i = 0; i < items.Length; i++)
                        {
                            Console.WriteLine(items[i].Title, items[i].Description, items[i].Deadline, items[i].Status);
                        }
                        break;


                    case "3":
                        TodoItem[] items1 = newManager.GetAllDelayedTasks();
                        for (int i = 0; i < items1.Length; i++)
                        {
                            Console.WriteLine(items1[i].Title, items1[i].Description, items1[i].Deadline, items1[i].Status);
                        }
                        break;

                    case "4":
                        Console.WriteLine("Statusu daxil et");
                        string status1 = Console.ReadLine();
                        TodoItem[] items2 = newManager.GetAllTodoItemsByStatus(status1);
                        for (int i = 0; i < items2.Length; i++)
                        {
                            Console.WriteLine(items2[i].Title, items2[i].Description, items2[i].Deadline, items2[i].Status);
                        }
                        break;

                    case "5":
                        Console.WriteLine("Bashlangic tarixi daxil et");
                        string startDateStr = Console.ReadLine();
                        Console.WriteLine("Bitme tarixini daxil et");
                        string endDateStr = Console.ReadLine();
                        DateTime startDate = Convert.ToDateTime(startDateStr);
                        DateTime endDate = Convert.ToDateTime(endDateStr);
                        Status st = new Status();

                        TodoItem[] items3 = newManager.FilterTodoItems(startDate, endDate, st);
                        for (int i = 0; i < items3.Length; i++)
                        {
                            Console.WriteLine(items3[i].Title, items3[i].Description, items3[i].Deadline, items3[i].Status);
                        }
                        break;

                    case "6":
                        Console.WriteLine("Nomreni daxil et");
                        int no = int.Parse(Console.ReadLine());
                        Console.WriteLine("Statusu daxil et");
                        string status2 = Console.ReadLine();
                        break;

                    case "7":
                        Console.WriteLine("Nomreni daxil et");
                        int no1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Deadline-i daxil et");
                        DateTime deadline = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Description-u daxil et");
                        string description =Console.ReadLine();
                        Console.WriteLine("Title-i daxil et");
                        string title =Console.ReadLine();
                        newManager.EditTodoItem(no1, deadline, title, description);
                        break;

                    case "8":
                        Console.WriteLine("Nomreni daxil et");
                        int no2 = int.Parse(Console.ReadLine());
                        TodoItem[] deleteArr = newManager.DeleteTodoItem(no2);
                        break;

                    case "9":
                        Console.WriteLine("Title-i daxil et");
                        string title1 = Console.ReadLine();
                        TodoItem[] searchItems = newManager.SearchTodoItems(title1);
                        break;

                    case "0":
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Duzgun deyer daxil et");
                        break;



                }
                

            } while (opt != "0");
           

        }
    }
}
