namespace Builder.Studios
{
    public class Studio26m : Studio
    {
        public override void SelectFinancing(string financingType)
        {
            FinancingType = financingType; 
        }

        public override void SelectFloor(string floorType)
        {
            FloorType = floorType;
        }

        public override void SetStudioValue(decimal value)
        {
            StudioValue = value;
        }
    }
}