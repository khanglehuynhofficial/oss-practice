namespace prj1.Services;

public class AuthService
{
    private const string ValidUsername = "admin";
    private const string ValidPassword = "Admin1234!";
    private const int MinimumPasswordLength = 6;
    private const int MaximumPasswordLength = 32;

    public bool Login(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            Console.WriteLine("[Lỗi] Tên đăng nhập không được để trống.");
            return false;
        }

        if (string.IsNullOrEmpty(password) ||
            password.Length < MinimumPasswordLength ||
            password.Length > MaximumPasswordLength ||
            !password.Any(char.IsUpper) ||
            !password.Any(char.IsLower) ||
            !password.Any(char.IsDigit) ||
            password.All(char.IsLetterOrDigit))
        {
            Console.WriteLine("[Lỗi] Mật khẩu phải có từ 6 đến 32 ký tự, gồm chữ hoa, chữ thường, số và ký tự đặc biệt.");
            return false;
        }

        if (username != ValidUsername || password != ValidPassword)
        {
            Console.WriteLine("[Lỗi] Tên đăng nhập hoặc mật khẩu không đúng.");
            return false;
        }

        Console.WriteLine("[Thành công] Đăng nhập thành công.");
        return true;
    }
}
