// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberС = Convert.ToInt32(Console.ReadLine());
int max_num = numberA; // объявлеям максимальную пременную

if (max_num < numberB) {
    max_num = numberB ;
    }
else if (max_num < numberС) {
    max_num = numberС ;
    
}

Console.WriteLine("Максимальное число из трех "+ max_num);




    
