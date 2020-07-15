namespace MediatorPattern
{
    public interface IMediator
    {
        void Notify(Component sender, string evt);
    }
}