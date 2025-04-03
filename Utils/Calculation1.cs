using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp0312.MyTask1Classes;

namespace ConsoleApp0312
{
    public class Calculation1
    {
        
        public static CircleResult FindBestCircle(List<Point> points)
        {
            int maxCount = 0;
            CircleResult bestCircle = null;

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var circle = GetCircle(points[i], points[j]);
                    int count = CountPointsInCircle(points, circle);

                    if (count > maxCount)
                    {
                        maxCount = count;
                        bestCircle = circle;
                    }
                }
            }

            return bestCircle;
        }

        public static CircleResult GetCircle(Point p1, Point p2)
        {
            var centerX = (p1.X + p2.X) / 2;
            var centerY = (p1.Y + p2.Y) / 2;
            var radius = Distance(p1, new Point(centerX, centerY));

            return new CircleResult
            {
                Center = new Point(centerX, centerY),
                Radius = radius,
                PointCount = 0
            };
        }

        public static int CountPointsInCircle(List<Point> points, CircleResult circle)
        {
            int count = 0;
            foreach (var point in points)
            {
                if (Distance(point, circle.Center) <= circle.Radius)
                {
                    count++; 
                }
            }
            circle.PointCount = count;
            return count;
        }

        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
        
}
