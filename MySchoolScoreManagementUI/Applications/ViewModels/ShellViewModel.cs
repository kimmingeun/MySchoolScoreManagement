using MySchoolScoreManagementUI.Applications.Views;
using System.ComponentModel.Composition;
using System.Waf.Applications;
using System.Windows.Input;

namespace MySchoolScoreManagementUI.Applications.ViewModels
{
    [Export]
    internal class ShellViewModel : ViewModel<IShellView>
    {
        private readonly DelegateCommand exitCommand;


        [ImportingConstructor]
        public ShellViewModel(IShellView view)
            : base(view)
        {
            exitCommand = new DelegateCommand(Close);
        }


        public string Title { get { return ApplicationInfo.ProductName; } }

        public ICommand ExitCommand { get { return exitCommand; } }


        public void Show()
        {
            ViewCore.Show();
        }

        private void Close()
        {
            ViewCore.Close();
        }

        private object _contentRibbonView;

        public object ContentRibbonView
        {
            get => _contentRibbonView;
            set => SetProperty(field: ref _contentRibbonView, value);
        }

        private object _contentGraphView;

        public object ContentGraphView
        {
            get => _contentGraphView;
            set => SetProperty(field: ref _contentGraphView, value);
        }

        private object _contentTreeView;

        public object ContentTreeView
        {
            get => _contentTreeView;
            set => SetProperty(field: ref _contentTreeView, value);
        }

        private object _contentDataGridView;

        public object ContentDataGridView
        {
            get => _contentDataGridView;
            set => SetProperty(field: ref _contentDataGridView, value);
        }
    }
}
