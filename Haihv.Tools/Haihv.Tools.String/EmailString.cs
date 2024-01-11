using System.Text.RegularExpressions;

namespace Haihv.Tools.String;

public class Valid(string input)
{
    public bool IsEmail => IsEmailValid(input);
    public static bool IsEmailValid(string input)
    {
        // Biểu thức chính quy kiểm tra địa chỉ input
        string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        // Kiểm tra xem chuỗi có khớp với biểu thức chính quy không
        return Regex.IsMatch(input, emailPattern);
    }
}
