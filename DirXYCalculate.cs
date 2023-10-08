//By SheepYhangCN
using System;

namespace SheepYhangCN.DirXYCalculate
{   
    public static class DirXYCalculate
    {
        public static double PointDirection(double x1,double y1,double x2,double y2)
        {
            double tan=Math.Atan2(x2-x1,y2-y1);
            return tan*180/Math.PI;
        }
        public static double LengthDirX(double angle,double length)
        {
            double dir=angle*Math.PI/180;
            return Math.Sin(dir)*length;
        }
        public static double LengthDirY(double angle,double length)
        {
            double dir=angle*Math.PI/180;
            return Math.Cos(dir)*length;
        }
    }
}