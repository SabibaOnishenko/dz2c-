// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int ShowNumber (){
    int first = num/100;
    int third = num%10;
    return (num-(first*100+third))/10;
    
}
Console.WriteLine(ShowNumber());

