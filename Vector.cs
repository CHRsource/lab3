#pragma warning disable
public class Vector
{
    public double[] Arr { get; set; }
    public Vector(double[] a) { Arr = a; }
    public Vector() : this(1)
    { }
    public Vector(int n) {
        if (n <= 0) { n = 1; }
        Arr = new double[n];
    }

    public void InputVec() { 
        for (int i = 0; i < Arr.Length; i++) { Arr[i] = Convert.ToDouble(Console.ReadLine()); }
    }
    public override string ToString()
    {
        string array = "";
        for (int i = 0; i < Arr.Length; i++) { array = array + Arr[i] + " "; }
        return array;
    }
    public double Module()
    {
        double sum_square = 0;
        for (int i = 0; i < Arr.Length; i++) { sum_square += Math.Pow(Arr[i], 2); }
        return Math.Round(Math.Sqrt(sum_square), 3);
    }
    public double MaxElem()
    {
        int ind = 0;
        for (int i = 1; i < Arr.Length; i++) { if (Arr[i] > Arr[ind]) ind = i; }
        return Arr[ind];
    }
    public int IndMinElem()
    {
        int ind = 0;
        for (int i = 1; i < Arr.Length; i++) { if (Arr[i] < Arr[ind]) ind = i; }
        return ind;
    }
    public Vector VecPositiveElem()
    {
        int size = 0, count = 0;
        for (int i = 0; i < Arr.Length; i++) { if (Arr[i] > 0) size++; }
        Vector arr_new = new(size);
        for (int i = 0; i < Arr.Length; i++) { if (Arr[i] > 0) arr_new.Arr[count++] = Arr[i]; }
        return arr_new;
    }
    public static Vector? Sum(Vector a, Vector b)
    {
        if (a.Arr.Length != b.Arr.Length) {
            return null;
        }
        Vector res = new(a.Arr.Length);
        for (int i = 0; i < a.Arr.Length; i++) { res.Arr[i] = a.Arr[i] + b.Arr[i]; }
        return res;
    }
    public static double? ScalarProduct(Vector a, Vector b)
    {
        if (a.Arr.Length != b.Arr.Length) {
            return null;
        }
        double res = 0;
        for (int i = 0; i < a.Arr.Length; i++) { res += a.Arr[i] * b.Arr[i]; }
        return res;
    }
    public static bool CheckEquality(Vector a, Vector b)
    {
        if (a.Arr.Length != b.Arr.Length) return false;
        for (int i = 0; i < a.Arr.Length; i++) {
            if (a.Arr[i] != b.Arr[i]) return false;
        }
        return true;
    }
}
