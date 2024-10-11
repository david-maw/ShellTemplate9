namespace ShellTemplate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = base.CreateWindow(activationState);
#if WINDOWS
            window.Height = 600;
            window.Width = 400;
#endif          
            return window;
        }
    }
}
