using DesignPatternsC.Objects;

public class CarBuilderFluent
{
    private Car _car = new Car();

    public CarBuilderFluent SetEngine(string engine)
    {
        _car.Engine = engine;
        return this;
    }

    public CarBuilderFluent SetWheels(int wheels)
    {
        _car.Wheels = wheels;
        return this;
    }

    public CarBuilderFluent SetGPS(bool hasGPS)
    {
        _car.HasGPS = hasGPS;
        return this;
    }

    public Car Build()
    {
        return _car;
    }
}
