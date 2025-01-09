using MySchoolScoreManagementUI.Applications.Views;
using System.ComponentModel.Composition;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace MySchoolScoreManagementUI.Presentation.Views
{
    [Export(typeof(IRibbonView))]
    public partial class RibbonView : UserControl, IRibbonView
    {
        public RibbonView()
        {
            InitializeComponent();
        }

    }
}
