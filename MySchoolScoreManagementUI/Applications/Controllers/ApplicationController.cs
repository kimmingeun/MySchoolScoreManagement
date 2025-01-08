using MySchoolScoreManagementUI.Applications.ViewModels;
using MySchoolScoreManagementUI.Domain;
using System.ComponentModel.Composition;

namespace MySchoolScoreManagementUI.Applications.Controllers
{
    [Export]
    internal class ApplicationController
    {
        private readonly ShellViewModel shellViewModel;


        [ImportingConstructor]
        public ApplicationController(ShellViewModel shellViewModel)
        {
            this.shellViewModel = shellViewModel;
        }



        public void Initialize() //프로그램이 시작될 때 가장 먼저 호출되는 부분 : 초기화 여기서 실행
        {
            ModelManger.Instance.ReadData();
        }

        public void Run()
        {
            shellViewModel.Show();
        }

        public void Shutdown()
        {

        }
    }
}
