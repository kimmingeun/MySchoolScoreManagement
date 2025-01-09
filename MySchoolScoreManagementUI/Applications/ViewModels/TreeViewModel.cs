using MySchoolScoreManagementUI.Applications.Views;
using MySchoolScoreManagementUI.Domain;
using System.ComponentModel.Composition;
using System.Waf.Applications;

namespace MySchoolScoreManagementUI.Applications.ViewModels
{
    [Export]
    public class TreeViewModel : ViewModel<ITreeView>
    {
        [ImportingConstructor]
        public TreeViewModel(ITreeView view) : base(view)
        {
        }

        public ModelManger ModelManger => ModelManger.Instance;
    }
}