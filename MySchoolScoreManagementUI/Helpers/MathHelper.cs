using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchoolScoreManagementUI.Helpers
{
    public class MathHelper
    {
        private static Random rand = new Random();

        public static double GetRandomScore(int min, int max) => rand.Next(min, max);
     
    }

}
