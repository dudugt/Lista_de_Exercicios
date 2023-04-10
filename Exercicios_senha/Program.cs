Console.Clear();
Console.WriteLine($"Vamos comecar nosso cadastero");
Thread.Sleep(2000);
Console.Clear();


Console.WriteLine($"Primeiramente infome seu nome ");
string nome = Console.ReadLine().Trim(' ').ToLower();
Thread.Sleep(1500);
Console.Clear();

Console.WriteLine($"Agora crie sua senha");
string pass = Console.ReadLine().Trim(' ').ToLower();
Thread.Sleep(1500);
Console.Clear();

while (nome == pass)
{
    Console.WriteLine($"Voce nao pode digitar a senha com o mesmo nome do seu usuario");
    Thread.Sleep(1500);
    Console.Clear();
    Console.WriteLine($"Tente novamente");
    pass = Console.ReadLine().Trim(' ');
}

Console.WriteLine($"Cadastro efetuado ");
