using BAAS.View;

namespace BAAS
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(SubmarineDetails), typeof(SubmarineDetails));  // Parameters: Route, Type
        }
    }
}