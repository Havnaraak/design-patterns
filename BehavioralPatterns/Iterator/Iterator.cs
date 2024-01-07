

using Iterator.Interfaces;

namespace Iterator
{
    public class Iterator : IIterator
    {
        private IAggregate _agggregate;
        private int _position;

        public Iterator(IAggregate agggregate, int position = 0)
        {
            _agggregate = agggregate;
            _position = position;
        }

        public string Next
        {
            get
            {
                return _agggregate[_position++];
            }
        }


        public bool HasNext 
        {
            get
            {
                return _position <= _agggregate.Limit;
            }
        }
    }
}
