using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWarsSolutions;
using CodeWarsSolutions.Interfaces;

namespace CodeWarsSolutions.Objects
{
    public class BMICalculator : IBMICalculator
    {

        public int _weight;
        public int _height;
        public double _eval;

        public string _finalEvaluation;

        public string BMIValue(double weight, double height)
        {
            _eval = (weight / (Math.Pow(height, 2)));
            Console.WriteLine(_eval);
            var res = BMIEvaluation(_eval);
            Console.WriteLine(res);
            return res;
        }

        public string BMIEvaluation(double evaluation)
        {
            Console.WriteLine(evaluation);
            if (evaluation <= 18.5)
            {
                return "Underweight";
            } 
            else if (evaluation <= 25.0)
            {
                return "Normal";
            }
            else if (evaluation <= 30.0)
            {
                return "Overweight";
            }
            else if (evaluation > 30)
            {
                return "Obese";
            }
            return "yo";
        }

    }
}
