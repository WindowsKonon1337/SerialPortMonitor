using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPM.Additional
{
    public struct AppState
    {

        public bool IsBlack { get; set; }

        public bool PortOpened { get; set; }

        public int HexLength { get; set; }

        public bool LoopStarted { get; set; }
    }
}
