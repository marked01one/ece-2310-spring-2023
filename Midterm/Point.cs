using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm
{
    public class Point
    {
        private double x; // x coordiate of Point
        private double y; // y coordinate of Point

        public void setPoint (double xCoor, double yCoor) {
            x = xCoor;
            y = yCoor;
        }

        public double dist(Point p)  // compute the distance of point p to the current point
        {
            double distance;
            distance = Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
            return distance;
        }
        public void print()
        {
            Console.Write("Point: ({0}, {1})", x, y);
        }
    }
}