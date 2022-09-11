using System.Collections.Generic;

namespace LeetCode.Matrix.Medium.RobotBoundedInCircle
{
    //https://leetcode.com/problems/robot-bounded-in-circle/
    enum Direction
    {
        North,
        West,
        East,
        South
    }

    public class Solution
    {
        private readonly Dictionary<Direction, int[]> Steps = new()
        {
            { Direction.North, new int[] {1, 0} },
            { Direction.South, new int[] {-1, 0} },
            { Direction.East, new int[] {0, 1} },
            { Direction.West, new int[] {0, -1} },
        };

        public bool IsRobotBounded(string instructions)
        {
            Direction face = Direction.North;
            var posX = 0;
            var posY = 0;

            foreach (var instruction in instructions)
            {
                switch (instruction)
                {
                    case 'G':
                        {
                            var step = Steps[face];
                            posY += step[0];
                            posX += step[1];
                        }
                        break;
                    case 'L':
                        {
                            if (face == Direction.North)
                                face = Direction.West;
                            else if (face == Direction.South)
                                face = Direction.East;
                            else if (face == Direction.West)
                                face = Direction.South;
                            else if (face == Direction.East)
                                face = Direction.North;
                        }
                        break;
                    case 'R':
                        {
                            if (face == Direction.North)
                                face = Direction.East;
                            else if (face == Direction.South)
                                face = Direction.West;
                            else if (face == Direction.West)
                                face = Direction.North;
                            else if (face == Direction.East)
                                face = Direction.South;
                        }
                        break;
                    default:
                        break;
                }
            }

            return (posY == 0 && posX == 0) || face != Direction.North;
        }
    }
}
