using morseCodeApp.Models;

namespace morseCodeApp.Views
{
    public partial class MorseDecrypt : ContentPage
    {
        private MorseDictionary morseDictionrary = new MorseDictionary();

        public MorseDecrypt()
        {
            InitializeComponent();
        }

        private void MorseDot_Clicked(object sender, EventArgs e)
        {
            Encrypted_Text.Text += ".";
        }

        private void MorseDash_Clicked(object sender, EventArgs e)
        {
            Encrypted_Text.Text += "-";
        }

        private void BreakLine_Clicked(object sender, EventArgs e)
        {
            Encrypted_Text.Text += "\n";
        }

        private void SpaceBtn_Clicked(object sender, EventArgs e)
        {
            Encrypted_Text.Text += " ";
        }

        private void ClearAll_Clicked(object sender, EventArgs e)
        {
            Encrypted_Text.Text = string.Empty;
            Decrypted_Text.Text = string.Empty;
        }

        private void BackSpace_Clicked(object sender, EventArgs e)
        {
            if (Encrypted_Text.Text.Length > 0)
                Encrypted_Text.Text = Encrypted_Text.Text.Substring(0, Encrypted_Text.Text.Length - 1);
        }

        private void ConvertBtn_Clicked(object sender, EventArgs e)
        {
            Decrypted_Text.Text = string.Empty;

         
            string[] lines = Encrypted_Text.Text.Split(new[] { '\n' }, StringSplitOptions.None);

            foreach (string line in lines)
            {
         
                foreach (string item in line.Split(" "))
                {
                    if (morseDictionrary.morseCodeMap.ContainsKey(item))
                        Decrypted_Text.Text += morseDictionrary.morseCodeMap[item];
                    else
                        Decrypted_Text.Text += "_";
                }

                Decrypted_Text.Text += Environment.NewLine;
            }
        }

    }
}
