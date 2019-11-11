using System;

namespace BlazorApp.Data
{
    public class ResistorFiveBand: IResistor
    {
        public new string FirstBandColor { get; set; }
        public new string SecondBandColor { get; set; }
        public new string ThirdBandColor { get; set; }
        public new string MultiplierBandColor { get; set; }
        public new string ToleranceBandColor { get; set; }

        public new double Resistance
        {
            get
            {
                double digit = GetResistanceDigit();
                double multiplierValue = ResistorColorValue.Multiplier[MultiplierBandColor];
                return digit * multiplierValue;
            }
        }

        public new double Tolerance
        {
            get
            {
                double digit = GetResistanceDigit();
                double multiplierValue = ResistorColorValue.Multiplier[ToleranceBandColor];
                return digit * multiplierValue;
            }
        }

        // Constructor
        public ResistorFiveBand(
            string firstBandColor,
            string secondBandColor,
            string thirdBandColor,
            string multiplierBandColor, 
            string toleranceBandColor)
        {
            FirstBandColor = firstBandColor;
            SecondBandColor = secondBandColor;
            ThirdBandColor = thirdBandColor;
            MultiplierBandColor = multiplierBandColor;
            ToleranceBandColor = toleranceBandColor;
        }

        private double GetResistanceDigit()
        {
            string appendDigits =
                Array.IndexOf(ResistorColorValue.Bands, FirstBandColor).ToString() +
                Array.IndexOf(ResistorColorValue.Bands, SecondBandColor).ToString() +
                Array.IndexOf(ResistorColorValue.Bands, ThirdBandColor).ToString();

            double digit = Convert.ToDouble(appendDigits);

            return digit;
        }
    }
}
