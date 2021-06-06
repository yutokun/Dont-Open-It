﻿using System;

namespace DontOpenIt
{
    public enum TimeFrame
    {
        Before,
        Working,
        After
    }

    public static class Time
    {
        public static TimeFrame GetTimeFrame()
        {
            var now = DateTime.Now.TimeOfDay;

            if (TimeSpan.FromHours(4) <= now && now < TimeSpan.FromHours(9))
            {
                return TimeFrame.Before;
            }

            if (TimeSpan.FromHours(4) > now || now > TimeSpan.FromHours(20))
            {
                return TimeFrame.After;
            }

            return TimeFrame.Working;
        }
    }
}