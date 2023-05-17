// Вывод дня недели по введенному числу
string[] days = new string[7] { "понедельник", "вторник","среда","четверг","пятница","суббота","воскресенье"};
Console.WriteLine("Введите число дня недели");
int number = int.Parse(Console.ReadLine());
if (number > 7) {
    Console.WriteLine("Не верное число"); } 
else if (number < 1) {
    Console.WriteLine("Не верное число"); } 

else {
    Console.WriteLine("День недели - " + days[number-1]);
}
