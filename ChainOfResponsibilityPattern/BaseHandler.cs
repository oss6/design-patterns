namespace ChainOfResponsibilityPattern
{
    public class BaseHandler : IHandler
    {
        private IHandler _next;
        
        public void SetNext(IHandler handler)
        {
            _next = handler;
        }

        public virtual void Handle(IRequest request)
        {
            _next?.Handle(request);
        }
    }
}