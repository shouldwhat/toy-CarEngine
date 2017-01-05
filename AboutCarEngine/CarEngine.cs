using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static AboutCarEngine.CarNavigator;

namespace AboutCarEngine
{
    public class CarEngine
    {
        public Point move(DIRECTION direction, double velocity, Point nowPoint, Point destPoint)
        {
            double movedX = this.calcurateMovedX(velocity, nowPoint, destPoint);
            double movedY = this.calcurateMovedY(velocity, nowPoint, destPoint);

            switch (direction)
            {
                case DIRECTION.TOP: return new Point(nowPoint.X, nowPoint.Y - movedY);
                case DIRECTION.LEFT: return new Point(nowPoint.X - movedX, nowPoint.Y);
                case DIRECTION.RIGHT: return new Point(nowPoint.X + movedX, nowPoint.Y);
                case DIRECTION.BOTTOM: return new Point(nowPoint.X, nowPoint.Y + movedY);
                case DIRECTION.LEFTTOP: return new Point(nowPoint.X - movedX, nowPoint.Y - movedY);
                case DIRECTION.RIGHTTOP: return new Point(nowPoint.X + movedX, nowPoint.Y - movedY);
                case DIRECTION.LEFTBOTTOM: return new Point(nowPoint.X - movedX, nowPoint.Y + movedY);
                case DIRECTION.RIGHTBOTTOM: return new Point(nowPoint.X + movedX, nowPoint.Y + movedY);
                default: return nowPoint;
            }
        }

        private double calcurateMovedX(double movedLength, Point nowPoint, Point destPoint)
        {
            double totalWidth = Math.Abs(destPoint.X - nowPoint.X);
            double totalLength = MyMathUtil.calculateLength(nowPoint, destPoint);

            return movedLength * (totalWidth / totalLength);
        }

        private double calcurateMovedY(double movedLength, Point nowPoint, Point destPoint)
        {
            double totalHeight = Math.Abs(destPoint.Y - nowPoint.Y);
            double totalLength = MyMathUtil.calculateLength(nowPoint, destPoint);

            return movedLength * (totalHeight / totalLength);
        }
    }
}
