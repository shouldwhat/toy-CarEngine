using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static AboutCarEngine.CarNavigator;

namespace AboutCarEngine
{
    public class CarHandle
    {
        public double handle(DIRECTION direction, Point nowPoint, Point destPoint)
        {
            return this.angle = this.getNextAngle(direction, nowPoint, destPoint);
        }

        private double getNextAngle(DIRECTION direction, Point nowPoint, Point destPoint)
        {
            switch (direction)
            {
                case DIRECTION.TOP: return (double) ANGLE.TOP;
                case DIRECTION.LEFT: return (double) ANGLE.LEFT;
                case DIRECTION.RIGHT: return (double) ANGLE.RIGHT;
                case DIRECTION.BOTTOM: return (double) ANGLE.BOTTOM;
                case DIRECTION.LEFTTOP: return ((double) ANGLE.LEFT) + calcurateOutAngle(nowPoint, destPoint);
                case DIRECTION.RIGHTTOP: return ((double) ANGLE.RIGHT) - calcurateOutAngle(nowPoint, destPoint);
                case DIRECTION.LEFTBOTTOM: return ((double) ANGLE.LEFT) - calcurateOutAngle(nowPoint, destPoint);
                case DIRECTION.RIGHTBOTTOM: return calcurateOutAngle(nowPoint, destPoint);
                default: return 0.0;
            }
        }

        private double calcurateOutAngle(Point nowPoint, Point destPoint)
        {
            double width = Math.Abs(destPoint.X - nowPoint.X);
            double hypotenuse = MyMathUtil.calculateLength(nowPoint, destPoint);

            return MyMathUtil.calculateOutAngle(hypotenuse, width);
        }

        public double angle { get; set; }

        public enum ANGLE
        {
            BOTTOM = 90,
            LEFT = 180,
            TOP = 270,
            RIGHT = 360
        }
    }
}
