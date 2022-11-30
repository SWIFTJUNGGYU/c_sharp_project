using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스(Interface)
// 상속과는 다른 '포함'의 의미(강제성이 있음)
// Interface 연결 된 Class는 무조건 Interfacd 내에 있는 Method를 Class에서 정의해야만한다.
// Interface 안에서는 Method 선언만 할 수 있다.

enum MassgeCorporation {
    KAKAO,
    LINE,
    FACEBOOK,
    INSTA,
    BAND
}

interface ResultMessage
{
    MassgeCorporation SelectCorp();
}

class Kakao : ResultMessage
{
    public MassgeCorporation SelectCorp()
    {
        return MassgeCorporation.KAKAO;
    }
}

class Line : ResultMessage
{
    public MassgeCorporation SelectCorp()
    {
        return MassgeCorporation.LINE;
    }
}

class SendMassage
{
    public void Send(MassgeCorporation _massgeCorporation)
    {
        Console.WriteLine("선택한 메신저 회사: " + _massgeCorporation);
    }
}

namespace Interface_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SendMassage sendMassage = new SendMassage();
            Kakao kakao = new Kakao();
            Line line = new Line();

            MassgeCorporation kakaoCorp = kakao.SelectCorp();
            sendMassage.Send(kakaoCorp);

            MassgeCorporation lineCorp = line.SelectCorp();
            sendMassage.Send(lineCorp);

            // Interce로 연결시킨 Class의 객체에서 바로 Interface 함수를 호출할 수 있다.
            ResultMessage resultMessage = new Kakao();
            Console.WriteLine(resultMessage);
        }
    }
}
