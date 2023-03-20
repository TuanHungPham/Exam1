using BaiTest;

TestStudent testStudent = new TestStudent();

Input:
Console.Clear();
Console.WriteLine("Please select an option:");
Console.WriteLine("=========================================================");
Console.WriteLine("1. Input information <input details for a student>.");
Console.WriteLine("2. Sorting student ascending by average mark.");
Console.WriteLine("3. Display all the student list.");
Console.WriteLine("4. Search Student by Name.");
Console.WriteLine("5. Delete Student by student ID.");
Console.WriteLine("6. Exit program.");
Console.WriteLine("=========================================================");

Console.Write("Option: ");
int n = Convert.ToInt32(Console.ReadLine());

switch (n)
{
    case 1:
        Student newStudent = new Student();
        testStudent.studentList.Add(newStudent);
        testStudent.Input(newStudent);
        break;

    case 2:
        testStudent.Sort();
        Console.WriteLine("Done!");
        break;

    case 3:
        Console.Clear();
        foreach (Student student in testStudent.studentList)
        {
            testStudent.Display(student);
        }
        break;

    case 4:
        Console.Write("Input Student's Name: ");
        string? s = Console.ReadLine();

        if (string.IsNullOrEmpty(s))
        {
            throw new ArgumentException("Input is not valid!!");
        }

        testStudent.FindStudentByName(s);
        break;

    case 5:
        Console.Write("Input Student's ID: ");
        int a = Convert.ToInt32(Console.ReadLine());
        testStudent.DeleteStudentByID(a);
        break;

    case 6:
        goto ExitOrContinue;

    default:
        Console.WriteLine("Input is invalid! Please try again: ");
        goto Input;
}

ExitOrContinue:
Console.Write("Do you want to continue: (Y/N)");
char c = Convert.ToChar(Console.ReadLine());
if (c == 'y' || c == 'Y')
{
    goto Input;
}
else if (c == 'n' || c == 'N')
{
    return;
}
else
{
    Console.WriteLine("Input is invalid! Please try again: ");
    goto ExitOrContinue;
}