using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelCodePattern.Interfaces
{
    public interface ISetPrice
    {
        public void SetServicePrice(IStandardService standardService, IWash wash, IClaws clawCutting);
        public void SetServiceName(IStandardService standardService, IWash wash, IClaws clawCutting);
    }
}
