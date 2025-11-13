// See https://aka.ms/new-console-template for more information

//Ler um número inteiro e exibir o dobro do mesmo.

//const int DOBRO = 2;

//Console.WriteLine("Escolha um número inteiro");
//int.Parse(Console.ReadLine());

//Console.WriteLine("O dobro desse número é");
//int.Parse(Console.ReadLine());

//------------------------------------------------------------------------------------------'

//Console.WriteLine("Escreva um número inteiro e após isso você irá visualizar o dobro dele: ");
//String inteiro = Console.ReadLine();
//int num = int.Parse(inteiro);
//int dobro = num * 2;
//Console.WriteLine("o Dobro desse número " + inteiro + " é " + dobro);

//------------------------------------------------------------------------------------------'

//Exercicio 2 - Parte 1 

//Console.WriteLine("Digite o lado do quadrado ");

//String tamn = Console.ReadLine();

//int tam = int.Parse(tamn);

//int per = tam * 4;

//int area = tam * tam;

//Console.WriteLine("o Perímetro do quadrado é " + per + " e a area " + area);

//------------------------------------------------------------------------------------------'

//Exercicio 3 - Ler um número inteiro e exibir se ele é impar ou par.
//
Console.WriteLine("Escreva um número qualquer, inteiro ou não");
double num = double.Parse(Console.ReadLine());

if (num % 2 == 0)
{

    Console.WriteLine(num + " Este número é Par ");

}
else
{
    Console.WriteLine(num + " Este número é Impar ");
}

