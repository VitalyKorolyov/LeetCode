namespace LeetCode.Math.Medium.TheNumberOfFullRoundsYouHavePlayed
{
    //https://leetcode.com/problems/the-number-of-full-rounds-you-have-played/description/
    public class Solution
    {
        public int NumberOfRounds(string loginTime, string logoutTime)
        {
            (int hoursLogin, int minutesLogin) = GetTime(loginTime);
            (int hoursLogout, int minutesLogout) = GetTime(logoutTime);

            var start = hoursLogin * 60 + minutesLogin;
            var finish = hoursLogout * 60 + minutesLogout;

            if (start > finish) finish += 60 * 24;

            return System.Math.Max(0, 
                (int)System.Math.Floor(finish / 15.00) - (int)System.Math.Ceiling(start / 15.00));
        }

        private (int, int) GetTime(string time)
        {
            var parts = time.Split(':');

            return (int.Parse(parts[0]), int.Parse(parts[1]));
        }
    }
}
