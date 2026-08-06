using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
Console.WriteLine("何歳ですか。");


//if / else if / else
Console.Write("年齢を入力: ");
int age = int.Parse(Console.ReadLine());
if (age <= 12) Console.WriteLine("子ども");
else if (age <= 17) Console.WriteLine("学生");
else Console.WriteLine("大人");


//forループ
Console.WriteLine("forループ");
int sum = 0;//合計を格納する変数
for (int i = 1; i <= 100; i++)//1から100までの合計を計算
{
    sum += i;
}
Console.WriteLine($"1から100までの合計: {sum}");


//while
Console.WriteLine("whileループ");


while (true)
{
    Console.WriteLine("特定の文字を入力すると終了します。");
    string input = Console.ReadLine();
    Console.WriteLine($"入力された文字: {input}");
    if (input == "exit")
    {
        break;
    }
   
}
Console.WriteLine("終了します");


// FizzBuzz
//  3の倍数 → Fizz
//  5の倍数 → Buzz
//  両方の倍数 → FizzBuzz
//   それ以外 → 数字

Console.WriteLine("FizzBuzz問題");

for (int i = 1; i <= 15; i++)
{

    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    //両方の倍数
    //最初に両方の倍数を判定する必要がある（より大きな条件を先に判定する）
    //上の書き方がセオリー
    
    
   //Console.WriteLine("Fizz");
   //Console.WriteLine("3の倍数でした");
   //のように処理を増やしたくなったとき、{ }があると簡単に追加できるから。


    else if (i % 3 == 0) 
        Console.WriteLine("Fizz");//3の倍数
    else if (i % 5 == 0) 
        Console.WriteLine("Buzz");//5の倍数
    else 
        Console.WriteLine(i);
}

