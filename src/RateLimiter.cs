using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RiotWrapper.NET
{
    public class RateLimiter
    {
        public int AppRequests { get; set; } = 0;
        private int AppSecondRequests { get; set; }
        private TimeSpan AppStartUpTime { get; set; }
        private TimeSpan AppSecondsReset { get; set; }

        public void InitializeAppStartupTime(KeyValuePair<string, IEnumerable<string>> AppHeader)
        {
            string AppHeaderValue = AppHeader.Value.FirstOrDefault();
                     
            int AppRequestNumber = 0;
            switch(AppHeaderValue.Length)
            {
                case 9:
                    AppRequestNumber = int.Parse(AppHeaderValue.Remove(1, AppHeaderValue.Length - 1));
                    break;
                case 10:
                    AppRequestNumber = int.Parse(AppHeaderValue.Remove(2, AppHeaderValue.Length - 2));
                    break;
                case 11:
                    AppRequestNumber = int.Parse(AppHeaderValue.Remove(3, AppHeaderValue.Length - 3));
                    break;              
            }

            AppRequests = AppRequestNumber;
            AppSecondRequests = AppRequests;
            AppStartUpTime = DateTime.Now.TimeOfDay;
            AppSecondsReset = DateTime.Now.TimeOfDay;
        }

        public bool CheckRateLimit()
        {
            if (AppRequests == AppSecondRequests + 18) // 18 per second
            {              
                int Difference = (int)DateTime.Now.TimeOfDay.Subtract(AppSecondsReset).TotalMilliseconds;
                Console.WriteLine(Difference);
                if (Difference > 0 && Difference < 1000)
                {
                    Thread.Sleep(1000 - Difference);
                }
                AppSecondRequests = AppRequests;
                AppSecondsReset = DateTime.Now.TimeOfDay;
            }
            if (AppRequests >= 98) // 98 per 2 minutes
            {
                int Difference = (int)DateTime.Now.TimeOfDay.Subtract(AppStartUpTime).TotalMilliseconds;
                if (Difference > 0 && Difference < 120000)
                {
                    Thread.Sleep(120000 - Difference);
                }
                return true;
            }
            return false;
        }
    }
}
