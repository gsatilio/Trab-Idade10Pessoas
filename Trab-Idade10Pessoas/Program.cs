//2 - faça um programa que receba a idade de 10 pessoas e mostre a quantidade de maiores e menores de idade

int idade, contador, maioridade, menoridade;
string sair;

contador = 1;
maioridade = 0;
menoridade = 0;
sair = "N";

while ((contador <= 10) && (sair != "S"))
{
    Console.WriteLine($"Por favor, informe a {contador}a idade:");
    idade = int.Parse(Console.ReadLine());

    while (idade < 0)
    {
        Console.WriteLine($"Por favor, informe uma {contador}a idade válida:");
        idade = int.Parse(Console.ReadLine());
    }

    if (idade >= 18)
    {
        maioridade++;
    }
    else
    {
        menoridade++;
    }

    contador++;

    if(contador > 10)
    {
        Console.WriteLine($"Existem {maioridade} pessoas que são MAIORES de idade e {menoridade} pessoas que são MENORES de idade.");

        Console.WriteLine("Digite S para sair do programa ou aperte qualquer tecla para repetir.");
        sair = Console.ReadLine();
        if(sair != "S" && sair != "s")
        {
            contador = 1;
            maioridade = 0;
            menoridade = 0;
            Console.Clear();
        }
    }
}

Console.ReadKey();