namespace BuilderPattern
{
    public class EmailBuilder
    {
        private Email _email = new Email();

        public EmailBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _email = new Email();
        }

        public void AddFrom()
        {
            
        }

        public void AddTo()
        {
            
        }

        public void AddContent()
        {
            
        }

        public Email GetEmail()
        {
            var result = _email;
            
            Reset();

            return result;
        }
    }
}