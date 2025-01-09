using MySchoolScoreManagementUI.Applications.Views;
using MySchoolScoreManagementUI.Domain;
using System.ComponentModel.Composition;
using System.Waf.Applications;

namespace MySchoolScoreManagementUI.Applications.ViewModels
{
    [Export]
    public class DataGridViewModel : ViewModel<IDataGridView>
    {
        [ImportingConstructor]
        public DataGridViewModel(IDataGridView view) : base(view)
        {
        }

        public ModelManger ModelManger => ModelManger.Instance;
    }
}