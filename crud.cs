using System;

namespace GENERIC
{
    public class crud
    {
        Repository<Student> repository = new Repository<Student>();
        public int id, Choice;
        public string name;
        public void Introduce()
        {
            while (true)
            {
                Program.Option();
                Console.Write("Enter your Choice in Option: ");
                Choice = int.Parse(Console.ReadLine());

                switch (Choice) 
                { 
                    case 1:
                        ADD();
                        break;
                    case 2:
                        READ(); 
                        break;
                    case 3:
                        UPDATE();
                        break;
                    case 4:
                        DELETE();
                        break;
                    case 5:
                        EXIT();
                        return;
                    default:
                        break;
                }
            }
        }
        public void ADD()
        {
            Console.WriteLine("\n=========ADD STUDENT========");
            Console.Write("Enter ID: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            if(repository.Read(s => s.Id == id) == null)
            {
                repository.Create(new Student { Id = id, Name = name });
                Console.WriteLine("Student Added Successfully!!!");
            }
            else
            {
                Console.WriteLine("ID already Exist!!!");
            }
        }

        
        public void READ()
        {
            Console.WriteLine("\n=======DISPLAY STUDENT BY ID=======");
            Console.Write("Enter ID to Display: ");
            id = int.Parse(Console.ReadLine());
            var student = repository.Read(s => s.Id == id);
            if (student != null)
            {
                Console.WriteLine("\n\t ID \tNAME");
                Console.WriteLine($"Student: {student.Id} \t{student.Name}");
            }
            else
            {
                Console.WriteLine("Student ID not Found!!!");
            }
        }
        public void UPDATE()
        {
            Console.WriteLine("\n=======UPDATE STUDENT BY ID=======");
            Console.Write("Enter Student ID to Update: ");
            id = int.Parse(Console.ReadLine());
            var student = repository.Read(s => s.Id == id);
            if (student != null)
            {
                Console.Write("Enter new Name: ");
                name = Console.ReadLine();
                repository.Update(s => s.Id == id, new Student { Id = id, Name = name });
                Console.WriteLine("Student Updated Successfully!!!");
            }
            else
            {
                Console.WriteLine("Student ID not Found!!!");
            }

        }
        public void DELETE()
        {
            Console.WriteLine("\n=======DELETE STUDENT BY ID=======");
            Console.Write("Enter Student ID to Delete: ");
            id = int.Parse(Console.ReadLine());
            var student = repository.Read(s => s.Id == id);
            if (student != null)
            {
                repository.Delete(s => s.Id == id);
                Console.WriteLine("Student Successfully Deleted!!!");
            }
            else
            {
                Console.WriteLine("Student ID not Found!!!");
            }
        }
        public void EXIT()
        {
            Console.WriteLine("=======EXIT=======");

        }
    }
}
