using System.Collections.Generic;

namespace LeetCode.HashTable.Easy.LoggerRateLimiter
{
    //https://leetcode.com/problems/logger-rate-limiter/
    public class Logger
    {
        private readonly Dictionary<string, int> _logger;

        public Logger()
        {
            _logger = new Dictionary<string, int>();
        }

        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if (!_logger.ContainsKey(message))
            {
                _logger.Add(message, timestamp + 10);
                return true;
            }

            var time = _logger[message];

            if (time <= timestamp)
            {
                _logger[message] = timestamp + 10;
                return true;
            }

            return false;
        }
    }
}