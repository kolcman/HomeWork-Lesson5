// Task3

// Быстро.
Array arrayOfNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Array.Reverse(arrayOfNumbers);
foreach(int e in arrayOfNumbers)
{
    System.Console.Write($"{e} ");
}

// Не Быстро

// for (int i = 0; i < arrayOfNumbers.Length / 2; i++)
// {
// temp = arrayOfNumbers[i];
// arrayOfNumbers[i] = arrayOfNumbers[arrayOfNumbers.Length - 1 - i];
// arrayOfNumbers[arrayOfNumbers.Length - 1 - i] = temp;
// }

