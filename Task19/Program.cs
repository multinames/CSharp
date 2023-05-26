// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Prompt (string message) {
Console.Write(message);
string num = Console.ReadLine()!;

    if ((int.TryParse(num, out int num_n)) == false) {
    Console.WriteLine("Это не число!");
    Environment.Exit(0);
    }

return num_n;
}

void ReverseNumber (int num) {
    int reversed = 0 ;

    while(num !=0) {
        int r = num%10;
        reversed = reversed*10 + r ;
        num =  num/10;
        }
    Console.WriteLine (reversed);
}

int num = Prompt ("Введите число: ");

ReverseNumber(num);