// Оставить последнее число из многозначного
Console.WriteLine("Введите число");
string numberA = Console.ReadLine();
int len = numberA.Length-1;
if (len > 0) {
Console.WriteLine(numberA.Remove(0, len));
}
else {
Console.WriteLine(numberA);
}




