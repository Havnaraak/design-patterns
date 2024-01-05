using Builder.Builders;
using Builder.Studios;

namespace Builder
{
    public class Client
    {
        public void ExecuteStudioData()
        {
            var director = new Director();
            StudioBuilder studioBuilder;
            Studio studio;

            studioBuilder = new Studio24mBuilder();
            director.BuildStudio(studioBuilder);
            studio = studioBuilder.GetStudio();
        }
    }
}