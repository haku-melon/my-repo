interface IDamageable
{
    void TakeDamage(int damage);
}

class Character : IDamageable
{
    protected string name;
    protected int health;

    public Character(string name, int health)
    {
        this.name = name;
        this.health = health;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        Console.WriteLine($"{GetName()}に{damage}ダメージ！");
        Console.WriteLine($"{GetName()} HP: {health}");

        if (health <= 0)
        {
            Console.WriteLine($"{GetName()}は倒れた！");
        }
    }

    public bool IsAlive()
    {
        return health > 0;
    }

    public string GetName()
    {
        return name;
    }
}

class Player : Character
{
    public Player(string name, int health)
        : base(name, health)
    {
    }

    public void Attack(Character target)
    {
        if (!IsAlive())
        {
            Console.WriteLine($"{GetName()}は倒れているので攻撃できない！");
            return;
        }

        Console.WriteLine($"{GetName()}の攻撃！");
        target.TakeDamage(20);
    }
}

class Enemy : Character
{
    public Enemy(string name, int health)
        : base(name, health)
    {
    }

    public void Attack(Character target)
    {
        if (!IsAlive())
        {
            Console.WriteLine($"{GetName()}は倒れているので攻撃できない！");
            return;
        }

        Console.WriteLine($"{GetName()}の攻撃！");
        target.TakeDamage(20);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("勇者", 100);
        Enemy enemy = new Enemy("スライム", 50);

        while (player.IsAlive() && enemy.IsAlive())
        {
            player.Attack(enemy);

            if (enemy.IsAlive())
            {
                enemy.Attack(player);
            }
        }

        Console.WriteLine("=== バトル終了 ===");

        if (!player.IsAlive())
        {
            Console.WriteLine($"{player.GetName()}の敗北！");
        }
        else
        {
            Console.WriteLine($"{player.GetName()}の勝利！");
        }
    }
}