using KennelCodePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelCodePattern.Models
{
    public class SetPrice : ISetPrice
    {
        public void SetServicePrice(IStandardService standardService, IWash wash, IClaws clawCutting)
        {
            standardService.Price = 399;
            wash.Price = 99;
            clawCutting.Price = 99;
        }

        public void SetServiceName(IStandardService standardService, IWash wash, IClaws clawCutting)
        {
            standardService.Name = "Dagpassning";
            wash.Name = "Tvätt";
            clawCutting.Name = "Kloklippning";
        }
    }
}
