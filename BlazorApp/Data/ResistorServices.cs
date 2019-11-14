using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class ResistorServices
    {
        public ResistorFiveBand ResistorFiveBand { get; set; }

        public ResistorServices()
        {
            ResistorFiveBand = new ResistorFiveBand()
            {
                FirstBandColor = ResistorColorValue.Bands[0],
                SecondBandColor = ResistorColorValue.Bands[0],
                ThirdBandColor = ResistorColorValue.Bands[0],
                MultiplierBandColor = "Black",
                ToleranceBandColor = "Brown"
            };
        }

        public string[] GetBands()
        {
            return ResistorColorValue.Bands;
        }

        public Dictionary<string, double> GetMultipliers()
        {
            return ResistorColorValue.Multiplier;
        }

        public Dictionary<string, double> GetTolerances()
        {
            return ResistorColorValue.Tolerance;
        }
    }
}
