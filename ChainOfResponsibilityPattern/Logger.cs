using System;

namespace ChainOfResponsibilityPattern
{
    public class Logger : BaseHandler
    {
        public override void Handle(IRequest request)
        {
            Console.WriteLine(request);
            base.Handle(request);
        }
    }
}