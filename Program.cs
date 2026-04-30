string file = "tasks.txt";
if (!File.Exists(file))
{
    Console.WriteLine("Task file not found.");
    Console.WriteLine("Creating a new task file...");
    File.Create(file).Close();
}
int option = 0;
while (option != 4)
{
    Console.WriteLine("=== TASK MANAGER ===");
    Console.WriteLine("1 - View tasks");
    Console.WriteLine("2 - Add task");
    Console.WriteLine("3 - Remove task");
    Console.WriteLine("4 - Exit");
    option = int.Parse(Console.ReadLine() ?? "0");
    if (option == 1)
    {
        if (File.Exists(file))
        {
            string[] lines = File.ReadAllLines(file);
            List<string> tasks = new List<string>(lines);
            Console.WriteLine("Tasks:");
            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
    if (option == 2)
    {
        Console.WriteLine("Enter the new task:");
        string newTask = Console.ReadLine() ?? "";
        File.AppendAllText(file, newTask + Environment.NewLine);
        Console.WriteLine("Task added successfully.");
    }
    if (option == 3)
    {
        string[] lines = File.ReadAllLines(file);
        List<string> tasks = new List<string>(lines);
        Console.WriteLine("Tasks:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {tasks[i]}");
        }
        Console.WriteLine("Enter the task number to remove:");
        int taskNumber = int.Parse(Console.ReadLine() ?? "0");
        if (File.Exists(file))
        {
            if (taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1);
                File.WriteAllLines(file, tasks);
                Console.WriteLine("Task removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
    if (option == 4)
    {
        Console.WriteLine("Exiting...");
    }
    if (option > 4 || option < 1)
    {
        Console.WriteLine("Invalid option!");
    }
}