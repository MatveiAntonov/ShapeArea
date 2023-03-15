namespace ShapeArea.Shapes;

public class Triangle : Shape
{
    #region Private fields

    /// <summary>
    /// Стороны треугольника
    /// </summary>
    private readonly (double a, double b, double c) _sides;

    #endregion

    #region Constructors

    /// <summary>
    /// Треугольник
    /// </summary>
    /// <param name="a">Сторона a</param>
    /// <param name="b">Сторона b</param>
    /// <param name="c">Сторона c</param>
    /// <exception cref="ArgumentOutOfRangeException">При отрицальной стороне</exception>
    public Triangle(double a, double b, double c)
    {
        if (a < 0 || b < 0 || c < 0)
        {
            throw new ArgumentOutOfRangeException("Сторона должна быть положительным числом");
        }
        _sides = (a, b, c);
    }

    #endregion

    #region Methods
    /// <summary>
    /// Вычисление площади треугольника
    /// </summary>
    /// <returns>Площадь треугольника</returns>
    public override double CalculateArea()
    {
        double p = (_sides.a + _sides.b + _sides.c) / 2;
        return Math.Sqrt(p * (p - _sides.a) * (p - _sides.b) * (p - _sides.c));
    }

    /// <summary>
    /// Проверка на прямоугольный треугольник
    /// </summary>
    /// <returns>True, если треугольник прямоугольный, иначе False</returns>
    public bool IsRightTriangle()
    {
        double[] sides = new double[] { _sides.a, _sides.b, _sides.c };
        Array.Sort(sides);
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }

    #endregion 
}