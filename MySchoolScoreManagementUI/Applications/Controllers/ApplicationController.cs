using MySchoolScoreManagementUI.Applications.ViewModels;
using MySchoolScoreManagementUI.Domain;
using System.ComponentModel.Composition;

namespace MySchoolScoreManagementUI.Applications.Controllers
{
    [Export]
    internal class ApplicationController
    {
        private readonly ShellViewModel shellViewModel;
        private readonly TreeViewModel _treeViewModel;
        private readonly MainController _mainController;
        private readonly DataGridViewModel _dataGridViewModel;
        private readonly GraphViewModel _graphViewModel;
        private readonly RibbonViewModel _ribbonViewModel;

        [ImportingConstructor]
        public ApplicationController(ShellViewModel shellViewModel, RibbonViewModel ribbonViewModel,
            DataGridViewModel dataGridViewModel,
            GraphViewModel graphViewModel,
            TreeViewModel treeViewModel,
            MainController mainController)
        {
            this.shellViewModel = shellViewModel;
            _ribbonViewModel = ribbonViewModel;
            _dataGridViewModel = dataGridViewModel;
            _graphViewModel = graphViewModel;
            _treeViewModel = treeViewModel;
            _mainController = mainController;
        }



        public void Initialize() //프로그램이 시작될 때 가장 먼저 호출되는 부분 : 초기화 여기서 실행
        {
            // Connect view
            shellViewModel.ContentDataGridView = _dataGridViewModel.View;
            shellViewModel.ContentTreeView = _treeViewModel.View;
            shellViewModel.ContentGraphView = _graphViewModel.View;
            shellViewModel.ContentRibbonView = _ribbonViewModel.View;

            //Controller initialize
            _mainController.initialize();

            // Read data
            ModelManger.Instance.ReadData();

            // Event
            ModelManger.Instance.SelectedStudents.CollectionChanged += _graphViewModel.StudentCollectionChanged;
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
