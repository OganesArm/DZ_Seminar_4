//Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.(в примере показаны два разных массива, создаем именно для 8 элементов)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

Console.Clear();
int [] array = new int [8];
int [] NewArray(int[]Num) {
for  (int i=0; i<Num.Length; i++)  
{
    Num [i] = new Random().Next(1, 20);
     Console.Write(array[i]+" ");
}
return Num;
}
NewArray(array);