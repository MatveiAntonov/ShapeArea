namespace ShapeArea.Shapes;

public class Circle : Shape
{
    #region Private fields

    /// <summary>
    /// Радиус окружности
    /// </summary>
    private readonly double _radius;

    #endregion

    #region Constructors

    /// <summary>
    /// Окружность
    /// </summary>
    /// <param name="radius">Радиус окружности</param>
    /// <exception cref="ArgumentOutOfRangeException">При отрицательном радиусе</exception>
    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentOutOfRangeException("Радиус должен быть положительным числом");
        }
        _radius = radius;
    }
    #endregion

    #region Methods

    /// <summary>
    /// Вычислить площадь окружности
    /// </summary>
    /// <returns>Площадь окружности</returns>
    public override double CalculateArea() => Math.PI * Math.Pow(_radius, 2);

    #endregion
}
