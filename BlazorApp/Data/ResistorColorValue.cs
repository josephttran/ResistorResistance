using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class ResistorColorValue
    {
        public static string[] Bands =
        { 
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Violet",
            "Grey",
            "White"
        };

        public static readonly Dictionary<string, double> Multiplier = new Dictionary<string, double>
        {
            { "Black", 1 },
            { "Brown", 10 },
            { "Red", 100 },
            { "Orange", 1000 },
            { "Yellow", 10000 },
            { "Green", 100000 },
            { "Blue", 1000000 },
            { "Violet", 10000000 },
            { "Grey", 100000000 },
            { "White", 1000000000 },
            { "Gold", 0.1 },
            { "Silver", 0.01 }
        };

        public static readonly Dictionary<string, double> Tolerance = new Dictionary<string, double>
        {
            { "Brown", 0.01 },
            { "Red", 0.02 },
            { "Green", 0.005 },
            { "Blue", 0.0025 },
            { "Violet", 0.001 },
            { "Grey", 0.0005 },
            { "Gold", 0.05 },
            { "Silver", 0.10 },
            { "None", 0.20 }
        };
    }
}
