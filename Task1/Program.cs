// Task1
void Main()
{
    searchQuit();

}

string readNumber(string msg)
{
    System.Console.WriteLine(msg);
    return Console.ReadLine();
    
}

void searchQuit()
{
    while (true)
    {
        string input = readNumber("Введите число: ");
        if(input == "q")
        {
            break;
        }
        
        if (int.TryParse(input, out int number))
        {
            if ((number > 0) && ((number / 10 + number % 10) % 2 == 0))
            {
                break;
            }
        }
    }
}


Main();