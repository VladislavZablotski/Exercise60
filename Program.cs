int[,,] array = new int[2,2,2];
for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i,j,k]=new Random().Next(0,10);
      }
   }
}
Console.WriteLine("Массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      for (int k = 0; k < array.GetLength(2); k++)
      {
         Console.Write(array[j,k,i]+$" ({j}, {k}, {i}) ");
      }
   Console.WriteLine();   
   }
}