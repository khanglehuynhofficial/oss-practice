using prj1.Model;

namespace prj1.Services;

public class StudentManager
{
    private readonly List<Student> students = new();

    public void AddStudent(Student student)
    {
        ArgumentNullException.ThrowIfNull(student);

        if (students.Any(existingStudent => existingStudent.Id == student.Id))
        {
            Console.WriteLine($"[Lỗi] ID = {student.Id} đã tồn tại.");
            return;
        }

        students.Add(student);
        Console.WriteLine($"[Thành công] Đã thêm sinh viên ID = {student.Id}.");
    }

    public void AddStudent(int id, string name, int age)
    {
        try
        {
            AddStudent(new Student(id, name, age));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"[Lỗi] Không thể thêm sinh viên: {ex.Message}");
        }
    }

    public Student? GetStudentById(int id)
    {
        return students.FirstOrDefault(student => student.Id == id);
    }

    public void DeleteStudent(int id)
    {
        if (id <= 0)
        {
            Console.WriteLine("[Lỗi] ID phải lớn hơn 0.");
            return;
        }

        Student? student = GetStudentById(id);
        if (student is null)
        {
            Console.WriteLine($"[Lỗi] Không tìm thấy sinh viên có ID = {id}.");
            return;
        }

        students.Remove(student);
        Console.WriteLine($"[Thành công] Đã xóa sinh viên có ID = {id}.");
    }

    public void DisplayAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("[Thông báo] Danh sách sinh viên trống.");
            return;
        }

        foreach (Student student in students)
        {
            student.DisplayStudentInfo();
        }
    }
}
