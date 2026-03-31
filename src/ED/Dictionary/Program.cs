using System.Runtime.Serialization;

Dictionary<string, int> students = new Dictionary<string, int>()
{
    {"Maria", 7},
    {"Eric", 8},
    {"Ana", 9},
    {"Alex", 6},
    {"Diná", 5}
};



students.Remove("Maria");
students.Add("João", 10);

var listaorder = students.OrderBy(x => x.Value);

foreach(var s in listaorder)
{
    System.Console.WriteLine($"Aluno: {s.Key} - {s.Value}");
}

students.Clear();

if (students.Count == 0)
    System.Console.WriteLine("\nVazio!!");

