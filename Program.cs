Vector a = new();
Console.WriteLine($"Введите вектор из {a.Arr.Length} вещественных чисел:");
a.InputVec();
Console.WriteLine("Массив: " + a);

a = new(10);
Console.WriteLine("Массив: " + a);
a.InputVec();
Console.WriteLine("Массив: " + a);
Console.WriteLine(a.MaxElem());
Console.WriteLine(a.IndMinElem());

Vector b = a.VecPositiveElem();
Console.WriteLine("Массив: " + b);

a = new(new double[] { 1, 2.0, 3.5, -5.1 });
Console.WriteLine("Массив: " + a);
Console.WriteLine(a.Module());

Vector first = new(new double[] { 1, 8, 43 });
//Vector second = new(new double[] { 9, -45.4, 0 });
Vector second = new(new double[] { 1, 8, 43 });
Vector? sum = Vector.Sum(first, second);
if (sum == null)
    Console.WriteLine("Векторы разной размерности. Суммы не существует.");
else Console.WriteLine("Массив из суммы: " + sum);

double? scal_prod = Vector.ScalarProduct(first, second);
if (scal_prod == null) Console.WriteLine("Векторы разной размерности. Скалярного произведения не существует.");
else Console.WriteLine($"Скалярное произведение векторов = {scal_prod}");

if (Vector.CheckEquality(first, second)) { Console.WriteLine("Векторы равны"); }
else Console.WriteLine("Векторы не равны");
