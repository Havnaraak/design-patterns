namespace Prototype
{
    public class SalesManagerStudio
    {
        private Dictionary<string, StudioModel> studioModel = new();

        public StudioModel this[string key]
        {
            get { return studioModel[key]; }
            set { studioModel[key] = value; }
        }
    }
}