string answer = "";

do
{
    Random random = new Random();
    int secretNumber = random.Next(1, 100);

    int userGuess = 0;
    int attempts = 0;
    int maxAttempts = 7;
    bool Win = false;

    Console.WriteLine($"Я загодал число от 0 до 100! Попробуй отгадай! У тебя есть: {maxAttempts} попыток!");

    while (attempts < maxAttempts)
    {
        Console.WriteLine($"Попытка {attempts + 1} из {maxAttempts} Ваша догадка: ");
        string input = Console.ReadLine();
        if (input == "")
        {
            Console.WriteLine("Ошибка! Вы ввели не число. Попробуйте еще раз.");
            continue;
        }

        bool isNumber = true;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] < '0' || input[i] > '9')
            {
                isNumber = false;
                break;
            }
        }

        if (isNumber == false)
        {
            Console.WriteLine("Ошибка! Вы ввели не число. Попробуйте еще раз.");
            continue;
        }

        userGuess = Convert.ToInt32(Console.ReadLine());
        attempts++;

        if (userGuess < secretNumber)
        {
            Console.WriteLine("Загаданное число больше!");
        }
        else if (userGuess > secretNumber)
        {
            Console.WriteLine("Загаданное число меньше!");
        }
        else
        {
            Win = true;
            break;
        }
    }

    if (Win)
    {
        Console.WriteLine($"\nПоздравляю! Вы выиграли! Отгадали число {secretNumber} за {attempts} попыток.");
    }
    else
    {
        Console.WriteLine($"\nВы проиграли! Попытки закончились. Было загадано число: {secretNumber}");
    }
    Console.WriteLine("\nМожет ещё партейку? (да/yes)");

    answer = Console.ReadLine();

} while (answer == "да" || answer == "yes" || answer == "Да" || answer == "Yes");
{
    Console.WriteLine("\nСпасибо за игру! Нажмите Enter для завершения программы!");
    Console.ReadLine();
}