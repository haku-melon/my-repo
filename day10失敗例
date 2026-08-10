//class: クラスは、オブジェクト指向プログラミングにおける基本的な構造であり、データ（フィールド）と動作（メソッド）をまとめたものです。
//クラスは、オブジェクトの設計図として機能し、インスタンス化することで具体的なオブジェクトを生成できます。
using System.Xml.Linq;

class Character
{
    //protected: そのクラス自身と、そのクラスを継承した子クラスからアクセスできる
    protected string name;
    protected int health;

    //コンストラクタ: クラスのインスタンスが生成されるときに呼び出される特殊なメソッドで、オブジェクトの初期化を行う。
    public Character(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Console.WriteLine($"{name}に{damage}ダメージ！");
    }

    public bool IsAlive()
    {
        return health > 0;
    }

}





class Player : Character;


//interface: クラスの設計図のようなもの。メソッドの定義だけを持つことができる。クラスは複数のインターフェースを実装できる。
interface IDamageable
{
    //IDamageableを実装するクラスは、TakeDamage()を持つ。

    void TakeDamage(int damage);


}







