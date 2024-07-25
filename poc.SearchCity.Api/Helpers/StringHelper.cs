using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace poc.SearchCity.Api.Helpers
{
    public static class StringHelper
    {
        public static string Normalizestring(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            var normalizedstring = input.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach ( char c in normalizedstring ) {
                var uc = CharUnicodeInfo.GetUnicodeCategory(c);
                if ( uc != UnicodeCategory.NonSpacingMark ) {
                    sb.Append(c);
                }
            }

            var result = Regex.Replace(sb.ToString(), @"[^a-zA-Z0-9\s]", string.Empty);
            return result.Normalize(NormalizationForm.FormC);
        }
    }
}
