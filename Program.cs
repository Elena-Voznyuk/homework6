// Задача 41
/*int [] CreatNewArray (int size)
{
int [] array = new int[size];
   for (int i = 0; i < size; i++)
       array[i] = Convert.ToInt32(Console.ReadLine());
   return array;      
}
void ShowArray (int [] array1)
{
   for (int i = 0; i < array1.Length; i++)
       Console.Write(array1[i] + " ");
       Console.WriteLine();
}
void CountOfPositiveNumbers (int [] array2)
{
   int result = 0;
   for (int i = 0; i < array2.Length; i++)
        if (array2[i] > 0)
         result ++;
   Console.WriteLine($"Count of positive numbers is {result}");
}

Console.WriteLine("Input numbers:");
int numbersOfArray = Convert.ToInt32(Console.ReadLine());
int [] userArray = CreatNewArray(numbersOfArray);     
ShowArray(userArray);
CountOfPositiveNumbers(userArray);*/


// Задача 43
/*double [] IntersectionPointOfStraights (double b1, double k1, double b2, double k2)
{
   double x = (b2 - b1) / (k1 - k2);
   double y = k1 * x + b1;
   double [] array =  new double [2];
   array [0] = x;
   array [1] = y;
   return array;
}

void ShowArray (double [] array1)
{
   for (int i = 0; i < array1.Length; i++)
       Console.Write(array1[i] + " ");
       Console.WriteLine();
}


Console.WriteLine("Input first coordinate of point A:");
double firstcoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second coordinate of point A:");
double secondcoorrdA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input first coordinate of point B:");
double firstcoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second coordinate of point B:");
double secondcoorrdB = Convert.ToInt32(Console.ReadLine());
double [] arrayCoord = IntersectionPointOfStraights(firstcoordA, secondcoorrdA, firstcoordB, secondcoorrdB);
ShowArray(arrayCoord);*/