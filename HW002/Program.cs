// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b=a;
int c = 0;
while (b-10>0)
{
    //Console.WriteLine(b%10);
    c=c*10+(b%10);
    //Console.WriteLine(c);
    b=b/10;
    //Console.WriteLine(b);
}
c=c*10+(b%10);
Console.WriteLine(c);
if (c==a)
{
    Console.WriteLine("да");
}
else
{
   Console.WriteLine("нет"); 
}