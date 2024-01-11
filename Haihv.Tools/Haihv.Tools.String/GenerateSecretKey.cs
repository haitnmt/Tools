using System.Text;

namespace Haihv.Tools.String
{
    public class GenerateSecretKey(int length = 64)
    {
        public string Result => GenerateSecret(length);
        public static string GenerateSecret(int length = 64)
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
    }
}
