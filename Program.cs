//Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
int rowsArray = ImpytUsetNumber("введите колличество строк ");
int columnsArray = ImpytUsetNumber("введите колличество столбцов ");
double[,] arrayOfRandomNumbers = ArrayOfRandomNun(rowsArray, columnsArray);
PrintArray(arrayOfRandomNumbers);
double [ , ] ArrayOfRandomNun( int rows, int columns)
{
    double[ , ] arrayRandom = new double[rows, columns];
    for (int i = 0; i < arrayRandom.GetLength(0); i ++)
    {
        for (int j = 0; j < arrayRandom.GetLength(1); j ++)
        {    
            arrayRandom[i, j] = (double)(new Random().Next(-999, 1000))/10;    
        }
    }
    return arrayRandom;
}
void PrintArray(double[,] arrayImput)
{
   for (int i = 0; i < arrayImput.GetLength(0); i ++)
    {
    System.Console.Write("[");
    for (int j = 0; j < arrayImput.GetLength(1); j ++)
    {
        System.Console.Write("{0}", arrayImput[i, j]);
        if (j != (arrayImput.GetLength(1) -1))
        {
            System.Console.Write("\t ");
        }
    }
    System.Console.WriteLine("]");
    }
}    
int ImpytUsetNumber(string message)
{
    do
    {
        System.Console.Write(message + " => ");
        bool numberCorrect = int.TryParse(Console.ReadLine(), out int userImhut);
        if (numberCorrect)
        {
            return userImhut;        
        }
         else
        {
        System.Console.WriteLine("не праильный ввод");
        }
    
    }
    while(true);
}    
