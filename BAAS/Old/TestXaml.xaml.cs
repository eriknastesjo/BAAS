namespace BAAS;

public partial class TestXaml : ContentPage
{
	public TestXaml()
	{
        // This is autogenerating a contructor code from the content in the xaml file.
		InitializeComponent();
	}

    private void ClickEvent(object sender, EventArgs e)
    {
        int randomNumber = new Random().Next(1,7);
        DiceButton.Text = randomNumber.ToString();
        DiceComment.Text = randomNumber < 3 ? "So low..."
                         : randomNumber < 5 ? "Mediocre."
                         : "Wow, so high!!";

        SemanticScreenReader.Announce(DiceButton.Text);
        SemanticScreenReader.Announce(DiceComment.Text);
    }
}