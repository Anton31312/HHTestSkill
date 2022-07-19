using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHTestSkill
{
    public class TriangleExcep : Exception
    {
        public TriangleExcep (string message) : base(message)
        {

        }
    }
}
