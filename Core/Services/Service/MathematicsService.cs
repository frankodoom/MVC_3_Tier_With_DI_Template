using Core.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class MathematicsService : IMathematicsService
    {
        public int Add(int num1, int num2)
        {
            var ans = num1 + num2;
            return ans;
        }
    }
}
