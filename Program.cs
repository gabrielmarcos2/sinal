int numero;

Console.Write("digite um numero ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero < 0)
{
    Console.WriteLine("Negativo");
}
else if (numero > 0)
{
    Console.WriteLine("positivo");
}
else
{
    Console.WriteLine("zero");
}