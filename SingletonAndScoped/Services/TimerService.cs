using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonAndScoped.Services
{
    public class TimerService
    {

        ITimer _timer;
        public TimerService(ITimer timer)
        {
            _timer= timer;
        }
        public string GetTime()
        {
            return _timer.Time;
        }

    }
}
