// See https://aka.ms/new-console-template for more information


//Console.WriteLine("Hello, World!");

namespace Lab_7
{
    public class Progran
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine(args[0]);
            }
            else
            {
                Console.WriteLine("No command Line arguemnts sepcified!");
            }
        }

        // student examples
        Student s1 = new Student("X000000001", "Zeus", Student.Gender.Male);
        Student s2 = new Student("X000000002", "Hades", Student.Gender.Male);
        Student s3 = new Student("X000034888", "Apolo", Student.Gender.Male);
        Student s4 = new Student("X001004568", "Hera", Student.Gender.Female);
        Student s5 = new Student("X000034007", "Athena", Student.Gender.Female);
        Student s6 = new Student("X000078007", "Artemis", Student.Gender.NonBinary);
    }
}
