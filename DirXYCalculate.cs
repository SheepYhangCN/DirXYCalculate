//By SheepYhangCN
using System;

namespace SheepYhangCN.DirXYCalculate
{   
    public static class DirXYCalculate
    {
        public static double PointDirection(double x1,double y1,double x2,double y2)
        {
            return double.DegreesToRadians(Math.Atan2(x2-x1,y2-y1));
        }
        public static double LengthDirX(double angle,double length)
        {
            return Math.Sin(double.RadiansToDegrees(angle))*length;
        }
        public static double LengthDirY(double angle,double length)
        {
            return Math.Cos(double.RadiansToDegrees(angle))*length;
        }
    }
}