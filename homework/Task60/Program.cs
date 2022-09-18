// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int [,,] FillArray3D(int [,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j =0; j < array3D.GetLength(1); j++)
        {
            for (int k =0; k < array3D.GetLength(2); k++)
            {   
                int count = 0;
                while(count < array3D.GetLength(0))
                {
                    int digit = new Random().Next(10, 100);
                    if (CheckNonRepeatingNumbers(array3D, digit))
                    {
                        array3D[i, j, k] = digit;
                        count++;
                    }
                }
            }
        }
    }

    return array3D;
}


void PrintArray3D(int [,,] array, int indexPrint)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j =0; j < array.GetLength(1); j++)
        {
            for (int k =0; k < array.GetLength(2); k++)
            {
                if (indexPrint == 0) Console.Write(array[i, j ,k] + "\t ");
                else  Console.Write($"{array[i, j ,k]}({i},{j},{k}) ");
            }

            Console.WriteLine();
        }
       
        //Console.WriteLine();
    }
}


void PrintArray3D2 (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}


bool CheckNonRepeatingNumbers(int[,,] array3D, int num)
{
    bool result = true;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j =0; j < array3D.GetLength(1); j++)
        {
            for (int k =0; k < array3D.GetLength(2); k++)
            {
                if (array3D[i, j ,k] == num) 
                {
                    result = false;
                }
            }
        }
    }

    return result;
}


int[,,] array3D = new int[2, 2, 2];

FillArray3D(array3D);

Console.WriteLine($"Создан массив размером {array3D.GetLength(0)} x {array3D.GetLength(0)} x {array3D.GetLength(0)}:");
PrintArray3D(array3D, 0);

Console.WriteLine("\nВывод построчно массива, добавляя индексы каждого элемента:");
PrintArray3D(array3D, 1);

Console.WriteLine("\nВывод построчно массива, добавляя индексы каждого элемента (вариант2):");
PrintArray3D2(array3D);
