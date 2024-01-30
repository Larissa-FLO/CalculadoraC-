
Console.WriteLine("Digite um número");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite outro número");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Escolha uma operação: + - * /");
string operacao = Console.ReadLine();

switch (operacao)
{
    case "+":
        Console.WriteLine(num1 + num2);
        break;
    case "-":
        Console.WriteLine(num1 - num2);
        break;
    case "*":
        Console.WriteLine(num1 * num2);
        break;
    case "/":
        if (num2 != 0)
            Console.WriteLine(num1 / num2);
        break;
    default:
        Console.WriteLine("Não é possível realizar a operação");
        break;
}
