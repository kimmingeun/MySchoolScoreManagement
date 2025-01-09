using MySchoolScoreManagementUI.Applications.Views;
using System.ComponentModel.Composition;
using System.Waf.Applications;

namespace MySchoolScoreManagementUI.Applications.ViewModels
{
    [Export]
    public class RibbonViewModel : ViewModel<IRibbonView>
    {
        [ImportingConstructor]
        public RibbonViewModel(IRibbonView view) : base(view)
        {
        }

        private DelegateCommand _commandNew;
        public DelegateCommand CommandNew
        {
            get => _commandNew;
            set => SetProperty(ref _commandNew, value);
        }

        private DelegateCommand _commandRead;
        public DelegateCommand CommandRead
        {
            get => _commandRead;
            set => SetProperty(ref _commandRead, value);
        }

        private DelegateCommand _commandExport;
        public DelegateCommand CommandExport
        {
            get => _commandExport;
            set => SetProperty(ref _commandExport, value);
        }
    }
}