using System;
using System.Threading;
using System.Threading.Tasks;

namespace RiotWrapper.NET
{
    public class RateLimiter
    {
        private int CurrentAppRateLimitM { get; set; }
        private int MaxAppRateLimitM { get; set; }
        private int AppRateLimitTimeM { get; set; }
        private TimeSpan AppRateLimitMStart { get; set; }

        private int CurrentAppRateLimitS { get; set; }
        private int MaxAppRateLimitS { get; set; }
        private int AppRateLimitTimeS { get; set; }
        private TimeSpan AppRateLimitSStart { get; set; }

        public void InitializeMTime()
        {
            AppRateLimitMStart = DateTime.Now.TimeOfDay;
        }

        public void InitializeSTime()
        {
            AppRateLimitSStart = DateTime.Now.TimeOfDay;
        }

        public void SetVariablesFromHeaderData(string CountHeaderValue, string LimitHeaderValue)
        {
            string[] CHeaderPairs = CountHeaderValue.Split(',');
            string[] CHeaderPairValuesM = CHeaderPairs[0].Split(':');
            string[] CHeaderPairValuesS = CHeaderPairs[1].Split(':');
          
            string[] LHeaderPairs = LimitHeaderValue.Split(',');
            string[] LHeaderPairValuesM = LHeaderPairs[0].Split(':');
            string[] LHeaderPairValuesS = LHeaderPairs[1].Split(':');

            CurrentAppRateLimitM = int.Parse(CHeaderPairValuesM[0]);
            CurrentAppRateLimitS = int.Parse(CHeaderPairValuesS[0]);

            MaxAppRateLimitM = int.Parse(LHeaderPairValuesM[0]);
            MaxAppRateLimitS = int.Parse(LHeaderPairValuesS[0]);

            AppRateLimitTimeM = int.Parse(LHeaderPairValuesM[1]);
            AppRateLimitTimeS = int.Parse(LHeaderPairValuesS[1]);
        }

        public async Task CheckRateLimits()
        {
            if(CurrentAppRateLimitS == MaxAppRateLimitS - 2)
            {
                int SleepTime = (int)TimeDifference(AppRateLimitSStart);
                if(SleepTime > 0 && SleepTime < AppRateLimitTimeS)
                {
                    await Task.Delay(AppRateLimitTimeS * 1000 - SleepTime);
                }
                InitializeSTime();
            }

            if(CurrentAppRateLimitM == MaxAppRateLimitM - 2)
            {
                int SleepTime = (int)TimeDifference(AppRateLimitMStart);
                if(SleepTime > 0 && SleepTime < AppRateLimitTimeM * 1000)
                {
                    await Task.Delay(AppRateLimitTimeM * 1000 - SleepTime);
                }             
                InitializeMTime();
            }
        }

        private double TimeDifference(TimeSpan InitialTime)
        {
            return DateTime.Now.TimeOfDay.TotalMilliseconds - InitialTime.TotalMilliseconds;
        }

        public void PrintCurrentRates()
        {
            Console.WriteLine($"{CurrentAppRateLimitM} : {MaxAppRateLimitM}, {CurrentAppRateLimitS} : {MaxAppRateLimitS}");
        }
    }
}
