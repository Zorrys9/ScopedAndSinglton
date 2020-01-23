using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonAndScoped.Services
{
    public class Timer :ITimer
    {
        public Timer()
        {
            Time = System.DateTime.Now.ToString("hh:mm:ss");
        }
        public string Time { get; }
    }
}
