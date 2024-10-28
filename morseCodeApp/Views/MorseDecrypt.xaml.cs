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
                string decryptedLine = string.Empty;

                string morseCodeChar = string.Empty;

                foreach (char c in line)
                {
                    if (c == ' ')
                    {
                        if (!string.IsNullOrEmpty(morseCodeChar))
                        {
                            if (morseDictionrary.morseCodeMap.ContainsKey(morseCodeChar))
                            {
                                decryptedLine += morseDictionrary.morseCodeMap[morseCodeChar];
                            }
                            else
                            {
                                decryptedLine += "_"; 
                            }
                            morseCodeChar = string.Empty; 
                        }
                        
                        decryptedLine += " ";
                    }
                    else
                    {
                        morseCodeChar += c;
                    }
                }
                if (!string.IsNullOrEmpty(morseCodeChar))
                {
                    if (morseDictionrary.morseCodeMap.ContainsKey(morseCodeChar))
                    {
                        decryptedLine += morseDictionrary.morseCodeMap[morseCodeChar];
                    }
                    else
                    {
                        decryptedLine += "_";  
                    }
                }

                Decrypted_Text.Text += decryptedLine + Environment.NewLine;
            }
        }

    }
}
