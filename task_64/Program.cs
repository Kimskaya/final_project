//task 64: Input N. Write a program, which outputs all positive numbers from N to M
//Use recussion
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNumberFromUser(string message)
{
    Console.WriteLine(message);
    int userNumber = int.Parse(Console.ReadLine()!);
    return userNumber;
}
int N =GetNumberFromUser("input any number:"); 
  

void OutputNumbersFromNtoOne(int N)  
    { 
        if (N == 0) return;
        else
        Console.Write($"{N} ");

        OutputNumbersFromNtoOne(N - 1);  
    } 
OutputNumbersFromNtoOne(N);





