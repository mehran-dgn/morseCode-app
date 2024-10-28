using morseCodeApp.Models;
namespace morseCodeApp.Views;

public partial class MorseGenerator : ContentPage
{
    private MorseDictionary morseDictionary = new MorseDictionary();
	public MorseGenerator()
	{
		InitializeComponent();
	}
	private void OnLetterClicked(object sender , EventArgs e)
	{
        if (sender is Button btn)
            Decrypted_Text.Text += btn.Text.Trim();
	}

    private void OnSpaceClicked(object sender, EventArgs e)
    {
        Decrypted_Text.Text += " ";
    }

    private void OnClearAllClicked(object sender, EventArgs e)
    {
        Decrypted_Text.Text =string.Empty;
        Encrypted_Text.Text = string.Empty;
    }

    private void OnBackspaceClicked(object sender, EventArgs e)
    {
        if (Decrypted_Text.Text.Length > 0)
            Decrypted_Text.Text = Decrypted_Text.Text.Substring(0, Decrypted_Text.Text.Length - 1);
    }

    private void OnNewLineClicked(object sender, EventArgs e)
    {
        Decrypted_Text.Text += "\n";
    }
    private void ConvertToMorse(object sender, EventArgs e)
    {
        Encrypted_Text.Text = string.Empty;

        string[] lines = Decrypted_Text.Text.Split(new[] { '\n' }, StringSplitOptions.None);
 
        foreach (string line in lines)
        {
            foreach (char innerItem in line)
            {
                string character = innerItem.ToString().ToUpper();
 
                if (morseDictionary.ReverseMorseCodeMap.ContainsKey(character))
                {
                    Encrypted_Text.Text += morseDictionary.ReverseMorseCodeMap[character] + " ";
                }
                else
                { 
                    Encrypted_Text.Text += " ";
                }
            }

            Encrypted_Text.Text += Environment.NewLine;
        }
    }

}