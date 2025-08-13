using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Project_01
{
    internal class Point3D : IComparable<Point3D> , ICloneable
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        #endregion

        #region Constructors
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D() : this(0, 0, 0)
        {   
        }
        public Point3D(int x, int y) : this()
        {
        }
        public Point3D(int x) : this(x, 0)
        {
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }


        //public static bool operator ==(Point3D Left, Point3D Right)
        //{
        //    if (ReferenceEquals(Left, Right))
        //    {
        //        return true;
        //    }

        //    if (Left is null || Right is null)
        //    {
        //        return false;
        //    }

        //    return (Left.X == Right.X && Left.Y == Right.Y && Left.Z == Right.Z);
        //}
        //public static bool operator !=(Point3D p1, Point3D p2)
        //{
        //    return !(p1 == p2);
        //}

        public int CompareTo(Point3D? other)
        {
            int compareX = X.CompareTo(other.X);
            return compareX != 0 ? compareX : Y.CompareTo(other.Y);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        #endregion


    }
}
