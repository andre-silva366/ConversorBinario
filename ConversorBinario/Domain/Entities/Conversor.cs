using System.Text;

namespace ConversorBinario.Domain.Entities;

public static class Conversor
{
    public static string Texto { get; set; }

    public static string ConverterTextoBinario(string texto)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(texto);
        string resultado = string.Join(" ", bytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
        return resultado;
    }

    public static string ConverterBinarioTexto(string binario)
    {
        binario = binario.Replace(" ", "");
        var bytes = Enumerable.Range(0, binario.Length / 8)
            .Select(i => binario.Substring(i * 8, 8))
            .Select(s => Convert.ToByte(s, 2))
            .ToArray();
        return Encoding.UTF8.GetString(bytes);
    }

    public static string ConverterLongBinario(long numero)
    {
        string resultado = Convert.ToString(numero,2).PadLeft(8,'0');
        return resultado;
    }

    public static long ConverterBinarioLong(string binario)
    {
        binario = binario.Replace(" ", "");
        long resultado = Convert.ToInt64(binario,2);
        return resultado;
    }

    public static string ConverterTextoHexadecimal(string texto)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(texto);
        string resultado = BitConverter.ToString(bytes);
        return resultado;
    }

    public static string ConverterHexadecimalTexto(string hexadecimal)
    {
        hexadecimal = hexadecimal.Replace("-", "");
        byte[] bytes = Enumerable.Range(0, hexadecimal.Length / 2)
                .Select(i => Convert.ToByte(hexadecimal.Substring(i * 2, 2), 16))
                .ToArray();
        string texto = Encoding.UTF8.GetString(bytes);
        return texto;
    }
}
