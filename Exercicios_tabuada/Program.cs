
Console.WriteLine($"Seja bem-vindo(a)  a nossa tabuada on line");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine($"Qual numero voce quer que efetue a tabuada");
float num = float.Parse(Console.ReadLine());

float contador, form;

for (contador = 1; contador <= 10; ++contador)
{
    form = num * contador;
    Console.WriteLine($"{num} X {contador} = {form}");
    
}


