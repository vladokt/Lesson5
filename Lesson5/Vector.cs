namespace Lesson5
{
    public class Vector
    {
        public int x, y, z;
        public Vector(int xcoord, int ycoord, int zcoord)
        {
            x = xcoord;
            y = ycoord;
            z = zcoord;
        }

        public override string ToString()
        {
            return $"(x = {x}, y = {y}, z = {z})";
        }
        public double Mod()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public static double ScalarMul(Vector v1,Vector v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }

        public static Vector operator * (Vector v1, Vector v2)
        {
            return new Vector(v1.y * v2.z - v1.z * v2.y, v1.z * v2.x - v1.x * v2.z, v1.x * v2.y - v1.y * v2.x);
        }

        public static double CosAngle(Vector v1, Vector v2)
        {
            return Vector.ScalarMul(v1, v2) / (v1.Mod() * v2.Mod());
        }

        public static Vector operator + (Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }
    }
}
