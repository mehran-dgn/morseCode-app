using morseCodeApp.Models;
using System.Collections.ObjectModel;
namespace morseCodeApp.Views;

public partial class Learn : ContentPage
{
    public ObservableCollection<KeyValuePair<string, string>> MorseCodes { get; set; }
    public Learn()
    {
        InitializeComponent();
        MorseDictionary morseDictionary = new MorseDictionary();

        // Convert the dictionary to an observable collection  
        MorseCodes = new ObservableCollection<KeyValuePair<string, string>>(morseDictionary.ReverseMorseCodeMap);

        // Set the BindingContext for data binding  
        BindingContext = this;
    }
}