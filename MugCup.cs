
using System;

namespace CSSubClass02
{
	class MugCup : Cup
	{
		// 자식에게만 물려주겠다.
		internal protected int price;

		// Clear() 메서드 기능을 변경 하고 싶다.
		// override - 재정의. 부모의 기능을 변경할 때.
		// sealed - 자식이 재정의를 못하도록 금지설정
		internal override sealed void Clear()
		{
			Console.WriteLine("컵을 씻었다.");
		}

		// 의도치 않은 재정의가 되지 않도록 주의.
        internal override string CupType()
		{
			return "머그컵";
		}

		internal void AddMl()
		{
		}

	}
}
