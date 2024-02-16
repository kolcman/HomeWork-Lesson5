// Task 2

void Main()
{
    
    int[] arrOfNumb = new int[10];
    for (int i = 0; i < arrOfNumb.Length; i++)
    {
        arrOfNumb[i] = new Random().Next(100, 1000);
    }
    int count = 0;
    foreach (int e in arrOfNumb)
    {
        if (e % 2 == 0)
        {
            count++;
        }
    }
    System.Console.WriteLine(count);
}

Main();