
using System;

namespace CSSubClass02
{
	// 상속을 받아 재정의를 하면 부모의 기능을 지우고
	// 다시 만드는 것이 아니라 추가로 하나를 더 만든다.
	// 부모의 기능과 자신의 기능 모두 사용 가능.
	class GlassMugCup : MugCup
	{
		// 접근제한자
		// public - 모두에게
		// protected - 자신과 자식
		// private - 자신만 허용
		// internal (public 생략)
		// internal protected

		// 최상위 부모가 추상형일때 부모가 비추상형이면
		// 자식은 굳이 추상메서드 구현이 필요없음.(필요없다면..)
		// 왜? - 머그컵의 CupType()을 상속받으니까.
		internal override string CupType()
		{
			// CupType 활용중
			// base - 부모를 지칭. this - 자신을 지칭
			//Console.WriteLine(base.CupType());
			return "유리" + base.CupType();
		}

		internal string Memo()
		{
			return "인증받은 컵 확인!!!";
		}

		// 강제로 재정의 하는 상황
		// 여기서 new는 메서드를 새로만들겠다는 의미
		internal new void AddMl()
		{
		}

		
	}
}
