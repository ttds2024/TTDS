using System.Text;

namespace TTDS.WebAPI.Models
{
    public class CalculationData
    {
        public double FirstNumber { get; set; }
        public string Operation { get; set; }
        public double SecondNumber { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First number: {FirstNumber}");
            sb.AppendLine($"Operation: {Operation}");
            sb.AppendLine($"Second number: {SecondNumber}");

            return sb.ToString();
        }
    }
}
