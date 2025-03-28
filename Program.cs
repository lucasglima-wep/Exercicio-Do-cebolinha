Console.Clear();
string cliente;
// frase do cebolinha
Console.WriteLine("ola eu sou o Cebolinha, hoje eu quelo que escleva uma flase:  ");
Console.WriteLine();
// frase do cliente
cliente= Console.ReadLine()! .Replace("r","l") .ToUpper();
Console.WriteLine("=======================================================");
//frase do cliente 
Console.ForegroundColor =ConsoleColor.Blue;
Console.WriteLine($"// {cliente} //");
Console.ResetColor();
Console.WriteLine();


