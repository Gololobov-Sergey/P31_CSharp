using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_CSharp
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }

        static public Point operator -(Point p)
        {
            return new Point(-p.X, -p.Y);
        }

        static public Point operator ++(Point p)
        {
            return new Point(++p.X, ++p.Y);
        }

        static public Point operator --(Point p)
        {
            return new Point(--p.X, --p.Y);
        }

        static public Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        static public Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }

        static public Point operator *(Point p1, Point p2)
        {
            return new Point(p1.X * p2.X, p1.Y * p2.Y);
        }

        static public Point operator *(Point p1, int n)
        {
            return new Point(p1.X * n, p1.Y * n);
        }

        static public Point operator *(int n, Point p1)
        {
            return p1 * n;
        }

        static public Point operator /(Point p1, Point p2)
        {
            return new Point(p1.X / p2.X, p1.Y / p2.Y);
        }

        static public bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        static public bool operator !=(Point p1, Point p2)
        {
            return false;
        }

        public override bool Equals(object? obj)
        {
            Point p = (Point)obj;
            return X == p.X && Y == p.Y;
        }


        static public bool operator true(Point p1)
        {
            return p1.X != 0 || p1.Y != 0;
        }

        static public bool operator false(Point p1)
        {
            return p1.X == 0 && p1.Y == 0;
        }

        static public Point operator &(Point p1, Point p2)
        {
            return new Point(p1.X & p2.X, p1.Y & p2.Y);
        }

        static public Point operator |(Point p1, Point p2)
        {
            return new Point(p1.X | p2.X, p1.Y | p2.Y);
        }

        static public Point operator ^(Point p1, Point p2)
        {
            return new Point(p1.X ^ p2.X, p1.Y ^ p2.Y);
        }

        static public Point operator ~(Point p1)
        {
            return new Point(~p1.X, ~p1.Y);
        }

        static public /*explicit*/ implicit operator float(Point p)
        {
            return (float)Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }


    }
}
