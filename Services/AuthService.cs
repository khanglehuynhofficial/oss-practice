namespace prj1.Services;

public class AuthService
{
    private const string ValidUsername = "admin";
    private const string ValidPassword = "admin1234";
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
            password.Length > MaximumPasswordLength)
        {
            Console.WriteLine("[Lỗi] Mật khẩu phải có từ 6 đến 32 ký tự.");
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
