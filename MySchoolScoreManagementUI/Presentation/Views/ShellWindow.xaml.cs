using DevExpress.Xpf.Core;
using MySchoolScoreManagementUI.Applications.Views;
using System.ComponentModel.Composition;
using System.Windows;

namespace MySchoolScoreManagementUI.Presentation.Views
{
    [Export(typeof(IShellView))]
    public partial class ShellWindow : ThemedWindow, IShellView
    {
        public ShellWindow()
        {
            InitializeComponent();
        }
    }
}
