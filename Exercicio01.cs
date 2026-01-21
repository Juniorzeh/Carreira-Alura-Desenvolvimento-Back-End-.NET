//Exercicio01

//Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.


void ExibirQuatroOperacoes()
{
    float a = 5;
    float b = 9;

    float soma = a + b;
    float subtracao = a - b;
    float divisao = a / b;
    float multiplicacao = a * b;

    Console.WriteLine($"a + b = {soma}");
    Console.WriteLine($"a - b = {subtracao}");
    Console.WriteLine($"a / b = {divisao}");
    Console.WriteLine($"a * b = {multiplicacao}");
}

ExibirQuatroOperacoes();

//Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.

List<string> listaBandas = new List<string>();
listaBandas.Add("SlipKnot");
listaBandas.Add("Pink Floyd");
listaBandas.Add("Creed");
listaBandas.Add("Linkin Park");

//Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.

for (int i = 0; i < listaBandas.Count; i++)
{
    Console.WriteLine(listaBandas[i]);
}

//Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
int soma = 0;

foreach (int numero in numeros)
{
    soma += numero;
}

Console.WriteLine($"A soma dos elementos da lsita é: {soma}");

//Criar um programa que calcula a média dos elementos de ponto flutuante em uma lista.

List<double> numeros01 = new List<double> { 1.5, 2.5, 3.5, 4.5 };
double somar = 0;

foreach (double numero in numeros01)
{
    somar += numero;
}

double media = soma / numeros01.Count;
Console.WriteLine($"A média dos elementos da lista é: {media}");

//Desenvolver um programa que exibe a tabuada de um número.

int numeroTabuada = 5;

for (int i = 0; i <= 10; i++)
{
    int resultados = numeroTabuada * i;
    Console.WriteLine($"{numeroTabuada} x {i} = {resultados}");
}

//Desenvolver uma calculadora simples que realiza as quatro operações básicas, a partir dado dois numeros e um operador.

double numero01 = 4;
double numero02 = 5;
char operacao = '+';

double resultado = 0;

switch (operacao)
{
    case '+':
        resultado = numero01 + numero02;
        break;
    case '-':
        resultado = numero01 - numero02;
        break;
    case '/':
        resultado = numero01 / numero02;
        break;
    case '*':
        resultado = numero01 * numero02;
        break;
    default:
        Console.WriteLine("OOppeerração inválida. ");
        return;
}

Console.WriteLine($"Resultado da operação: {resultado}");
