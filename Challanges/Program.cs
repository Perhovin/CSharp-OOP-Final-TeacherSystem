using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

class Teacher
{
    private string name = "";
    private string subject = "";
    private int yearsOfExperience;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Subject
    {
        get { return subject; }
        set
        {
            if (value != "")
            {
                subject = value;
            }
        }
    }

    public int YearsOfExperience
    {
        get { return yearsOfExperience; }
        set
        {
            if (value >= 0)
            {
                yearsOfExperience = value;
            }
        }
    }

    public Teacher(string name, string subject, int yearsOfExperience)
    {
        Name = name;
        Subject = subject;
        YearsOfExperience = yearsOfExperience;
    }

    public void ShowProfile()
    {
        Console.WriteLine($"Name: {Name}, Subject: {Subject}, Experience: {YearsOfExperience}");
    }
}

class Program
{
    static void Main()
    {
        List<Teacher> teachers = new List<Teacher>();
        
        teachers.Add(new Teacher("Alex", "Math", 6));
        teachers.Add(new Teacher("Andrew", "Physics", 3));
        teachers.Add(new Teacher("Maxim", "Electronics", 7));
        
        foreach (Teacher t in teachers)
        {
           t.ShowProfile();
        }
        
        bool running = true;
        Console.WriteLine("\nTeacher System");
        
        while (running)
        {
            ShowMenu();

            Console.Write("\nChoose an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddTeacher(teachers);
                    break;
                case 2:
                    ShowTeachers(teachers);
                    break;
                case 3:
                    CountTeachers(teachers);
                    break;
                case 4:
                    AVGyears(teachers);
                    break;
                case 0:
                    Console.WriteLine("Exiting the program...");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }


    static void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1. Add Teacher");
        Console.WriteLine("2. Show all of the Teachers");
        Console.WriteLine("3. Count all of the Teachers");
        Console.WriteLine("4. Average years of experience");
        Console.WriteLine("0. Exit");
    }

    static void AddTeacher(List<Teacher> teachers)
    {
        Console.Write("Write teacher's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter subject: ");
        string subject = Console.ReadLine();

        Console.Write("Enter years of experience: ");
        int exp = int.Parse(Console.ReadLine());

        teachers.Add(new Teacher(name, subject, exp));
        Console.WriteLine("Teacher added successfully!");
    }

    static void ShowTeachers(List<Teacher> teachers)
    {
        if (teachers.Count == 0)
        {
            Console.WriteLine("No teachers in the list.");
            return;
        }
        else
        {
            Console.WriteLine("Teacher List");
            foreach (Teacher t in teachers)
            {
                t.ShowProfile();
            }
        }
    }

    static void CountTeachers(List<Teacher> teachers)
    {
        Console.WriteLine($"Teachers in the system: {teachers.Count}");
    }

    static void AVGyears(List<Teacher> teachers)
    {
        if (teachers.Count == 0)
        {
            Console.WriteLine("No teachers to calculate avarage expirience.");
            return;
        }
        double totalYears = 0;
        foreach (Teacher t in teachers)
        {
            totalYears += t.YearsOfExperience;
        }
        double average = totalYears / teachers.Count;
        Console.WriteLine($"AVG years of expirience: {average}");
    }
}