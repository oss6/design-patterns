namespace MediatorPattern
{
    public class Component
    {
        private readonly IMediator _dialog;

        public Component(IMediator dialog)
        {
            _dialog = dialog;
        }

        public void Click()
        {
            _dialog.Notify(this, "click");
        }

        public void KeyPress()
        {
            _dialog.Notify(this, "keypress");
        }
    }
}