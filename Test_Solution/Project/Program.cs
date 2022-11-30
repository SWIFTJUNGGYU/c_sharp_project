
// 상속(Class 기반)
// 코드의 재활용성을 확장시키기위한 개념
// feat. 똑같은 코드 다시 치기 싫다.

// 상속시키는 방법
// Class Player, Class Monster의 공통적인 기능을하는 맴버변수와 맴버함수를 걷어낸다.
// 변수: Attack, Hp
// 함수: Damage()
// 걷어낸 공통 내용을 하나의 상속Class로 정의한다.(함수: Fight())


// 상속Class로부터 공통기능을 상속받는다는 표시를 한다. (class Player : Fight)
class Player :Fight
{
    int Level = 5;
    int MaxHp = 100;

    void MaxHeal()
    {
        // 상속 Class의 맴버변수의 접급제한 지정자가 protected이기 때문에 사용가능.
        Hp = MaxHp;
    }

}

class Monster:Fight
{
    
}

class Fight
{
    // 상속 변수의 접근제한 지정자
    //          private         protected       public
    // 범위     Class내부까지   자식Class까지   외부Class까지
    
    protected int Attack = 10;
    protected int Hp = 100;

    public void Damage(Fight _FightUnit)
    {
        this.Hp -= _FightUnit.Attack;

        Console.WriteLine("HP 상태: " + Hp);
    }
}

namespace Inheritance_Test{

    class Program_Class
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Monster monster = new Monster();

            //Damage의 인자값의 형태는 Fight이지만
            //Monster를 인자값으로 넣을 수 있는 이유 = Up Casting
            //Up Casting: 자식이 부모형으로서 전환( but 자식으로서의 기능은 상실)
            player.Damage(monster);

        }
    }
}