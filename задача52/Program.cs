// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
int rowsArray = ImpytUsetNumber("введите первое значение ");
int columnsArray = ImpytUsetNumber("введите второе значение ");
int[,] arrayOfRandomNumbers = ArrayOfRandomNun(3, 4);
PrintArray(arrayOfRandomNumbers);
double[] sumArray = SumArrayOfColumns(arrayOfRandomNumbers);
PrintArray(sumArray);
double ImpytUsetNumber(string message)
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
        System.Console.WriteLine("не правильный ввод");
        }
    
    }
    while(true);
}    
int[,] ArrayOfRandomNun( int rows, int columns)
{
    int[,] arrayRandom = new int [rows, columns];
    for (int i = 0; i < arrayRandom.GetLength(0); i ++)
    {
        for (int j = 0; j < arrayRandom.GetLength(1); j ++)
        {    
            arrayRandom[i, j] = (int)(new Random().Next(-999, 1000))/10;    
        }
    }
    return arrayRandom;
}    
void PrintArray(int[,] arrayImput)
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
double[] SumArrayOfColumns(int [,]arrayImput);
double[] sumArray = new double [arrayImput.GetLength(1)];
 for (int i = 0; i < arrayImput.GetLength(0); i ++)
    {
      for (int j = 0; j < arrayImput.GetLength(1); j ++)
      {
        sumArray[i] += arrayImput[i, j];
      }
    }
  for (int i = 0; i < sumArray.GetLength(0); i ++) 
  {
    sumArray[i] /= arrayImput.GetLength(0);
  } 
  return sumArray;
 void PrintArray(double[,] arrayImput) 
 {
    System.Console.Write("=> ");
    for (int i = 0; i < arrayImput.Length; i ++)
    {
        System.Console.Write($" {arrayImput[i]:f2}");
        if (i< (arrayImput.Length-1))
        {
            System.Console.WriteLine("\t ");
        }
    }
    System.Console.WriteLine(" ");
 }
