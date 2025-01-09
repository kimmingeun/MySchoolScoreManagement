using DevExpress.Xpf.Charts;
using MySchoolScoreManagementUI.Applications.Views;
using System.ComponentModel.Composition;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace MySchoolScoreManagementUI.Presentation.Views
{
    [Export(typeof(IGraphView))]
    public partial class GraphView : UserControl, IGraphView
    {
        public GraphView()
        {
            InitializeComponent();
        }

        public void AddGraph(Series line)
        {
            if (!Chart2D.Series.Contains(line))
            {
                Chart2D.Series.Add(line);
            }
        }
        public void RemoveGraph(Series line)
        {
            if (Chart2D.Series.Contains(line))
            {
                Chart2D.Series.Remove(line);
            }
        }

    }
}
