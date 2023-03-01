using ClassLibrary1;

Console.Write("Введите количество людей: ");
int n = Convert.ToInt32(Console.ReadLine());
Person[] person = new Person[n];
for (int i = 0; i < n; i++)
{
    person[i] = new Person();
    person[i].input();
}
foreach (Person p in person)
{
    Console.WriteLine($"Имя: {p.SurName}.{p.Name[0]}. Возраст: {p.age()} Пол: {p.Sex}");
}