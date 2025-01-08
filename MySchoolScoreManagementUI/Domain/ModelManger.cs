using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Waf.Foundation;

namespace MySchoolScoreManagementUI.Domain
{
    public class ModelManger : Model
    {
        private static readonly Lazy<ModelManger> _instance = new Lazy<ModelManger> (() => new ModelManger());

        public static ModelManger Instance => _instance.Value;

         protected ModelManger()
        {

        }

        public ObservableCollection<SchoolYear> SchoolYears { get; } = new ObservableCollection<SchoolYear>();

        public SchoolYear AddSchoolYear(string schoolYearName)
        {
            var schoolYear = new SchoolYear
            {
                Name = schoolYearName
            };
            SchoolYears.Add(schoolYear);
            return schoolYear;
        }

        public void ReadData()
        {
            // Read data from DB
            var sy1 = AddSchoolYear("2024");
            var cr1 = sy1.AddClassRoom("1학년 1반");
            cr1.AddStudent("홍길동");
            cr1.AddStudent("김철수");
            cr1.AddStudent("이영희");
            var cr2 = sy1.AddClassRoom("1학년 2반");
            cr2.AddStudent("박민수");
            cr2.AddStudent("정영희");
            cr2.AddStudent("최철수");

            var sy2 = AddSchoolYear("2025");
            var cr3 = sy2.AddClassRoom("2학년 1반");
            cr3.AddStudent("김태희");
            cr3.AddStudent("송혜교");
            cr3.AddStudent("전지현");
            var cr4 = sy2.AddClassRoom("2학년 2반");
            cr4.AddStudent("이민호");
            cr4.AddStudent("김수현");
            cr4.AddStudent("박신혜");

        }
    }
}
