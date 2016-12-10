using System;


public static class Utils
{
    public static string FN(string ANumero)
    {
        if (string.IsNullOrEmpty(ANumero))
        {
            return "null";
        }
        else
        {
            try
            {
                string retorno = ANumero.Replace(".", "");
                n = Convert.ToDecimal(retorno.Trim());
                retorno = retorno.Replace(",", ".");
            }
            catch
            {
                return "null";
            }
        }
    }
}