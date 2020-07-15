namespace MediatorPattern
{
    public class AuthenticationDialog : IMediator
    {
        private string _title;
        private Textbox _loginUsername;
        private Textbox _loginPassword;
        private Button _okButton;

        public AuthenticationDialog()
        {
            _title = "Hello";
            _loginUsername = new Textbox(this);
            _loginPassword = new Textbox(this);
            _okButton = new Button(this);
        }
        
        public void Notify(Component sender, string evt)
        {
            // ...
        }
    }
}