//2 - faça um programa que receba a idade de 10 pessoas e mostre a quantidade de maiores e menores de idade

int idade, contador, maioridade, menoridade;

contador = 1;
maioridade = 0;
menoridade = 0;

while(contador <= 10)
{
    Console.WriteLine($"Por favor, informe a {contador}a idade:");
    idade = int.Parse(Console.ReadLine());

    while (idade < 0)
    {
        Console.WriteLine($"Por favor, informe uma {contador}a idade válida:");
        idade = int.Parse(Console.ReadLine());
    }

    if(idade >= 18)
    {
        maioridade++;
    } else
    {
        menoridade++;
    }

    contador++;
}

Console.WriteLine($"Existem {maioridade} pessoas que são MAIORES de idade e {menoridade} pessoas que são MENORES de idade.");

Console.ReadKey();