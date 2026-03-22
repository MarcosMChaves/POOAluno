using OOPFoundation;
using POOAluno;

Text pedro = new Text(text: "Pedro", validPattern: "\\p{L}\\s.");
Text alvares = new Text(text: "Álvares", validPattern: "\\p{L}\\s.");
RA ra = new RA(numero: "k82jsg7", patternValido: "a-zA-Z0-9");

Aluno pedro_alvares = new Aluno(nome: pedro, sobrenome: alvares, matricula: ra);

Console.WriteLine($"Aluno {pedro_alvares.ObterNomeCompleto()}"); 
Console.WriteLine($"Aluno {pedro_alvares.ObterNomeCompletoComMatricula()}");
