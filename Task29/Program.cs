// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


void ToAddInArray (int num_a) {
    
    int[] anum = new int[num_a];
    Random randNum = new Random();

    for(int i = 0; i < anum.Length; i++ ) {
            anum[i]=randNum.Next(10);
           }
    Console.WriteLine(string.Join(" ",anum));

}

ToAddInArray(8);