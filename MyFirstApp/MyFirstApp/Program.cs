// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modufikacja 1");
Console.WriteLine("Modufikacja 2");
Console.WriteLine("Modufikacja 3");



static double GetAverage(int[] numbers)
{

    double sumMain = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sumMain += numbers[i];
    }

    return sumMain / numbers.Length;

}

int[] arr = {1,2,3,4,5};
double average = GetAverage(arr);
Console.WriteLine(average);
Console.WriteLine(GetMax(arr));


static int GetMax(int[] tablicaWartosci)
{
    int max = 0;
    
    if (tablicaWartosci.Length != 0)
    {
            max = tablicaWartosci[0];
            for (int i = 0; i < tablicaWartosci.Length; i++)
            {
                if (max < tablicaWartosci[i])
                {
                    max = tablicaWartosci[i];
                }
            }   
    }

    
    return max;
    

}