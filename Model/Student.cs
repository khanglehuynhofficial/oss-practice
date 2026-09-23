namespace prj1.Model;

public class Student
{
    public int Id { get; }
    public string Name { get; }
    public int Age { get; }

    public Student(int id, string name, int age)
    {
        if (id <= 0)
        {
            throw new ArgumentException("ID phải lớn hơn 0.", nameof(id));
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Tên sinh viên không được để trống.", nameof(name));
        }

        if (age < 16 || age > 100)
        {
            throw new ArgumentException("Tuổi phải nằm trong khoảng từ 16 đến 100.", nameof(age));
        }

        Id = id;
        Name = name.Trim();
        Age = age;
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine($"ID: {Id}, Tên: {Name}, Tuổi: {Age}");
    }
}
