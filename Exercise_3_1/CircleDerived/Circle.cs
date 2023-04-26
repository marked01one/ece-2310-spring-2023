using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class Circle : Point
    {
        private double radius;
        public Circle(double xV, double yV, double r)
        {
            this.x = xV;
            this.y = yV;
            this.radius = r;
        }
        public void setRadius(double r) { radius = r > 0 ? radius : 0; }

        public bool onCircle(Point p) { return dist(p) == radius; }

        public bool inCircle(Point p) { return dist(p) < radius; }

        public bool outCircle(Point p) { return dist(p) > radius; }

        public bool intersect (Circle c)
        {
            Point p = new Point (), pCenter = new Point();
            p.setPoint (c.x, c.y);
            pCenter.setPoint (x, y);
            return pCenter.dist(p) < (radius + c.radius);
        }

        public bool tangentOut(Circle c)
        {
            Point p = new Point(), pCenter = new Point();
            p.setPoint(c.x, c.y);
            pCenter.setPoint(x, y);
            return pCenter.dist(p) == (radius + c.radius);
        }

        public bool tangentIn(Circle c)
        {
            Point p = new Point(), pCenter = new Point();
            p.setPoint(c.x, c.y);
            pCenter.setPoint(x, y);
            return pCenter.dist(p) == (radius - c.radius);
        }

        public bool disjoint(Circle c)
        {
            Point p = new Point(), pCenter = new Point();
            p.setPoint(c.x, c.y);
            pCenter.setPoint(x, y);
            return pCenter.dist(p) > (radius + c.radius);
        }

        public bool contained(Circle c)
        {
            Point p = new Point(), pCenter = new Point();
            p.setPoint(c.x, c.y);
            pCenter.setPoint(x, y);
            return (pCenter.dist(p) < (radius - c.radius)) && (radius > c.radius);
        }

        public void print()
        {
            Console.Write("Circle: ({0}, {1}, {2})", x, y, radius);
        }
    }

