namespace Lesson5
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Operations with vectors.");
            Console.ReadLine();

            Vector vector1 = new Vector(1, -2, 3);
            Vector vector2 = new Vector(-4, 5, 6);

            Console.WriteLine("Vector 1: " + vector1.ToString());
            Console.WriteLine("Vector 2: " + vector2.ToString());
            Console.ReadLine();

            Console.WriteLine($"Vector 1 modulus: " + vector1.Mod().ToString("f5"));
            Console.WriteLine($"Vector 2 modulus: " + vector2.Mod().ToString("f5"));
            Console.ReadLine();

            Console.WriteLine($"Scalar product of vectors: {Vector.ScalarMul(vector1, vector2)}");
            Console.ReadLine();

            Console.WriteLine("Vector product of vectors: " + (vector1 * vector2).ToString());
            Console.ReadLine();

            Console.WriteLine($"Cosine of the angle between vectors: " + Vector.CosAngle(vector1, vector2).ToString("f8"));
            Console.ReadLine();

            Console.WriteLine("Sum of vectors: " + (vector1 + vector2).ToString());
            Console.ReadLine();

            Console.WriteLine("Vector difference: " + (vector1 - vector2).ToString());
            Console.ReadLine();
        }
    }
}