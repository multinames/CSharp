﻿// Задача 21:

int Prompt (string message) {
Console.Write(message);
int num = int.Parse(Console.ReadLine()!);
return num;
}

int x1 = Prompt ("Введите координату X точки A: ");
int y1 = Prompt ("Введите координату Y точки A: ");

int x2 = Prompt ("Введите координату X точки B: ");
int y2 = Prompt ("Введите координату Y точки B: ");

void CalcDist (int x1, int y1, int x2, int y2) {
    double d = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(x1-x2));
    Console.WriteLine("Расстояние между точками: "+d);
}

CalcDist(x1, y1, x2, y2);



