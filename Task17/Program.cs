// Задача 17:

int x = Prompt ("Введите координату X: ");
int y = Prompt ("Введите координату Y: ");

int Prompt (string message) {
Console.Write(message);
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

FindCoordinate (x, y);

void FindCoordinate (int x, int y) {
    if (x >0 && y>0) {
    Console.WriteLine("I четверть");
    }
    if (x <0 && y>0) {
    Console.WriteLine("II четверть");
    }
    if (x <0 && y< 0) {
    Console.WriteLine("III четверть");
    }
    if (x >0 && y < 0) {
    Console.WriteLine("IV четверть");
    }
}
