using FlexAPessoa;
using POOAluno;

Texto pedro = new Texto(texto: "Pedro", patternValido: "\\p{L}\\s.");
Texto alvares = new Texto(texto: "Álvares", patternValido: "\\p{L}\\s.");
RA ra = new RA(numero: "k82jsg7", patternValido: "a-zA-Z0-9");

Aluno pedro_alvares = new Aluno(nome: pedro, sobrenome: alvares, matricula: ra);

Console.WriteLine($"Aluno {pedro_alvares.ObterNomeCompleto()}"); 
Console.WriteLine($"Aluno {pedro_alvares.ObterNomeCompletoComMatricula()}");
