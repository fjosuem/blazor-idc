using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace IDC
{
    public class GlobalUtil
    {
        public string UrlIDCAnterior { get; set; } = "https://iglesiadecristo.cc";
        public string UrlApi { get; set; } = "https://localhost:7296";
        //public string UrlApi { get; set; } = "http://apiidc.iglesiadecristo.cc";

        // Método para generar el slug a partir del id y el título
        public string GenerarSlug(int id, string titulo)
        {
            string phrase = string.Format("{0}-{1}", id, titulo);

            string str = RemoveAccent(phrase).ToLower();
            // invalid chars
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens
            return str;
        }

        public string RemoveAccent(string text)
        {
            string normalized = text.Normalize(NormalizationForm.FormD);
            StringBuilder builder = new StringBuilder();

            foreach (char c in normalized)
            {
                UnicodeCategory category = CharUnicodeInfo.GetUnicodeCategory(c);
                if (category != UnicodeCategory.NonSpacingMark)
                {
                    builder.Append(c);
                }
            }

            return builder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
