//配列（Array)
//配列（Array)とは、{同じ型の複数の値を格納}するためのデータ構造です。
//C#では、配列は固定長であり、宣言時にサイズを指定する必要があります。
// →
//配列の要素にはインデックスを使用してアクセスできます.

Console.WriteLine("配列の例");
//[] が付くことで、「配列ですよ」とコンパイラに伝えています.
int[ ] numbers = new int[5]; // 整数型の配列を宣言し、サイズを5に設定
　//↑後から値を入れる場合
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;
//int[] numbers = { 10, 20, 30, 40, 50 };
//↑最初から値が決まっている場合
for (int i = 0; i < numbers.Length; i++)
//Lengthとは、配列の要素数を返す
{
    Console.WriteLine(numbers[i]);
}

int[] numbers0 = { 10, 20, 30, 40, 50 };
Console.WriteLine(numbers[2]);
//これは、配列の3番目の要素（インデックス2）を出力します。結果は30です。



Console.WriteLine("List");
//Listは、可変長のコレクションであり、要素の追加や削除が容易に行えます。

List<int> numberList = new List<int>(); // 整数型のListを宣言
numberList.Add(1);
numberList.Add(2);
//addとは、Listに箱の要素を追加する.[1,2]のように、Listの中に要素が入っていくイメージ

for (int i = 0; i < numberList.Count; i++)
//Countとは、Listの要素数を返す
{
    Console.WriteLine(numberList[i]);
}


Console.WriteLine("TODOリスト");
List<string> todoList = new List<string>(); // 文字列型のListを宣言
todoList.Add("タスク1");
todoList.Add("タスク2");
todoList.Add("タスク3");
todoList.Remove("タスク2");

for (int i = 0; i < todoList.Count; i++)
{
    Console.WriteLine(todoList[i]);
}

Console.WriteLine("Dictionary");
//Dictionaryは、キーと値のペアを格納するコレクションであり、キーを使用して値にアクセスできます。

Dictionary<string, int> dict = new Dictionary<string, int>();
// 文字列型のキーと整数型の値を持つDictionaryを宣言

dict.Add("りんご", 100);
dict.Add("みかん", 200);
dict.Add("バナナ", 300);

//Dictionaryを順番に表示する。
foreach (var item in dict) //foreachとは、コレクションの要素を順番に取り出すためのループ構文
                          //varとは、変数の型を自動的に推論するキーワード
                          //itemとは、Dictionaryの要素を表す変数であり、KeyとValueのプロパティを持つ
{
    Console.WriteLine($"{item.Key}: {item.Value}");
    //$とは、文字列補間を行うための構文であり、{}内の式を評価して文字列に埋め込むことができる
}


