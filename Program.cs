
using System;

namespace CSSubClass02
{
	class Program
	{
		static void Main(string[] args)
		{
			// 상속의 목적
			// 1. 코드의 간략화. 정리
			// 2. 다형성 - 부모의 그릇에 자식의 객체를 담는 개념
			Cup myCup = new GlassMugCup();
			myCup.Clear();
			Console.WriteLine(myCup.CupType());

			// 종이컵인경우만 가능한 기능 구현일 경우
			bool chk = myCup is PaperCup;
			Console.WriteLine(chk);

			// 유리머그컵인 경우만 기능을 수행해라
			if (myCup is GlassMugCup) // 글래스부터 상위클래스까지 True
			{
				// 변수(그릇)의 타입이 다른 상황. 부모인경우.
				// 자식만 가지고 있는 기능은 이용이 불가능하다.
				// 강제 형변환을 이용하여 형태를 바꾸면 가능하다. (아래 두가지 형태로 가능)
				((GlassMugCup)myCup).Memo();
				string str = (myCup as GlassMugCup).Memo();

				Console.WriteLine(str);

				Console.WriteLine(myCup.CupType());
			}

			PaperCup myCup2 = new PaperCup(100);
			myCup2.Memo();
		}
	}
}
