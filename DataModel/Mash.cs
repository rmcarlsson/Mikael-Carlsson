using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Mash
    {
        public int MashId { set; get; }
        public ICollection<Malt> Malts { set; get; }
        public ICollection<TempStep> TempSteps { set; get; }
    }
}
