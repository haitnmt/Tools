using System.Text;
using System.Text.RegularExpressions;

namespace Haihv.Tools.String
{
    public static class HvHString
    {
        public static string GenerateSecretKey(int length = 64)
        {
            Random random = new();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#&*%-+=.$_^~<>!?";
            StringBuilder result = new(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }
            return result.ToString();
        }
        public static byte[] ConvertOctetStringToByteArray(string octetString)
        {
            // Chuyển đổi từ Octet String sang byte array
            return Enumerable.Range(0, octetString.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(octetString.Substring(x, 2), 16))
                             .ToArray();
        }
        public static string GetEveryNthCharacter(string input, int n = 2)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Parameter 'n' must be greater than zero.");
            }

            // Sử dụng StringBuilder để xây dựng kết quả
            StringBuilder resultBuilder = new();
            int length = input.Length / 2;
            string intput1 = input[..length];
            string intput2 = input.Substring(length, length);
            int y = length;
            for (int i = 0; i < length; i += y)
            {
                // Lấy ký tự tại vị trí i
                resultBuilder.Append(intput1[i]);
                resultBuilder.Append(intput2[length - i - 1]);
                y /= n;
                if (y < 1) y = 1;
            }
            return resultBuilder.ToString();
        }
        public static bool IsEmailValid(string email)
        {
            // Biểu thức chính quy kiểm tra địa chỉ email
            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Kiểm tra xem chuỗi có khớp với biểu thức chính quy không
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
