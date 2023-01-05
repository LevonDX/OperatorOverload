using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {

        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Math Operator
        public static Point operator +(Point a, Point b)
        {
            Point p = new Point(a.X + b.X, a.Y + b.Y);

            return p;
        }

        public static Point operator +(Point a, int x)
        {
            return new Point(a.X + x, a.Y + x);
        }

        public static Point operator ++(Point a)
        {
            a.X++;
            a.Y++;

            return a;
        }

        // Comparision operator
        public static bool operator >(Point a, Point b)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y) > Math.Sqrt(b.X * b.X + b.Y * b.Y);
        }
        public static bool operator <(Point a, Point b)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y) < Math.Sqrt(b.X * b.X + b.Y * b.Y);
        }
        public static bool operator ==(Point a, Point b)
        {
            return a.X == b.X && a.Y == b.Y;
        }
        public static bool operator !=(Point a, Point b)
        {
            return a.X != b.X || a.Y != b.Y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Point p = obj as Point;

            return p.X == this.X && p.Y == this.Y;
        }

        public override int GetHashCode()
        {
            return X ^ Y;
        }

        // logical operator              
        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0;
        }

        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0;
        }

        public static Point operator &(Point p1, Point p2)
        {
            if ((p1.X != 0 && p1.Y != 0) & (p2.X != 0 && p2.Y != 0))
                return new Point(1, 1);
            else
                return new Point(0, 0);
        }

        public static Point operator |(Point p1, Point p2)
        {
            if ((p1.X != 0 && p1.Y != 0) | (p2.X != 0 && p2.Y != 0))
                return new Point(1, 1);
            else
                return new Point(0, 0);
        }

        // Casting operator
        public static explicit operator string(Point p)
        {
            return p.X.ToString();
        }
    }
}