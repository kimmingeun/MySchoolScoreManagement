using DevExpress.Xpf.Charts;
using MySchoolScoreManagementUI.Applications.Views;
using MySchoolScoreManagementUI.Domain;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Composition;
using System.Waf.Applications;

namespace MySchoolScoreManagementUI.Applications.ViewModels
{
    [Export]
    public class GraphViewModel : ViewModel<IGraphView>
    {
        [ImportingConstructor]
        public GraphViewModel(IGraphView view) : base(view)
        {
        }

        private Dictionary<Student, LineSeries2D> _dicCurves = new Dictionary<Student, LineSeries2D>();

        internal void StudentCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (Student student in e.NewItems)
                    {
                        AddGraph(student);
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (Student student in e.OldItems)
                    {
                        RemoveGraph(student);   
                    }
                    break;
            }
        }

        private void RemoveGraph(Student student)
        {
            if (_dicCurves.ContainsKey(student))
            {
                ViewCore.RemoveGraph(_dicCurves[student]);
                _dicCurves.Remove(student);
            }
        }

        private void AddGraph(Student student)
        {
            var curve = new LineSeries2D()
            {
                ArgumentDataMember = "Period",
                ValueDataMember = "Score",
                MarkerVisible = true
            };

            curve.AddPoint("Mid1", student.ScoreMid1);
            curve.AddPoint("Fin1", student.ScoreFin1);
            curve.AddPoint("Mid2", student.ScoreMid2);
            curve.AddPoint("Fin2", student.ScoreFin2);

            ViewCore.AddGraph(curve);
            _dicCurves[student]= curve;
        }
    }
}