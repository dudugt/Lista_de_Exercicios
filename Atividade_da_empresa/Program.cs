Console.Clear();
Console.WriteLine($"Bem vindo a pesquisa da minha STARTUP");
Thread.Sleep(2000);

Console.WriteLine($"Vamos comecar ");

int perg;
char sexo;
string resp;
int sim = 0;
int nao = 0;
int mulherS = 0;
int homemN = 0;
int homem = 0;


for (perg = 1; perg < 11; perg++)
{
    Console.WriteLine($"Qual o seu sexo");
    Console.WriteLine($"Sendo que use 'M' para masculino");
    Console.WriteLine($"Sendo 'F' para feminino");
    sexo = char.Parse(Console.ReadLine().ToLower().Trim(' '));

    while (sexo != 'm' && sexo != 'f')
    {
        Console.WriteLine($"Incorreto digite novamente");
        sexo = char.Parse(Console.ReadLine().ToLower().Trim(' '));
    }

    Console.WriteLine($"Agora infome se voce gosto do nosso primeiro produto ");
    Console.WriteLine($"use somente 'SIM' e 'NAO'.");
    resp = Console.ReadLine().ToLower().Trim(' ');

    while (resp != "sim" && resp != "nao")
    {
        Console.WriteLine($"Incorreto digite novamente");
        resp = Console.ReadLine().ToLower().Trim(' ');
    }

    if (resp == "sim")
    {
        sim++;
    }

    else 
    {
        nao++;
    }

    if (sexo == 'f' && resp == "sim")
    {
        mulherS++;
    }

    else if (sexo == 'm' && resp == "nao")
    {
        homemN++;
    }

    if (sexo == 'm')
    {
        homem++;
    }
    Console.Clear();
}


Console.WriteLine($"O numero de pessoas que respoderam sim foi {sim}");
Console.WriteLine($"O numero de pessoas que respoderam nao foi {nao}");
Console.WriteLine($"O numero de mulheres que responderam sim foi {mulherS}");
Console.WriteLine($"A porcentagem de Homens que responderam 'NAO' foi {(homemN *100)/ 10}%");
Console.WriteLine($"E os homens anlisados foram {homem}");






