using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._98_PS_Gradebook
{
    public class Gradebook
    {
        public Gradebook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade); 
        }

        List<float> grades;
    }
}
