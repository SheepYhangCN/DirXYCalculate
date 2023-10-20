//By SheepYhangCN
using System;

namespace SheepYhangCN.DegreesRadians
{   
    public static class DegRadConvert
    {
        public static double RadiansToDegrees(double radians)
        {
            return radians*180/Math.PI;
        }
        public static double DegreesToRadians(double degrees)
        {
            return degrees*Math.PI/180;
        }
    }
}