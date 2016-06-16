namespace SoftwareDesignPatterns.CreationalPatterns.FactoryMethod.metanit.com
{
    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
