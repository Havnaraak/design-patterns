using Builder.Studios;

namespace Builder.Builders
{
    public class Studio24mBuilder : StudioBuilder
    {
        public Studio24mBuilder()
        {
            studio = new Studio24m();
        }

        public override void SelectFinancing()
        {
            studio.SelectFinancing("RCA");
        }

        public override void SelectFloor()
        {
            studio.SelectFloor("wood");
        }

        public override void SetStudioValue()
        {
            studio.SetStudioValue(100.00M);
        }
    }
}