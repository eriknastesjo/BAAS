//namespace BAAS
//{
//    public partial class MainPage : ContentPage
//    {
//        int count = 0;
//        public const int FontSize = 22;

//        public MainPage()
//        {
//            InitializeComponent();
//        }

//        private void OnCounterClicked(object sender, EventArgs e)
//        {
//            count++;

//            if (count == 1)
//                CounterBtn.Text = $"Clicked {count} time";
//            else
//                CounterBtn.Text = $"Clicked {count} times";

//            SemanticScreenReader.Announce(CounterBtn.Text);
//        }
//    }

//    // Markup Extension can be used in all files. 
//    // As a project works it better to use static class - check Resources/SharedResources.cs
//    public class GlobalFontSizeExtension : IMarkupExtension
//    {
//        public object ProvideValue(IServiceProvider serviceProvider)
//        {
            
//            return MainPage.FontSize;
//        }
//    }

//}