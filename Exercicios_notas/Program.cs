Console.WriteLine($"Vamos fazer a validacao das notas dos alunos");

Console.WriteLine($"Digite a nota do aluno entre 0 ate 10");
float nota =float.Parse(Console.ReadLine());

    while (nota > 10 || nota < 0)
    {
        Console.WriteLine($"Este numero esta invalido");
        Console.WriteLine($"Por gentileza somete do o ao 10");
        Console.WriteLine($"Digite novamente");
        nota =float.Parse(Console.ReadLine());

    }

Console.WriteLine($"A nota esta validada e colocada no nosso sistema");
