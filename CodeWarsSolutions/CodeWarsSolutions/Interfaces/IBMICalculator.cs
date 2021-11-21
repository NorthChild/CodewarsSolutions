using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWarsSolutions;
using CodeWarsSolutions.Objects;

namespace CodeWarsSolutions.Interfaces
{
    public interface IBMICalculator
    {
        public string BMIValue(double weight, double height);
        public string BMIEvaluation(double evaluation);
        
    }
}
