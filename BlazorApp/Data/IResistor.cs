namespace BlazorApp.Data
{
    public class IResistor
    {
        public string FirstBandColor { get; set; }
        public string SecondBandColor { get; set; }
#nullable enable
        public string? ThirdBandColor { get; set; }
#nullable disable
        public string MultiplierBandColor { get; set; }
        public string ToleranceBandColor { get; set; }
#nullable enable
        public string? TemperatureCoefficientBandColor { get; set; }
#nullable disable
        public double Resistance { get; }
        public double Tolerance { get; }
    }
}
