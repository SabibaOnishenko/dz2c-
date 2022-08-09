// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int ShowNumber (){
    int first = num/100;
    int third = num%10;
    return (num-(first*100+third))/10;
    
}
Console.WriteLine(ShowNumber());


//Console.WriteLine($"введите трехзначное число {num}");
//int ShowNumber (int num1) //{
//int firstSymbol = num / 100;
    //int thirdSymbol = num %100;
    //int Newnum1= firstSymbol*10+thirdSymbol;
     //return (num - Newnum1);
//}//Console.WriteLine (ShowNumber(num));


//int ShowNumber (){
   // int num = new Random().Next(100,999);
    //int first = num/100;
   // int third = num%10;
   // return first*10+third;
    //}
//Console.WriteLine(ShowNumber());