
using System;

namespace CSSubClass02
{
	partial class PaperCup : Cup
	{
		// 부모의 생성자를 그대로 쓸 수는 없다. Cup()
		// 자기 자신용 생성자를 구현
		
		// PaperCup을 만들려면 부모의 생성자로 먼저 만들어야 함.
		// 부모의 기본생성자가 없어서 : base(ml)이 필요함
		// 부모의 기본생성자가 있으면 뒷부분 필요없음.
		internal PaperCup(double ml) : base(ml) // -> 부모의 Cup(double ml) 호출
		{
			// 부모가 하는 일을 중복해서 작성할 필요는 없다.
		}

		internal override string CupType()
		{
			return "종이컵";
		}
	}

	// partial 같은 이름의 클래스를 쪼개는 기능
	// swift의 extension과 비슷
	// 한 클래스를 두 사람이 개발해야 하는 경우
	// 관련있는 메서드별로 분리하는 의미
	// 원래는 핵심기능과 부가기능을 분리하려는 의도
	// MS에서 같은 클래스 명으로 디바이스별 기능구현
	partial class PaperCup : Cup
	{
		internal void Memo()
		{
			Console.WriteLine("쓰신 후 재활용으로 버려주세요");
		}
	}


}
