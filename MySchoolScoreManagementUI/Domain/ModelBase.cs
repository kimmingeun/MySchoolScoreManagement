using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Waf.Foundation;


namespace MySchoolScoreManagementUI.Domain
{
    public class ModelBase : Model //상속을 통해 Model 클래스의 기능을 재사용 및 확장하려는 구조
    {
		private string _name; //Name 속성의 백업 필드로 사용
							  //백업 필드란 속성에서 데이터를 저장하고 관리하기 위해 사용되는 비공개 변수
							  //_(언더스코어)로 시작하는 이름은 보통 프라이빗 필드
		public string Name //_name 필드에 대한 public 속성
		{
			get => _name; //get 접근자 : _name 필드 값 반환, 데이터 읽기
			set => SetProperty(ref _name, value); //set 접근자 : _name 필드 값 변경
		}

		public override string ToString() => Name;
	}
}
