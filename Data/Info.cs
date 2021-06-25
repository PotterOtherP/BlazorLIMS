using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace BlazorLIMS.Data {

    public class Info {

        public static List<string> PlantCodes;
        public static List<string> WasteCodes;
        public static List<string> SolutionCodes;
        public static List<string> MediaCodes;

        public static void PopulateLists() {

            if (PlantCodes == null)
                PlantCodes = new List<string>();
            else
                PlantCodes.Clear();

            if (WasteCodes == null)
                WasteCodes = new List<string>();
            else
                WasteCodes.Clear();
            
            if (SolutionCodes == null)
                SolutionCodes = new List<string>();
            else
                SolutionCodes.Clear();

            if (MediaCodes == null)
                MediaCodes = new List<string>();
            else
                MediaCodes.Clear();

            using (var context = new PWSMDbContext())
            {
                foreach (var sample in context.SampleCodeTable)
                {
                    if (sample.Type.Equals("Plant"))
                        Info.PlantCodes.Add(sample.Name);

                    if (sample.Type.Equals("Waste"))
                        Info.WasteCodes.Add(sample.Name);

                    if (sample.Type.Equals("Solution"))
                        Info.SolutionCodes.Add(sample.Name);

                    if (sample.Type.Equals("Media"))
                        Info.MediaCodes.Add(sample.Name);
                }
            }

            Info.PlantCodes.Sort();
            Info.WasteCodes.Sort();
            Info.SolutionCodes.Sort();
            Info.MediaCodes.Sort();
            }

        public static readonly string[] PlantCodesArray = {

            "Alfalfa", "Amaranth", "Apple", "Apricot", "Artichoke", "Asparagus",
            "Barley", "Basil", "Beans", "Beets", "Blackberry", "Blueberry", "Broccoli",
            "Cabbage", "Cantaloupe", "Carinata", "Carrot", "Cauliflower", "Cedar", "Celery",
            "Chard", "Cherry", "Chrysanthemum", "Collards", "Corn", "Cotton",
            "Cranberry", "Crepe myrtle", "Cucumber",
            "Daffodil", "Dandelion", "Dogwood",
            "Eggplant", "Elm",
            "Fennel", "Fig", "Fir, Fraser",
            "Garlic", "Geranium", "Grape, Muscadine", "Grape, Vinifera",
            "Hay", "Honeydew", "Hops",
            "Ipomoea", "Iris",
            "Juniper",
            "Kale", "Kohlrabi",
            "Leek", "Lettuce",
            "Maple",
            "Nettle",
            "Oak", "Oats", "Okra", "Onion",
            "Parsley", "Parsnip", "Peach", "Peanut", "Pear", "Pecan", "Pepper", "Persimmon",
            "Pine", "Plum", "Poinsettia", "Pomegranate", "Poppy", "Potato", "Pumpkin",
            "Quinoa",
            "Radish", "Raspberry", "Rhubarb", "Rice", "Rye",
            "Sorghum", "Soybean", "Spinach", "Squash", "Strawberry", "Sweet potato", "Sunflower",
            "Tobacco", "Tomato", "Tulip", "Turnip",
            "Watermelon", "Wheat",
            "Yam",
            "Zucchini"
        };

        public static readonly string[] WasteCodesLiquidArray = {

            "ALS - Swine Lagoon Liquid",
            "ALP - Poultry Lagoon Liquid",
            "BID - Domestic septage",
            "GTL - Grease trap water",
            "LSB - Beef Slurry",
            "LSD - Dairy Slurry",
            "LSS - Swine Slurry",
            "NLF - Food/beverage by-products (liquid)",
            "NLO - Non-composted liquid"

        };

        public static readonly string[] WasteCodesSolidArray = {

            "BCO - Biosolids, composted",
            "BIX - Biosolids, mixed",
            "CSW - Wood ash",
            "CSC - Coal ash",
            "FCD - Composted manure - Dairy",
            "FCP - Composted manure - Poultry",
            "FCS - Composted manure - Swine",
            "FCW - Compost, plant material",
            "FCV - Vermicompost",
            "HLL - Chicken litter",
            "HLT - Turkey litter",
            "IOC - Paper fiber/pulp",
            "IOL - Lime by-products",
            "NBS - Wood waste/sawdust",
            "NCR - Raw plant material/crop residues",
            "NSF - Food/beverage by-products (solid)",
            "NSO - Non-composted solid",
            "SSD - Dairy Surface Scraped/Stockpiled",
            "SSS - Swine Surface Scraped/Stockpiled"

        };

        public static readonly string[] WasteCodesArray = {

            "ALS - Swine Lagoon Liquid",
            "ALP - Poultry Lagoon Liquid",
            "BID - Domestic septage",
            "BCO - Biosolids, composted",
            "BIX - Biosolids, mixed",
            "CSW - Wood ash",
            "CSC - Coal ash",
            "FCD - Composted manure - Dairy",
            "FCP - Composted manure - Poultry",
            "FCS - Composted manure - Swine",
            "FCW - Compost, plant material",
            "FCV - Vermicompost",
            "GTL - Grease trap water",
            "HLL - Chicken litter",
            "HLT - Turkey litter",
            "IOC - Paper fiber/pulp",
            "IOL - Lime by-products",
            "LSB - Beef Slurry",
            "LSD - Dairy Slurry",
            "LSS - Swine Slurry",
            "NBS - Wood waste/sawdust",
            "NCR - Raw plant material/crop residues",
            "NLF - Food/beverage by-products (liquid)",
            "NLO - Non-composted liquid",
            "NSF - Food/beverage by-products (solid)",
            "NSO - Non-composted solid",
            "SSD - Dairy Surface Scraped/Stockpiled",
            "SSS - Swine Surface Scraped/Stockpiled"


        };

        public static readonly string[] SolutionCodesArray = {

            "AS - Source Water",
            "AP - Pond Water",
            "FP - Fish Production/Recreation",
            "QG - Ground Water",
            "QS - Surface Water",
            "NS - General Nutrient Solution",
            "NT - Tobacco Nutrient Solution",
            "LC - Cattle Water",
            "LH - Horse Water",
            "LS - Swine Water",
            "IW - General Irrigation",
            "IO - Overhead Irrigation",
            "IT - Trickle Irrigation",
            "HT - Hydroponic Tomato",
            "HC - Hydroponic Cucumber",
            "HL - Hydroponic Lettuce",
            "SP - Pesticide Solution",
            "SH - Hydroponic Nutrient",
            "SF - Floriculture Production",
            "ST - Tobacco Transplant Production",
            "SV - Vegetable Transplant Production",

        };

        public static readonly string[] MediaCodesArray = {

            "GHF - GH Floriculture",
            "GHV - GH Vegetable",
            "NUR - Nursery Crop",
            "TOB - Tobacco Transplants",
            "OTH - Other"

        };

        public static readonly string[] PlantTestMenu = {

            "ICP",
            "Biomass",
            "C",
            "Cl",
            "DW",
            "HM",
            "Mo",
            "N",
            "NO3",

        };

        public static readonly string[] WasteTestMenu = {

            "ICP",
            "C",
            "CCE",
            "Cl",
            "DM",
            "EC",
            "HM",
            "Mo",
            "N",
            "NH4/NO3",
            "pH",
            "TKN",
            "Urea"

        };

        public static readonly string[] SolutionTestMenu = {

            "ICP",
            "CBC",
            "Cl",
            "EC",
            "HM",
            "Mo",
            "NH4/NO3",
            "pH",
            "Urea"

        };

        public static readonly string[] MediaTestMenu = {

            "ICP",
            "Bulk Density",
            "Cl",
            "EC",
            "HM",
            "Mo",
            "NH4/NO3",
            "pH",
            "Urea"

        };

        public static readonly string[] ICPTests = {

            "Al (ICP) ",    // Aluminum
            "B (ICP) ",     // Boron
            "Ca (ICP) ",    // Calcium
            "Cu (ICP) ",    // Copper
            "Fe (ICP) ",    // Iron
            "K (ICP) ",     // Potassium
            "Mg (ICP) ",    // Magnesium
            "Mn (ICP) ",    // Manganese
            "Na (ICP) ",    // Sodium
            "P (ICP) ",     // Phosphorus
            "S (ICP) ",     // Sulfur
            "Zn (ICP) ",    // Zinc

        };

        public static readonly string[] HMTests = {

            "Cd (HM)",  // Cadmium
            "Ni (HM)",  // Nickel
            "Pb (HM)"   // Lead

        };

    }
}