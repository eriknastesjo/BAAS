namespace BAAS.Old;


// In this test page we use C# only to create a page (skipping the xaml file)
public class TestCsharp : ContentPage
{

	private int count = 0;
	Label labelCounter;

	public TestCsharp()	// CONSTRUCTOR
	{
		//Content = new VerticalStackLayout
		//{
		//	Children = {
		//		new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
		//		}
		//	}
		//};
		var scrollView = new ScrollView();
		var stackLayout = new StackLayout();

		scrollView.Content = stackLayout;

		labelCounter = new Label 
		{ 
			Text = "Hi there!",
			FontSize = 22,
			FontAttributes = FontAttributes.Bold,
			HorizontalOptions = LayoutOptions.Center,
		};
		stackLayout.Children.Add(labelCounter);

		var buttonCounter = new Button
		{
			Text = "This is my button",
			HorizontalOptions = LayoutOptions.Center,
		};
        buttonCounter.Clicked += OnClickedEvent;
		stackLayout.Children.Add(buttonCounter);

		this.Content = scrollView;
	}

    private void OnClickedEvent(object sender, EventArgs e)
    {
        count ++;
		labelCounter.Text = $"You dared click my button, {count} times??";
		SemanticScreenReader.Announce(labelCounter.Text);
    }
}