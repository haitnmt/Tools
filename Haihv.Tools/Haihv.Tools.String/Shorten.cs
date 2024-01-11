using System.Text;

namespace Haihv.Tools.String;

public class Shorten(string input, int step = 2)
{
    public string Result => GetEveryNthCharacter(input, step);
    public static string GetEveryNthCharacter(string input, int step = 2)
    {
        if (step <= 0)
        {
            throw new ArgumentException("Parameter 'step' must be greater than zero.");
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
            y /= step;
            if (y < 1) y = 1;
        }
        return resultBuilder.ToString();
    }
}
