struct Student
{
    public string Name;
    public string SurName;
    public string Otchestvo;
    public int NumberOfGroup;
    public int[] Grades;

    public double GetAverageGrade()
    {
        return Grades.Average();
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[7];

        students[0] = new Student { SurName = "Иванов", Name = "Иван", Otchestvo = "Иванович", NumberOfGroup = 11, Grades = new int[] { 4, 5, 3, 4, 5 } };
        students[1] = new Student { SurName = "Петров", Name = "Александр", Otchestvo = "Станиславович", NumberOfGroup = 12, Grades = new int[] { 5, 5, 5, 4, 3 } };
        students[2] = new Student { SurName = "Сидоров", Name = "Алексей", Otchestvo = "Сергеевич", NumberOfGroup = 13, Grades = new int[] { 3, 3, 4, 4, 5 } };
        students[3] = new Student { SurName = "Козлов", Name = "Игорь", Otchestvo = "Олегович", NumberOfGroup = 13, Grades = new int[] { 4, 3, 4, 2, 4 } };
        students[4] = new Student { SurName = "Никитин", Name = "Роман", Otchestvo = "Алексеевич", NumberOfGroup = 11, Grades = new int[] { 5, 4, 5, 5, 5 } };
        students[5] = new Student { SurName = "Антонов", Name = "Владислав", Otchestvo = "Петрович", NumberOfGroup = 12, Grades = new int[] { 2, 3, 3, 4, 2 } };
        students[6] = new Student { SurName = "Максимов", Name = "Николай", Otchestvo = "Александрович", NumberOfGroup = 11, Grades = new int[] { 4, 4, 4, 5, 5 } };

        Array.Sort(students, delegate (Student x, Student y)
        {
            return x.GetAverageGrade().CompareTo(y.GetAverageGrade());
        });

        // Вывод отсортированного списка студентов
        Console.WriteLine("Студенты, упорядоченные по возрастанию среднего балла:");
        foreach (var student in students)
        {
            Console.WriteLine($"Фамилия: {student.SurName}, Имя: {student.Name}, Отчество: {student.Otchestvo}, Группа: {student.NumberOfGroup}, Средний балл: {student.GetAverageGrade()}");
        }
    }
}
