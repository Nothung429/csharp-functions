// See https://aka.ms/new-console-template for more information

int[] userArray = { 2, 6, 7, 5, 3, 9 };

//1
int StampaArray(int[] array)
{
    Console.WriteLine("\n [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}, ");
    };
    Console.WriteLine("] \n");

    return array[array.Length - 1];
}

Console.WriteLine(StampaArray(userArray));

//2
int Quadrato(int numero)
{
    int square = (int)Math.Pow(numero, 2);
    return square;
}

int numeroProva = 3;
Console.Write(Quadrato(numeroProva));

//3
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = (int)Math.Pow(array[i], 2);
    }
    return result;
}

Console.Write(StampaArray(ElevaArrayAlQuadrato(userArray)));

//4
int sommaElementiArray(int[] array)
{
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
       somma += array[i];
    }
    return somma;
}

Console.Write(sommaElementiArray(userArray));