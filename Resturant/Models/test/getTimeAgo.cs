using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resturant.Models.test
{
    public class getTimeAgo
    {
        public string timeAgo(DateTime t)
        {
            
            const int SECOND = 1;
            const int MINUTE = 60 * SECOND;
            const int HOUR = 60 * MINUTE;
            const int DAY = 24 * HOUR;
            const int MONTH = 30 * DAY;
            
                var ts = new TimeSpan(DateTime.UtcNow.Ticks - t.Ticks);
                double delta = Math.Abs(ts.TotalSeconds);

                if (delta < 1 * MINUTE)
                    return ts.Seconds == 1 ? "one second ago" : ts.Seconds + " seconds ago";

               else if (delta < 2 * MINUTE)
                    return "a minute ago";

               else if (delta < 45 * MINUTE)
                    return ts.Minutes + " minutes ago";

               else if (delta < 90 * MINUTE)
                    return "an hour ago";

               else if (delta < 24 * HOUR)
                    return ts.Hours + " hours ago";

               else if (delta < 48 * HOUR)
                    return "yesterday";

              else  if (delta < 30 * DAY)
                    return ts.Days + " days ago";

              else  if (delta < 12 * MONTH)
                {
                    int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                    return months <= 1 ? "one month ago" : months + " months ago";
                }
                else
                {
                    int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                    return years <= 1 ? "one year ago" : years + " years ago";
                }
            } 
    }
}