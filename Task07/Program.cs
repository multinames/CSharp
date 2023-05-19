// Вывод всех целых числе из диапазона
Console.WriteLine("Введите число");

int numberA = int.Parse(Console.ReadLine());
int numberB = numberA*-1;

if (numberA > 0 ) {
Console.WriteLine("Все целые числа:");
for (int i  = numberB;i < numberA+1; i++) {

    Console.WriteLine(i);
}
 }
else {
Console.WriteLine("Все целые числа:");
for (int i  = numberA;i < numberB+1; i++) {

    Console.WriteLine(i);
    }
}

    
