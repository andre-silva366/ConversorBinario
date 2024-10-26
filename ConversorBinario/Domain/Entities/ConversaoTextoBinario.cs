using System.Text;

namespace ConversorBinario.Domain.Entities;

public class ConversaoTextoBinario
{
    public string Texto { get; set; }

    public ConversaoTextoBinario(string texto)
    {
        Texto = texto;
    }

    public string ConverterTextoBinario(string texto)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(texto);
        string resultado = string.Join(" ", bytes.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
        return resultado;
    }

}
