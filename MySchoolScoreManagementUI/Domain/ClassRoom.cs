using MySchoolScoreManagementUI.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolScoreManagementUI.Domain
{
    public class ClassRoom : ModelBase
    {
        public ObservableCollection<Student> Students { get; } = new ObservableCollection<Student>();

        private SchoolYear _schoolYear;
        public SchoolYear SchoolYear
        {
            get => _schoolYear;
            set => SetProperty(ref _schoolYear, value);
        }

        public void AddStudent(string studentName)
        {
            var student = new Student
            {
                Name = studentName,
                ClassRoom = this,
                ScoreFin1 = MathHelper.GetRandomScore(50, 100),
                ScoreFin2 = MathHelper.GetRandomScore(50,100),
                ScoreMid1 = MathHelper.GetRandomScore(50,100),
                ScoreMid2 = MathHelper.GetRandomScore(50,100)
            };

            Students.Add(student);
            student.ClassRoom = this;
        }
    }
}
