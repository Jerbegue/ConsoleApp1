using ConsoleApp1;
using System.Reflection;

string path = "File1.txt";
if (!File.Exists(path))
{
    Console.WriteLine("File does not exists, creating file...");
    File.Create(path);
    ReadFile(path);
}
else
{
    Console.WriteLine("File already exists");
    ReadFile(path);
    return;
}

var student = new Student("John", 22);
var employee = new Employee("Matthew", 23);
var university = new University("Polytech", 5);

PropertyInfo[] propStudent = typeof(Student).GetProperties();
PropertyInfo[] propEmployee = typeof(Employee).GetProperties();
PropertyInfo[] propUniversity = typeof(University).GetProperties();

var linesToWrite = new List<string>();

linesToWrite.Add("Student properties:");
GetProps(propStudent, student, linesToWrite);

linesToWrite.Add("\nEmployee properties:");
GetProps(propEmployee, employee, linesToWrite);

linesToWrite.Add("\nUniversity properties:");
GetProps(propUniversity, university, linesToWrite);

void GetProps(PropertyInfo[] propertyInfos, object obj, List<string> lines)
{
    foreach (var propertyInfo in propertyInfos)
    {
        var value = propertyInfo.GetValue(obj);
        lines.Add($"{propertyInfo.Name}: {value}");
    }
}

void ReadFile(string path)
{
    string[] lines = File.ReadAllLines(path);
    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }
}