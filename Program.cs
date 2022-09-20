int firstNumber = GetNumberFromUser(1);
int secondNumber = GetNumberFromUser(2);
int result = 0;

while (secondNumber >= 1)
{
    Console.WriteLine($"{firstNumber}  {secondNumber}", firstNumber); //0, -11
    if (secondNumber % 2 == 1)
    {
        result += firstNumber;
    }
    firstNumber *= 2;
    secondNumber /= 2;
}

Console.WriteLine($"Result : {result}");

int GetNumberFromUser(byte count)
{
    int number;
    string value;

    do
    {
        Console.Write($"{count}. Sayı : ");
        value = Console.ReadLine();
    } while (!int.TryParse(value, out number) || number < 1);


    return number;
}
