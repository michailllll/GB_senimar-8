//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.WriteLine("введите количество строк матрицы ");
// int quantityString = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите количество столбцов матрицы ");
// int quantityColumn = Convert.ToInt32(Console.ReadLine());


// void Printarray(double[,]matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//         Console.WriteLine();
//     }

// }


// void Fillarray(double[,]matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(-10,10);
//         }
//     }

// }


// double[,] matrix = new double[quantityString,quantityColumn];

// Fillarray(matrix);
// Printarray(matrix);

// Console.WriteLine("------------------");

// SortArray(matrix);
// Printarray(matrix);

// void SortArray(double[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           double temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

//  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.WriteLine("введите количество строк матрицы ");
// int quantityString = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите количество столбцов матрицы ");
// int quantityColumn = Convert.ToInt32(Console.ReadLine());


// void Printarray(double[,]matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//         Console.WriteLine();
//     }

// }


// void Fillarray(double[,]matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(0,10);
//         }
//     }

// }


// double[,] matrix = new double[quantityString,quantityColumn];

// Fillarray(matrix);
// Printarray(matrix);



// double SumElements(double[,] array, int i)
// {
//   double sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// int minSum = 0;
// double sumLine = SumElements(matrix, 0);
// for (int i = 1; i < matrix.GetLength(0); i++)
// {
//   double tempSum = SumElements(matrix, i);
//   if (sumLine > tempSum)
//   {
//     sumLine = tempSum;
//     minSum = i;
//   }
// }

// Console.WriteLine($"\n{minSum+1}");

// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матри

// Console.WriteLine("введите количество строк матрицы 1 ");
// int quantityString_1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите количество столбцов матрицы 1 ");
// int quantityColumn_1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите количество строк матрицы 1 ");
// int quantityString_2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите количество столбцов матрицы 1 ");
// int quantityColumn_2 = Convert.ToInt32(Console.ReadLine());



// void Printarray(double[,]matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i,j]} ");
//         }
//         Console.WriteLine();
//     }

// }


// void Fillarray(double[,]matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for(int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(-10,10);
//         }
//     }

// }

// void MultiplyArray(double[,] firstMartrix, double[,] secomdMartrix, double[,] resultArray)
// {
//   for (int i = 0; i < resultArray.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultArray.GetLength(1); j++)
//     {
//       double sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultArray[i,j] = sum;
//     }
//   }
// }


// if(quantityColumn_1 != quantityString_2)
// {
//     Console.WriteLine("матрицы нельзя умножить");
// }
// else
// {
// double[,] matrix_1= new double[quantityString_1,quantityColumn_1];

// Fillarray(matrix_1);
// Printarray(matrix_1);
// Console.WriteLine("----------------");

// double[,] matrix_2= new double[quantityString_2,quantityColumn_2];

// Fillarray(matrix_2);
// Printarray(matrix_2);
// Console.WriteLine("----------------");


// double[,] resultArray = new double[quantityString_1,quantityColumn_2];

// MultiplyArray(matrix_1, matrix_2, resultArray);

// Printarray(resultArray);

// }


// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


// void FillArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }

// void PrintArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       Console.Write($"X({i}) Y({j}) ");
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $"Z({k})={array3D[i,j,k]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }



// Console.WriteLine("введите x ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите y ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите z ");
// int z = Convert.ToInt32(Console.ReadLine());

// int[,,] matrix3D = new int[x,y,z];

// FillArray(matrix3D);
// PrintArray(matrix3D);

// Console.WriteLine("Введите размеры массива через пробел: ");
// string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]), }, 10, 99);
// PrintArray(array);

// int[,,] GetArray(int[] sizes, int min, int max)
// {
//     int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             int k = 0;
//             while (k < result.GetLength(2))
//             {
//                 int element = new Random().Next(min, max + 1);
//                 if (FindElement(result, element)) continue;
//                 result[i, j, k] = element;
//                 k++;
//             }
//         }
//     }
//     return result;
// }


//         bool FindElement(int[,,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == el) return true;
//             }
//         }
//     }
//     return false;
// }
// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
//             }
//             Console.WriteLine();

//             Console.ReadKey();
//         }
//     }
// }


// Задача 62: Заполните спирально массив 4 на 4.

int x = 4;

int [,] array = new int[x,x];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= array.GetLength(0) * array.GetLength(1))
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(array);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}