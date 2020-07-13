using System;

namespace ChainOfResponsibilityPattern
{
    public class AuthenticationHandler : BaseHandler
    {
        public override void Handle(IRequest request)
        {
            Console.WriteLine("Authentication Handler");

            if (((Request) request).Author == "J. R. R. Tolkien")
            {
                base.Handle(request);
            }
        }
    }
}