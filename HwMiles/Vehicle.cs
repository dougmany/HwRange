namespace HwMiles
{

    public class MenuItem
    {
        public string Text { get; set; }

        public string Value { get; set; }
    }

    public class MenuItems
    {
        public List<MenuItem> MenuItem { get; set; }
    }

    public class VehicleParameters
    {
        public VehicleParameters()
        {
            Years = new List<MenuItem>();
            Makes = new List<MenuItem>();
            Models = new List<MenuItem>();
            ModelOptions = new List<MenuItem>();
        }
        public int VehicleID { get; set; }
        public String Year { get; set; }
        public String Make { get; set; }
        public String Model { get; set; }
        public List<MenuItem> ModelOptions { get; set; }
        public List<MenuItem> Years { get; set; }
        public List<MenuItem> Makes { get; set; }
        public List<MenuItem> Models { get; set; }

    }

    public class Vehicle
    {
        public String atvType { get; set; }
        public double barrels08 { get; set; }
        public double barrelsA08 { get; set; }
        public double charge120 { get; set; }
        public double charge240 { get; set; }
        public double charge240b { get; set; }
        public double city08 { get; set; }
        public double city08U { get; set; }
        public double cityA08 { get; set; }
        public double cityA08U { get; set; }
        public double cityCD { get; set; }
        public double cityE { get; set; }
        public double cityUF { get; set; }
        public double co2 { get; set; }
        public double co2A { get; set; }
        public double co2TailpipeAGpm { get; set; }
        public double co2TailpipeGpm { get; set; }
        public double comb08 { get; set; }
        public double comb08U { get; set; }
        public double combA08 { get; set; }
        public double combA08U { get; set; }
        public double combE { get; set; }
        public double combinedCD { get; set; }
        public double combinedUF { get; set; }
        public DateTime createdOn { get; set; }
        public String drive { get; set; }
        public double engId { get; set; }
        public String eng_dscr { get; set; }
        public double feScore { get; set; }
        public double fuelCost08 { get; set; }
        public double fuelCostA08 { get; set; }
        public String fuelType { get; set; }
        public String fuelType1 { get; set; }
        public String fuelType2 { get; set; }
        public double ghgScore { get; set; }
        public double ghgScoreA { get; set; }
        public double highway08 { get; set; }
        public double highway08U { get; set; }
        public double highwayA08 { get; set; }
        public double highwayA08U { get; set; }
        public double highwayCD { get; set; }
        public double highwayE { get; set; }
        public double highwayUF { get; set; }
        public double hlv { get; set; }
        public double hpv { get; set; }
        public double id { get; set; }
        public double lv2 { get; set; }
        public double lv4 { get; set; }
        public String make { get; set; }
        public String mfrCode { get; set; }
        public String model { get; set; }
        public DateTime modifiedOn { get; set; }
        public String mpgData { get; set; }
        public string mpgRevised { get; set; }
        public string phevBlended { get; set; }
        public double phevCity { get; set; }
        public double phevComb { get; set; }
        public double phevHwy { get; set; }
        public double pv2 { get; set; }
        public double pv4 { get; set; }
        public double range { get; set; }
        public double rangeCity { get; set; }
        public double rangeCityA { get; set; }
        public double rangeHwy { get; set; }
        public double rangeHwyA { get; set; }
        public String trany { get; set; }
        public double UCity { get; set; }
        public double UCityA { get; set; }
        public double UHighway { get; set; }
        public double UHighwayA { get; set; }
        public String VClass { get; set; }
        public int year { get; set; }
        public double youSaveSpend { get; set; }
        public double UsableBattery { get; set; }

        public double highwayEover100
        {
            get
            {
                if (highwayE > 0)
                {
                    return Math.Round(100 / highwayE, 5);
                }
                return 0;
            }
        }
        public double CalculatedRange 
        {
            get {
                if (highwayE > 0 && UsableBattery > 0)
                {
                    return Math.Round(UsableBattery * 100 / highwayE, 5);
                }
                return 0;
            }
        }
    }
}










































































