// task 66: Input numbers M and N. Write a progremm, which finds the sum of elements between M and N 
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int GetNumberM(string message)
{
    Console.WriteLine(message);
    int M = int.Parse(Console.ReadLine()!);
    return M;
}
int numberM =GetNumberM("input number M:"); 

int GetNumberN(string message)
{
    Console.WriteLine(message);
    int N = int.Parse(Console.ReadLine()!);
    return N;
}
int numberN =GetNumberN("input number N:"); 

int GetPositiveNumbersSum (int numberM, int numberN)
{
    while (numberM<0)
    {
        numberM++;
    }
    if (numberM>numberN) return 0;
    else
    return numberM+GetPositiveNumbersSum(numberM+1, numberN);    
}
int Sum = GetPositiveNumbersSum(numberM, numberN);
Console.WriteLine($"The sum of positive elements from {numberM} to {numberN} is {Sum}");