using OOPFoundation;

namespace POOAluno
{
    public class Aluno
    {
        private readonly Text Nome;
        private readonly Text Sobrenome;
        private readonly RA Matricula;

        public Aluno(Text nome, Text sobrenome, RA matricula)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Sobrenome = sobrenome ?? throw new ArgumentNullException(nameof(sobrenome));
            Matricula = matricula ?? throw new ArgumentNullException(nameof(matricula));
        }
        private string FormatarNomeCompleto()
        {
            return $"{Nome.GetText()} {Sobrenome.GetText()}";
        }
        private string FormatarNomeCompletoComMatricula()
        {
            return $"{FormatarNomeCompleto()} ({Matricula.ObterNumero()})";
        }
        public string ObterNomeCompleto()
        {
            return FormatarNomeCompleto();
        }
        public string ObterNomeCompletoComMatricula()
        {
            return FormatarNomeCompletoComMatricula();
        }
    }
}
