using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCallers.proxy
{
	public class Proxy
    {
        public string Url { get; set; }
        public int Port { get; set; }

        public int FailedTimes { get; set; }
        public int SucceedTimes { get; set; }

        public DateTime SucceedLastTime { get; set; }
        public DateTime FailedLastTime { get; set; }


        public override String ToString()
        {
            return $"{Url}:{Port} S:{SucceedTimes} F:{FailedTimes}";
        }
    }
}
