namespace Composite.Model
{
    public abstract class ComponentModel
    {
        public abstract double Operation();

        public abstract void Add(params ComponentModel[] components);

        public abstract void Remove(ComponentModel component);

        public abstract ComponentModel GetChild(int index);
    }
}