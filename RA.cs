
using OOPFoundation;
using System.Text.RegularExpressions;

namespace POOAluno
{
    public class RA: ISanitization, ITextValidation
    {
        private readonly string Numero;
        private readonly string PatternValido;

        public RA(string numero, string patternValido)
        {
            PatternValido = patternValido.Trim();

            string numeroSanitizado = Sanitize(textoParaSanitizar: numero);
            if (!TextIsValid(textoParaValidar: numeroSanitizado))
            {
                throw new ArgumentException($"Argumento 'numero'='{numero}' inválido!");
            }

            Numero = numeroSanitizado.ToUpper();

        }
        public string Sanitize(string textoParaSanitizar)
        {
            string textoSanitizado = System.String.Empty;
            try
            {
                textoSanitizado = Regex.Replace(textoParaSanitizar, @$"[^{PatternValido}]", string.Empty).Trim();
            }
            catch (ArgumentException)
            {
                throw new ArgumentException($"Pattern 'pattern'='{PatternValido}' inválido!");
            }

            return textoSanitizado;
        }

        public bool TextIsValid(string textoParaValidar)
        {
            if (String.IsNullOrEmpty(textoParaValidar) ||
                String.IsNullOrWhiteSpace(textoParaValidar))
            {
                return false;
            }

            return true;
        }

        private string FormatarNumero()
        {
            return $"{Numero.Substring(0, 6)}-{Numero.Substring(6)}";
        }
        public string ObterNumero()
        {
            return FormatarNumero();
        }
    }
}
