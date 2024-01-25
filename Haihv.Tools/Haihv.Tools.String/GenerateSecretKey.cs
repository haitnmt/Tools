using System.Text;

namespace Haihv.Tools.String
{
    public class GenerateSecretKey(int length = 64, bool includeNumber = true, bool includeSymbol = true)
    {
        public string Result => GenerateSecret(length, includeNumber, includeSymbol);
        public static string GenerateSecret(int length = 64, bool includeNumber = true, bool includeSymbol = true)
        {
            Random random = new();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            if (includeNumber) chars += "0123456789";
            if (includeSymbol) chars += "@#&*%-+=.$_^~<>!?";
            StringBuilder result = new(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }
            return result.ToString();
        }
    }
}
