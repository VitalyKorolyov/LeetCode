namespace LeetCode.Math.Medium
{
    //https://leetcode.com/problems/angle-between-hands-of-a-clock/
    public class Solution
    {
        public double AngleClock(int hour, int minutes)
        {
            var minDegrees = 6 * minutes;
            double partsAfterHour = minutes / 60.0;
            double degreesAfterHour = 30.0 * partsAfterHour;
            var degreesFromHours = (HoursToMinutes(hour) * 6) + degreesAfterHour;

            var firstAngle = System.Math.Abs(minDegrees - degreesFromHours);
            var secondAngle = 360 - firstAngle;

            return firstAngle < secondAngle ? firstAngle : secondAngle;
        }

        private int HoursToMinutes(int hours)
        {
            if (hours == 1)
                return 5;
            if (hours == 2)
                return 10;
            if (hours == 3)
                return 15;
            if (hours == 4)
                return 20;
            if (hours == 5)
                return 25;
            if (hours == 6)
                return 30;
            if (hours == 7)
                return 35;
            if (hours == 8)
                return 40;
            if (hours == 9)
                return 45;
            if (hours == 10)
                return 50;
            if (hours == 11)
                return 55;
            return 0;
        }
    }
}