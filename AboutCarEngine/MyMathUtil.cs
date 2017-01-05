using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AboutCarEngine
{
    public static class MyMathUtil
    {
        /// <summary>
        /// 밑변(width)과 높이(height)를 알 때, 빗변(hypotenuse) 길이 계산 (a.k.a 피타고라스 정리)
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static double calculateHypotenuse(double width, double height)
        {
            return Math.Round(Math.Sqrt((width * width) + (height * height)), 2);
        }

        /// <summary>
        /// 두 점(startPoint, endPoint) 사이의 길이 계산
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="endPoint"></param>
        /// <returns></returns>
        public static double calculateLength(Point startPoint, Point endPoint)
        {
            double width = Math.Abs(endPoint.X - startPoint.X);
            double height = Math.Abs(endPoint.Y - startPoint.Y);

            return MyMathUtil.calculateHypotenuse(width, height);
        }

        /// <summary>
        /// 빗변(hypotenuse)과 밑변(width)을 알 때, 바깥쪽 각도 계산
        /// </summary>
        /// <param name="hypotenuse"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static double calculateOutAngle(double hypotenuse, double width)
        {
            return Math.Round((Math.Acos(width / hypotenuse) * (180 / Math.PI)), 2);
        }
    }
}
