using MySchoolScoreManagementUI.Applications.Views;
using System.ComponentModel.Composition;
using System.Windows;

namespace MySchoolScoreManagementUI.Presentation.Views
{
    [Export(typeof(IShellView))]
    public partial class ShellWindow : Window, IShellView
    {
        public ShellWindow()
        {
            InitializeComponent();
        }
    }
}
