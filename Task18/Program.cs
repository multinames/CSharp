﻿// Задача 18:

int num = Prompt ("Введите номер четверти: ");

int Prompt (string message) {
Console.Write(message);
int num = int.Parse(Console.ReadLine()!);
return num;
}

ShowQuarter(num);

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

void ShowQuarter (int num) {

if (num <1 || num >4) {

    Console.WriteLine("Введена не правильная четверть");
    }
else {
    FindCoordinate (num);
    }
}


