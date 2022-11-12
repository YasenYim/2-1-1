using System;

namespace _2_1_面向对象1
{
    class Character
    {
        public string name;
        public int hp;
        public int attack;
        public int def;

        // 在类里面写一个扣血的函数
        public void CostHp(int cost)
        {
            this.hp -= cost;
            if(this.hp <= 0)
            { this.hp = 0; }
        }
    }

    class Program
    {
        static void CostHp(Character c ,int cost)
        {
            c.hp -= cost;
            if (c.hp <= 0)
            { c.hp = 0; }
        }
        static void Main(string[] args)
        {
            // 创建两个对象并初始化
            Character c1 = new Character();
            c1.name = "汤姆";
            c1.hp = 100;
            c1.attack = 15;
            c1.def = 1;

            Character c2 = new Character();
            c2.name = "杰瑞";
            c2.hp = 10;
            c2.attack = 150;
            c2.def = 10;

            // 战斗过程
            while(c1.hp > 0 && c2.hp > 0)
            {
                int cost = c1.attack - c2.def;
                //c2.CostHp(cost);
                CostHp(c2,cost);

                Console.WriteLine($"{c1.name}攻击了{c2.name},{c2.name}损失了{cost}血量");
                Console.WriteLine($"{c2.name},hp:{c2.hp}");

                if(c2.hp <= 0)
                { break; }

                cost = c2.attack - c1.def;
                //c1.CostHp(cost);
                CostHp(c1, cost);

                Console.WriteLine($"{c2.name}攻击了{c1.name},{c1.name}损失了{cost}血量");
                Console.WriteLine($"{c1.name},hp:{c1.hp}");
            }

            // 判断胜负
            if(c1.hp <= 0)
            { Console.WriteLine($"------{c2.name}胜利！------"); }
            else
            { Console.WriteLine($"------{c1.name}胜利！------"); }
            Console.ReadKey();
        }
    }
}
