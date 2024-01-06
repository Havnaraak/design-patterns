namespace Prototype
{
    public class Studio : StudioModel
    {
        private string _studioType;
        private string _financingType;
        private decimal _studioValue;

        public Studio(string studioType, string financingType, decimal studioValue)
        {
            _studioType = studioType;
            _financingType = financingType;
            _studioValue = studioValue;            
        }

        public override StudioModel Clone()
        {
            Console.WriteLine("-", 4);
            Console.WriteLine($"Studio : {_studioType}");

            return this.MemberwiseClone() as StudioModel;
        }
    }
}