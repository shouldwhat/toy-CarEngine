using System.Windows;

namespace AboutCarEngine
{
    public class CarNavigator
    {
        public DIRECTION search(Point nowPoint, Point destPoint)
        {
            //하 방향 이동의 경우
            if (nowPoint.X == destPoint.X && nowPoint.Y < destPoint.Y)
            {
                return DIRECTION.BOTTOM;
            }
            //상 방향 이동의 경우
            else if (nowPoint.X == destPoint.X && nowPoint.Y > destPoint.Y)
            {
                return DIRECTION.TOP;
            }
            //우 방향 이동의 경우
            else if (nowPoint.Y == destPoint.Y && nowPoint.X < destPoint.X)
            {
                return DIRECTION.RIGHT;
            }
            //좌 방향 이동의 경우
            else if(nowPoint.Y == destPoint.Y && nowPoint.X > destPoint.X)
            {
                return DIRECTION.LEFT;
            }
            //우상(1사분면) 방향 이동의 경우
            else if ((nowPoint.X < destPoint.X) && (nowPoint.Y > destPoint.Y))
            {
                return DIRECTION.RIGHTTOP;
            }
            //좌상(2사분면) 방향 이동의 경우
            else if (nowPoint.X > destPoint.X && nowPoint.Y > destPoint.Y)
            {
                return DIRECTION.LEFTTOP;
            }
            //좌하(3사분면) 방향 이동의 경우
            else if (nowPoint.X > destPoint.X && nowPoint.Y < destPoint.Y)
            {
                return DIRECTION.LEFTBOTTOM;
            }
            //우하(4사분면) 방향 이동의 경우
            else
            {
                return DIRECTION.RIGHTBOTTOM;
            }
        }
        public enum DIRECTION
        {
            LEFT = 1,
            RIGHT = 2,
            TOP = 3,
            BOTTOM = 4,
            RIGHTTOP = 5,
            LEFTTOP = 6,
            LEFTBOTTOM = 7,
            RIGHTBOTTOM = 8
        }
    }
}