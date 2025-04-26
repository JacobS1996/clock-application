using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace ClockLibrary
{
    public static class DateTimeManipulation
    {

        public static DateTime currentTime { get; set; } = DateTime.Now;

        private static void SetCurrentTime(DateTime currentTime)
        {
            currentTime = DateTime.Now;
            
        }

      
    }
}
