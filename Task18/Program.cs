// Задача 17:

int num = Prompt ("Введите номер четверти: ");

int Prompt (string message) {
Console.Write(message);
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

void FindCoordinate (int num) {
    if ( num == 1) {
    Console.WriteLine("I четверть X > 0, Y > 0");
    }
    if ( num == 2) {
    Console.WriteLine("II четверть X < 0 Y > 0");
    }
    if ( num == 3) {
    Console.WriteLine("III четверть X < 0 Y < 0");
    }
    if ( num == 4) {
    Console.WriteLine("IV четверть X > 0 Y < 0");
    }
    
}

if (num <1 || num >4) {

    Console.WriteLine("Введена не правильная четверть");
    }
else {
    FindCoordinate (num);
}



