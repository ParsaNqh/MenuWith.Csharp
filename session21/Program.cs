using session21.Models.Entities;
using sesstion.Infrastructure.Data;
using sesstion21.Tools;

var mainMenu = new Menu();

mainMenu.Items.Add("1-Add student");
mainMenu.Items.Add("2-Student List");
mainMenu.Items.Add("3-Count Of Students");
mainMenu.Items.Add("4-Best Students By Average");
mainMenu.Items.Add("5-Students By Average");
mainMenu.Items.Add("6-Add Professor");
mainMenu.Items.Add("7-Professor List");
mainMenu.Items.Add("8-Count Of Professor");
mainMenu.Items.Add("9-Update Student");
mainMenu.Items.Add("10-Update Professor");
mainMenu.Items.Add("11-Delete Student");
mainMenu.Items.Add("12-Delete Professor");
mainMenu.Items.Add("0-Exit");

while (true)
{
    var choise = mainMenu.Show();
    if (choise == 0)
    {
        break;
    }
    else if (choise == 1)
    {
        using (var db = new UniversityDb())
        {
            var newStudent = new Student();
            newStudent.Read();
            db.Students.Add(newStudent);
            db.SaveChanges();
            Console.WriteLine("Done!");
        }
    }
    else if (choise == 2)
    {
        using (var db = new UniversityDb())
        {
            System.Console.WriteLine("----------------------------");
            db.Students.ToList().ForEach(s => Console.WriteLine($"Student: {s}"));
            System.Console.WriteLine("----------------------------");
        }
    }
    else if (choise == 3)
    {
        using (var db = new UniversityDb())
        {
            System.Console.WriteLine("----------------------------");
            Console.WriteLine($"Count of students: {db.Students?.Count()}");
            System.Console.WriteLine("----------------------------");
        }
    }
    else if (choise == 4)
    {
        using (var db = new UniversityDb())
        {
            System.Console.WriteLine("----------------------------");
            db.Students?
                    .OrderByDescending(s => s.Average)
                    .Take(1)
                    .ToList()
                    .ForEach(s => Console.WriteLine(s));
            System.Console.WriteLine("----------------------------");
        }
    }
    else if (choise == 5)
    {
        using (var db = new UniversityDb())
        {
            System.Console.WriteLine("----------------------------");
            db.Students?
                    .OrderByDescending(s => s.Average)
                    .ToList()
                    .ForEach(s => Console.WriteLine(s));
            System.Console.WriteLine("----------------------------");
        }
    }
    else if (choise == 6)
    {
        using (var db = new UniversityDb())
        {
            var newProfessor = new Professor();
            newProfessor.Read();
            db.Professors.Add(newProfessor);
            db.SaveChanges();
            Console.WriteLine("Done!");
        }
    }
    else if (choise == 7)
    {
        using (var db = new UniversityDb())
        {
            System.Console.WriteLine("----------------------------");
            db.Professors
                    .ToList()
                    .ForEach(p => Console.WriteLine($"Professor: {p}"));
            System.Console.WriteLine("----------------------------");

        }
    }
    else if (choise == 8)
    {
        using (var db = new UniversityDb())
        {
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine($"Professors count: {db.Professors.Count()}");
            System.Console.WriteLine("----------------------------");
        }
    }
    else if(choise == 9)
    {
        Console.Write("Id: ");
        var id = int.Parse(Console.ReadLine());
        using (var db = new UniversityDb()) 
        {
            var student = db.Students.FirstOrDefault(s => s.Id == id);
            if (student == null) 
            {
                System.Console.WriteLine("----------------------------");
                Console.WriteLine("Not found!!!");
                System.Console.WriteLine("----------------------------");
            }
            else 
            {
                Console.WriteLine(student);
                System.Console.WriteLine("----------------------------");
                Console.Write("Are you sure?(y/n): ");
                System.Console.WriteLine("----------------------------");
                var update = Console.ReadLine();
                if (update == "y")
                {
                    student.Read();
                    db.SaveChanges();
                    System.Console.WriteLine("----------------------------");
                    Console.WriteLine("Done!");
                    System.Console.WriteLine("----------------------------");
                }
                else
                {
                    System.Console.WriteLine("----------------------------");
                    Console.WriteLine("Nothing happend!!!");
                    System.Console.WriteLine("----------------------------");
                }
            }
        }
    }
    else if (choise == 10) 
    {
        Console.Write("Id: ");
        var id = int.Parse (Console.ReadLine());
        using ( var db = new UniversityDb())
        {
            var professor = db.Professors.FirstOrDefault( p => p.Id == id);
            if (professor == null)
            {
                System.Console.WriteLine("----------------------------");
                Console.WriteLine("Not found!!!");
                System.Console.WriteLine("----------------------------");
            }
            else
            {
                Console.WriteLine(professor);
                System.Console.WriteLine("----------------------------");
                Console.Write("Are you sure?(y/n): ");
                System.Console.WriteLine("----------------------------");
                var update = Console.ReadLine();
                if (update == "y")
                {
                    professor.Read();
                    db.SaveChanges();
                    System.Console.WriteLine("----------------------------");
                    Console.WriteLine("Done!");
                    System.Console.WriteLine("----------------------------");
                }
                else
                {
                    System.Console.WriteLine("----------------------------");
                    Console.WriteLine("Nothing happend!!!");
                    System.Console.WriteLine("----------------------------");
                }
            }
        }
    }
    else if (choise == 11)
    {
        Console.Write("Id: ");
        var id = int.Parse(Console.ReadLine());
        using (var db = new UniversityDb())
        {
            var student = db.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                System.Console.WriteLine("----------------------------");
                Console.WriteLine("Not found!!!");
                System.Console.WriteLine("----------------------------");
            }
            else
            {
                Console.WriteLine(student);
                System.Console.WriteLine("----------------------------");
                Console.Write("Are you sure?(y/n): ");
                System.Console.WriteLine("----------------------------");
                var delete = Console.ReadLine();
                if (delete == "y")
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                    System.Console.WriteLine("----------------------------");
                    Console.WriteLine("Done!");
                    System.Console.WriteLine("----------------------------");
                }
                else
                {
                    System.Console.WriteLine("----------------------------");
                    Console.WriteLine("Nothing happend!!!");
                    System.Console.WriteLine("----------------------------");
                }
            }
        }
    }
    else if(choise == 12) 
    {
        Console.Write("Id: ");
        var id = int.Parse(Console.ReadLine());
        using (var db = new UniversityDb())
        {
            var professor = db.Professors.FirstOrDefault(p => p.Id == id);
            if (professor == null)
            {
                System.Console.WriteLine("----------------------------");
                Console.WriteLine("Not found!!!");
                System.Console.WriteLine("----------------------------");
            }
            else
            {
                Console.WriteLine(professor);
                System.Console.WriteLine("----------------------------");
                Console.Write("Are you sure?(y/n): ");
                System.Console.WriteLine("----------------------------");
                var update = Console.ReadLine();
                if (update == "y")
                {
                    db.Professors.Remove(professor);
                    db.SaveChanges();
                    System.Console.WriteLine("----------------------------");
                    Console.WriteLine("Done!");
                    System.Console.WriteLine("----------------------------");
                }
                else
                {
                    System.Console.WriteLine("----------------------------");
                    Console.WriteLine("Nothing happend!!!");
                    System.Console.WriteLine("----------------------------");
                }
            }
        }
    }
}
