// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

const string texto = @"Oi família!
A partir de hoje vocês poderão me chamar pelo nome.
Sei que devem estar ansiosos pela minha chegada.
Mas peço um pouco de calma, pois estou me formando no ventre da mamãe!
Já vou avisando que darei um trabalhinho...
Vou bagunçar a casa da vovó e do vovô...
Mas por outro lado vou arrancar muitos sorrisos!
Ah, já estava esquecendo... revelar meu nome.
Papai queria Reverton ou Lucas Jr.
Mamãe queria Joaquim.
Quase me chamei Pedro...
Mas sou o ";

const string nome = "HUGO!";

Console.Clear();
System.Threading.Thread.Sleep(1500);


foreach (var linha in texto.Split("\n"))
{
    char[] b = new char[linha.Length];
    for (int i = 0; i < b.Length; i++)
    {
        Console.Write(linha[i]);
        System.Threading.Thread.Sleep(40);
    }
    System.Threading.Thread.Sleep(1100);
    Console.WriteLine();
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine();
System.Threading.Thread.Sleep(1100);

WriteTrace();

foreach (var letraNome in nome.ToArray())
{
    Console.Write(letraNome);
    System.Threading.Thread.Sleep(200);
    Console.Write(" ");
    System.Threading.Thread.Sleep(600);
}

WriteTrace();

System.Threading.Thread.Sleep(4000);

Console.ResetColor();

for (int i = 0; i < 8; i++)
{
    Console.WriteLine();
}

Console.WriteLine(" Vídeo Produzido pelo Nerd do papai.");
System.Threading.Thread.Sleep(10000);
Console.ReadLine();


static void WriteTrace()
{
    Console.Write(" ");
    System.Threading.Thread.Sleep(200);
    Console.Write(" - ");
    System.Threading.Thread.Sleep(200);
    Console.Write("  ");
    System.Threading.Thread.Sleep(600);
}
