using Builder.Studios;

namespace Builder.Builders
{
    public class Studio26mBuilder : StudioBuilder
    {
        public Studio26mBuilder()
        {
            studio = new Studio26m();
        }
        public override void SelectFinancing()
        {
            studio.SelectFinancing("RCA");
        }

        public override void SelectFloor()
        {
            studio.SelectFloor("stone");
        }

        public override void SetStudioValue()
        {
            studio.SetStudioValue(500.00M);
        }
    }
}