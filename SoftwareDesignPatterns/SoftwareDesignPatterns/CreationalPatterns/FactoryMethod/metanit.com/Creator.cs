namespace SoftwareDesignPatterns.CreationalPatterns.FactoryMethod.metanit.com
{
    /// <summary>
    /// Абстрактный класс Creator определяет абстрактный фабричный метод FactoryMethod(), который возвращает объект Product.
    /// </summary>
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}
