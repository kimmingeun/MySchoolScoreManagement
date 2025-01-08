using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolScoreManagementUI.Domain
{
    public class Student : ModelBase
    {
		private double _scoreMid1;
		public double ScoreMid1
		{
			get => _scoreMid1;
			set => SetProperty(ref _scoreMid1, value);
		}

		private double _scoreMid2;
		public double ScoreMid2
		{
			get => _scoreMid2;
			set => SetProperty(ref _scoreMid2, value);
		}

		private double _scoreFin1;
		public double ScoreFin1
		{
			get => _scoreFin1;
			set => SetProperty(ref _scoreFin1, value);
		}

		private double _scoreFin2;
		public double ScoreFin2
		{
			get => _scoreFin2;
			set => SetProperty(ref _scoreFin2, value);
		}

		private ClassRoom _classRoom;
		public ClassRoom ClassRoom
		{
			get => _classRoom;
			set => SetProperty(ref _classRoom, value);
		}
	}
}
