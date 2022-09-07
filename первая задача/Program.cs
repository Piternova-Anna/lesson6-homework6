// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите количество вводимых значений: ");
int QuanNums = int.Parse(Console.ReadLine());
if (QuanNums>=0)
{
    int QuanPozitivNums=0;
 for (int count = 1; count <=QuanNums ;  count++)
 {
    Console.Write("Введите "+count+" число: ");
    int Num = int.Parse(Console.ReadLine());
    QuanPozitivNums+=Num<0?1:0;
 }

 Console.WriteLine("отрицательных чисел: " + QuanPozitivNums);
  
}
else
{
    Console.WriteLine("количество вводимых чисел должно быть больше 0");
}
