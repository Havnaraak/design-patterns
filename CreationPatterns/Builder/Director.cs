using Builder.Builders;

namespace Builder
{
    public class Director
    {
        public void BuildStudio(StudioBuilder studioBuilder)
        {
            studioBuilder.SelectFloor();
            studioBuilder.SelectFinancing();
            studioBuilder.SetStudioValue();
        }
    }
}