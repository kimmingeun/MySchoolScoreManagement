using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolScoreManagementUI.Domain
{
    public class SchoolYear : ModelBase
    {
        public ObservableCollection<ClassRoom> ClassRooms { get; } = new ObservableCollection<ClassRoom>();

        public ClassRoom AddClassRoom(string classRoomName)
        {
            var classRoom = new ClassRoom
            {
                Name = classRoomName,
                SchoolYear = this
            };

            ClassRooms.Add(classRoom);
            return classRoom;
        }
    }
}
