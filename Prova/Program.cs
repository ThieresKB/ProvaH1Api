//função
static int Multiplicar(int num1, int num2)
{
    int soma = num1;
    if(num2 == 1)
    {
        return soma;
    }
    else
    {
        return soma + Multiplicar(num1, num2 - 1);
    }
}

//Operação
Console.WriteLine(Multiplicar(5, 5));