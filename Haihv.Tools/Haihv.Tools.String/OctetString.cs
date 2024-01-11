namespace Haihv.Tools.String;

public class OctetString(string octetString)
{
    public byte[] Result => ConvertToByteArray(octetString);
    public static byte[] ConvertToByteArray(string octetString)
    {
        // Chuyển đổi từ Octet String sang byte array
        return Enumerable.Range(0, octetString.Length)
                         .Where(x => x % 2 == 0)
                         .Select(x => Convert.ToByte(octetString.Substring(x, 2), 16))
                         .ToArray();
    }
}
