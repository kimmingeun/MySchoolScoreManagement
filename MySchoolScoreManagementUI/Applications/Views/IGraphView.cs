using DevExpress.Xpf.Charts;
using System.Waf.Applications;

namespace MySchoolScoreManagementUI.Applications.Views
{
    public interface IGraphView : IView
    {
        void AddGraph(Series line);

        void RemoveGraph(Series line);
    }
}