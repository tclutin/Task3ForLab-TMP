using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Algorithm
{
    public interface IAlgorithm<T>
    {
        public void Execute(T[] array);
    }
}
