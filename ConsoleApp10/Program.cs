interface IAnimal
{
    public double Speed { get; set; }
}
interface IPredator : IAnimal
{
    public void Attack(IPrey prey);
}
interface IPrey : IAnimal
{

}
class Cat : IPredator
{
    double IAnimal.Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    void IPredator.Attack(IPrey prey)
    {
        throw new NotImplementedException();
    }
}
class Bird : IPrey
{
    public double Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
