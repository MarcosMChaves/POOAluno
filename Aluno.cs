using FlexAPessoa;

namespace POOAluno
{
    public class Aluno
    {
        private readonly Texto Nome;
        private readonly Texto Sobrenome;
        private readonly RA Matricula;

        public Aluno(Texto nome, Texto sobrenome, RA matricula)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Sobrenome = sobrenome ?? throw new ArgumentNullException(nameof(sobrenome));
            Matricula = matricula ?? throw new ArgumentNullException(nameof(matricula));
        }
        private string FormatarNomeCompleto()
        {
            return $"{Nome.GetTexto()} {Sobrenome.GetTexto()}";
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
