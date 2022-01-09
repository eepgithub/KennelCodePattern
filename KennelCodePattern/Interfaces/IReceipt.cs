using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KennelCodePattern.Interfaces
{
    public interface IReceipt
    {
        public IStandardService StandardService { get; set; }
        public IWash Wash { get; set; }
        public IClaws ClawCutting { get; set; }
        public decimal TotalCost { get; set; }

        public void ShowReceipt(IStandardService standardService, IClaws clawCutting, IWash wash, List<IAnimal> animals, IAnimal animal);
    }
}
