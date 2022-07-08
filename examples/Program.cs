//int squareNumber = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (squareNumber == number * number)
//{
//   Console.WriteLine("Число " +squareNumber + " является квадратом " + number );
//}
//else
//{
//    Console.WriteLine("Число " +squareNumber  + " НЕявляется квадратом " + number );
//}
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * (-1);

while (negativeN <= N)
{
     Console.WriteLine(negativeN);
    negativeN++;
}




