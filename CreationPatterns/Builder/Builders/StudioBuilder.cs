using Builder.Studios;

namespace Builder.Builders
{
    public abstract class StudioBuilder
    {
        protected Studio studio;

        public Studio GetStudio() => studio;

        
        public abstract void SelectFloor();

        public abstract void SelectFinancing();

        public abstract void SetStudioValue();

    }
}