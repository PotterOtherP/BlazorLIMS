namespace BlazorLIMS.Data {

    public class Info {

        public static readonly string[] PlantCodes = {

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

        public static readonly string[] WasteCodesLiquid = {

            // "ALS",
            // "ALP",
            // "BID",
            // "GTL",
            // "LSB",
            // "LSD",
            // "LSS",
            // "NLF",
            // "NLO",

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

        public static readonly string[] WasteCodesSolid = {

            // "BCO",
            // "BIX",
            // "CSW",
            // "CSC",
            // "FCD",
            // "FCP",
            // "FCS",
            // "FCW",
            // "FCV",
            // "HLL",
            // "HLT",
            // "IOC",
            // "IOL",
            // "NBS",
            // "NCR",
            // "NSF",
            // "NSO",
            // "SSD",
            // "SSS",

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

        public static readonly string[] WasteCodes = {

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

        public static readonly string[] SolutionCodes = {

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

        public static readonly string[] MediaCodes = {

            "GHF - GH Floriculture",
            "GHV - GH Vegetable",
            "NUR - Nursery Crop",
            "TOB - Tobacco Transplants",
            "OTH - Other"

        };

        public static readonly string[] AllTests = {

            // "Biomass",
            // "Bulk Density",
            // "C (Carbon)",
            // "CBC (Carb/Bicarb)",
            // "CCE (Lime Equivalence)",
            // "Cl (Chloride)",
            // "DM (Dry Matter)",
            // "DW (Dry Weight)",
            // "EC (Electrical Conductivity)",
            // "HM (Heavy Metals)",
            // "ICP (Spectroscopy)",
            // "Mo (Molybdenum)",
            // "N (Nitrogen)",
            // "NH4/NO3 (Nitrogen breakout)",
            // "NO3 (Nitrate)",
            // "pH",
            // "TKN (Total Kjeldahl Nitrogen)",
            // "Urea",

            "Biomass",
            "Bulk Density",
            "C",
            "CBC",
            "CCE",
            "Cl",
            "DM",
            "DW",
            "EC",
            // "HM",
            // "ICP",
            "Mo",
            "N",
            "NH4/NO3",
            "NO3",
            "pH",
            "TKN",
            "Urea"
        };

        public static readonly string[] ICPTests = {

            "Al (ICP) ",
            "B (ICP) ",
            "Ca (ICP) ",
            "Cu (ICP) ",
            "Fe (ICP) ",
            "K (ICP) ",
            "Mg (ICP) ",
            "Mn (ICP) ",
            "Na (ICP) ",
            "P (ICP) ",
            "S (ICP) ",
            "Zn (ICP) ",

            // "Al (Aluminium)",
            // "B (Boron)",
            // "Ca (Calcium)",
            // "Cu (Copper)",
            // "Fe ((ron)",
            // "K (Potassium)",
            // "Mg (Magnesium)",
            // "Mn (Manganese)",
            // "Na (Sodium)",
            // "P (Phosphorus)",
            // "S (Sulfur)",
            // "Zn (Zinc)",

        };

        public static readonly string[] HMTests = {

            "Cd (HM)",
            "Ni (HM)",
            "Pb (HM)"

        };

    }
}