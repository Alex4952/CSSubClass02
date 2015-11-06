using System;

namespace CSSubClass02
{
	// 가지고 있는 기능중에 하나라도 미구현된 메서드가 있다면
	// 사용 불가능한 클래스로 간주된다.
	// 생성이 불가능한 상속전용 클래스로 만든다.
	// 추상메서드가 하다라도 있으면 추상클래스로 정의해야 함.
	abstract class Cup
	{
		internal double ml; // 담겨있는 양

		// 기본생성자
		internal Cup() {}

		// 생성자
		// 생성자를 하나라도 만들면
		// Cup() 형태의 기본 생성자가 사라진다.
		// 기본생성자가 필요하면 만들어야 함
		internal Cup(double ml)
		{
			this.ml = ml;
		}

		// 해당 기능을 자식이 변경 가능하도록 설정해야 한다.
		// virtual - 재정의가 가능하도록 권한 설정
		internal virtual void Clear()
		{
			this.ml = 0; // 내용물을 비운다.
			Console.WriteLine("내용물을 비웠다.");
		}

		// 추상메서드
		// 자식을 위해서 이름만 정의해 놓는 방법.
		internal abstract string CupType();
	}
}
