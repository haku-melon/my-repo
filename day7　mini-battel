class Player //playerという設計図（クラスの基本構造）
{
    // データとは、オブジェクトが持つ情報のこと
    private string name;
    //privateは、外部からアクセスできないようにするための修飾子
    private int health;
    // メソッドとは、オブジェクトが持つ機能のこと

    public Player(string name, int health)//コンストラクタ
    {
        this.name = name;//「受け取った名前を、このPlayer自身のnameに保存する」
        this.health = health;
    }
    public void Attack(Player target)//攻撃するメソッド
                                     //voidは、戻り値がないことを示す
                                     //publicは、外部からアクセスできるようにするための修飾子
    {
        if (health <= 0)
        {
            Console.WriteLine($"{name}は倒れているので攻撃できない！");
            return;
        }
        Console.WriteLine($"{name}の攻撃！");
        target.TakeDamage(20);

        if (target.health <=0)
        {
            Console.WriteLine($"{name}は倒れた！");
            return;//これ以上このAttackメソッドを実行しないで終了
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Console.WriteLine($"{name}に{damage}ダメージ！");
        Console.WriteLine($"{name} HP: {health}");

        
    }

    public bool IsAlive()//生存しているかどうかを判定するメソッド
    {
        return health > 0;//HPが1以上なら true、0以下なら false を返す
    }
   
}
/*
 Player
├─ name
├─ health
├─ Player() ← コンストラクタ
├─ Attack()
└─ TakeDamage()


 Program
└─ Main()
   ├─ player1を作る
   ├─ player2を作る
   ├─ player1がplayer2を攻撃
   └─ player2がplayer1を攻撃

*/


class Program//プログラムの実行開始点
{    /*player1という設計図（クラスの基本構造）をもとに、実体化したもの（インスタンス）を作る
     player1.name = "勇者";　はできない。nameはprivateだから。
    そこで、コンストラクタを使う。コンストラクタは、クラスの名前と同じ名前のメソッドで、オブジェクトが生成されるときに呼び出される。
    */

    static void Main(string[] args)/*staticは、クラスに属するメソッドであることを示す。
                                    Mainは、プログラムの実行開始点であることを示す。
                                    string[] argsは、コマンドライン引数を受け取るための引数である。*/

    {
        Player player1 = new Player("勇者", 100);
        Player player2 = new Player("魔法使い", 80);

        while (player1.IsAlive() && player2.IsAlive())//勇者も生きていて、魔法使いも生きている間
        {
            player1.Attack(player2);

            if (!player2.IsAlive())//!は、論理否定演算子。trueをfalseに、falseをtrueに変える。つまり魔法使いが生きていない。
            {
                break;
            }

            player2.Attack(player1);
        }

        Console.WriteLine("=== バトル終了 ===");
        
        if (player1.IsAlive() && player2.IsAlive())
        {
            Console.WriteLine("引き分け！");
        }
        else if (player1.IsAlive())
        {
            Console.WriteLine("勇者の勝利！");
        }
        else
        {
            Console.WriteLine("魔法使いの勝利！");
        }
        
    }
}


//=== MINI BATTLE ===

//勇者 HP: 100
//魔法使い HP: 80

//勇者の攻撃！
//魔法使いに20ダメージ！

//魔法使い HP: 60





