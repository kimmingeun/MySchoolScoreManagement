using System.Waf.Applications;

namespace MySchoolScoreManagementUI.Applications.Views
{
    internal interface IShellView : IView
    {
        void Show();

        void Close();
    }
}
