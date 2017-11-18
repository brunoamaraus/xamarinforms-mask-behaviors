using System.Text.RegularExpressions;

namespace MaskBehavior.Helpers
{
    public static class ExtensionMethods
    {
        public static string RemoveNonNumbers(this string texto)
        {
            var regex = new Regex(@"[^\d]");
            return regex.Replace(texto, "");
        }
    }
}
