using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatingCombine
{
    public interface IAlternateCombiner
    {
        List<string> AlternateCombine(List<string> first, List<string> second);
    }
}
