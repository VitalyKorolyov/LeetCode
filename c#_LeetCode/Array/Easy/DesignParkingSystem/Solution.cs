namespace LeetCode.Array.Easy.DesignParkingSystem
{
    public class Solution
    {
        
    }

    //https://leetcode.com/problems/design-parking-system/
    public class ParkingSystem
    {
        private readonly int _maxSizeBig;
        private readonly int _maxSizeMedium;
        private readonly int _maxSizeSmall;

        private int _counterSizeBig;
        private int _counterSizeMedium;
        private int _counterSizeSmall;

        public ParkingSystem(int big, int medium, int small)
        {
            _maxSizeBig = big;
            _maxSizeMedium = medium;
            _maxSizeSmall = small;
        }

        public bool AddCar(int carType)
        {
            if (carType == 1)
            {
                if (_counterSizeBig < _maxSizeBig)
                {
                    _counterSizeBig++;
                    return true;
                }

            }

            if (carType == 2)
            {
                if (_counterSizeMedium < _maxSizeMedium)
                {
                    _counterSizeMedium++;
                    return true;
                }

            }

            if (carType == 3)
            {

                if (_counterSizeSmall < _maxSizeSmall)
                {
                    _counterSizeSmall++;
                    return true;
                }

            }

            return false;
        }
    }
}