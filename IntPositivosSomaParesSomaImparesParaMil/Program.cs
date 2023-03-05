//List<int> pairNumber = new List<int>();
//List<int> oddNumber = new List<int>();
//int n;
//do
//{
//    Console.WriteLine("Digite um numero entre 1 e 999");
//    if (!int.TryParse(Console.ReadLine(), out n))
//    {
//        Console.WriteLine("Precisa ser Inteiro");
//    }
//    else
//    {
//        if (n < 0 || n >=1000)
//        {
//            Console.WriteLine("Precisa ser positivo e até 999!");
//        }
//        else
//        {            
//            if (n % 2 == 0)
//            {
//                pairNumber.Add(n);
//                Console.Clear();
//            }
//            else
//            {
//                oddNumber.Add(n);
//                Console.Clear();
//            }            
//        }
//    }
//}
//while (n < 1000);
//int pairSum = pairNumber.Sum();
//int oddSum = oddNumber.Sum();

//Console.WriteLine("A soma dos pares é: {0}\n" +
//    "A soma dos ímpares é: {1}", pairSum, oddSum);
//Console.WriteLine("Exiting Program...");

int num, somaPar = 0, somaImpar = 0;

RecebeNumerosParaSeMil();
RespondeUsuario();

void RecebeNumerosParaSeMil()
{
    do
    {
        RecebeValoresDoUsuario();
        VerificaNum();

    } while (num < 1000);
}
void RecebeValoresDoUsuario()
{
    Console.WriteLine("Informe um número entre 0 e 999");
    num = int.Parse(Console.ReadLine());
}
void VerificaNum()
{
    if ((num < 1000) && (num > 0))
    {
        if (num % 2 == 0)
        {
            somaPar += num;
        }
        else
        {
            somaImpar += num;
        }
    }
}
void RespondeUsuario()
{
    Console.WriteLine("Soma dos pares: {0}\n" +
    "Soma dos impares: {1}", somaPar, somaImpar);
}