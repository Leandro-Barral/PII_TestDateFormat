namespace Ucu.Poo.TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        if (date.Length != 10 || date[2].ToString() != "/" || date[5].ToString() != "/" 
        || !Int32.TryParse(date.Substring(6), out int result) || !Int32.TryParse(date.Substring(3, 2), out result)
        || !Int32.TryParse(date.Substring(0, 2), out result)){
            return date;
        }
        return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
    }
}
