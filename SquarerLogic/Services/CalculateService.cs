using SquarerLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarerLogic.Services
{
    public interface ICalculateService
    {
         void Calculate(Input model);
    }

    public class CalculateService : ICalculateService
    {
        public void Calculate(Input model)
        {
            model.x = new List<double>();
            //Calculation logic - Hometask
            var d = model.B ^ 2 - 4 * model.A * model.C;
            if (d < 0)
                return;
            else
            {
                var x = (-model.B + Math.Sqrt(d)) / 2 * model.A;
                model.x.Add(x);
                if (d != 0) {
                    x = (-model.B - Math.Sqrt(d)) / 2 * model.A;
                    model.x.Add(x);

                }
            }
            
            //ax[2]+bx+c=0
        }

    }
    public class CalculateServiceMock : ICalculateService
    {
        public void Calculate(Input model)
        {
            model.x = new List<double>
            {
            5, 6 //Mocked
            };
        }

    }

}
