Console.WriteLine("введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput); // метод Parse что делает? преобразует строку в число
int result = userNumber * userNumber;
Console.WriteLine($"{userNumber} -> {result}"); // интерполяция строк выводит переменые в числа ($)


