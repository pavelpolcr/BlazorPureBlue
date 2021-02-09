using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPureBlue
{
    public static class BHService
    {
        private static BlueHandler bh;

        public static BlueHandler BH
        {
            get { return bh; }
            set { bh = value; }
        }

    }
}
