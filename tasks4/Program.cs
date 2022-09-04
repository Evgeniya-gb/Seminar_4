// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int Exponentiation(int numA, int numB){
 int result = 1;
 for(int i=1; i <= numB; i++){
 result = result * numA;
  }

 return result;
}

 Console.Write("Введите число A: ");
 int numA = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите число B: ");
 int numB = Convert.ToInt32(Console.ReadLine());

 int exponentiation = Exponentiation(numA, numB);
 Console.WriteLine("Ответ: " + exponentiation);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

using System;
namespace Example {
class Program {
static void Main() {
Console.Write("Введите число: ");
string num = Console.ReadLine();
ushort sum = 0;
bool point = true;
char symbol;
for (int i = 0; i < num.Length; ++i) {
symbol = num[i];
if (i == 0 && symbol == '-' || symbol == '+') continue;
if (point && symbol == '.') {
point = false;
continue;
}
if (Char.IsDigit(symbol)) sum += Convert.ToUInt16(symbol.ToString());
else break;
}
Console.WriteLine("Ответ = " + sum);
Console.ReadKey();
}
}
}


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Введите числа, разделенные запятой : ");
string? Numbers = Console.ReadLine();

Numbers = Numbers + ","; 

string RemovingSpaces (string series){
 string seriesNew = "";
 for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}
 
void СheckNumber2 (int series){

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода. Введите цифры.");

      }
}

int[] Array_Of_Numbers(string seriesNew){ 

  int[] array_Of_Numbers = new int[1];

  int j =0;

  for (int i = 0; i < seriesNew.Length; i++){
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length){
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    array_Of_Numbers[j] = Convert.ToInt32(seriesNew1);
    if (i < seriesNew.Length-1){
      array_Of_Numbers = array_Of_Numbers.Concat(new int[] {0}).ToArray();
    }
    j++;
  }
  return array_Of_Numbers;
}

void PrintArray(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

string seriesNew = RemovingSpaces(Numbers);

int[] array_Of_Numbers =  Array_Of_Numbers(seriesNew);

PrintArray(array_Of_Numbers);
