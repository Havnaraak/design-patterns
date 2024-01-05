namespace Builder.Studios
{
    public abstract class Studio
    {
        public string? FloorType { get; protected set; }

        public string? FinancingType { get; protected set; }

        public decimal StudioValue { get; protected set; }


        public abstract void SelectFloor(string floorType);

        public abstract void SelectFinancing(string financingType);

        public abstract void SetStudioValue(decimal value);

    }
}