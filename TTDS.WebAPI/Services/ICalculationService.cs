namespace TTDS.WebAPI.Services
{
    public interface ICalculationService
    {
        double? Sum(double a, double b);
        double? Difference(double a, double b);
    }
}
