using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextToPhonetic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private bool TextBoxInput_isInitialized = false;

        private void TextBoxInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            TextBox input = TextBoxInput;
            if (TextBoxInput_isInitialized)
            {
                string newText = TextBoxInput.Text.ToLower();

                ListBoxOutput.Items.Clear();

                char[] chars = new char[newText.Length];

                chars = newText.ToCharArray();

                int counter = 1;

                foreach (char ch in chars)
                {
                    ListBoxOutput.Items.Add(counter.ToString() + ". " + GetWordFromChar(ch).ToUpper());
                    counter++;
                }
            }
        }

        private string GetWordFromChar(char ch)
        {
            string word = string.Empty;
            string strChar = char.ToString(ch);

            //"NATO (Alpha, Bravo, ...)"
            if (ComboBoxOutputType.SelectedIndex == 0)
            {
                switch (strChar)
                {
                    case "a": word = "Alpha"; break;
                    case "b": word = "Bravo"; break;
                    case "c": word = "Charlie"; break;
                    case "d": word = "Delta"; break;
                    case "e": word = "Echo"; break;
                    case "f": word = "Foxtrot"; break;
                    case "g": word = "Golf"; break;
                    case "h": word = "Hotel"; break;
                    case "i": word = "India"; break;
                    case "j": word = "Juliet"; break;
                    case "k": word = "Kilo"; break;
                    case "l": word = "Lima"; break;
                    case "m": word = "Mike"; break;
                    case "n": word = "November"; break;
                    case "o": word = "Oskar"; break;
                    case "p": word = "Papa"; break;
                    case "q": word = "Quebec"; break;
                    case "r": word = "Romeo"; break;
                    case "s": word = "Sierra"; break;
                    case "t": word = "Tango"; break;
                    case "u": word = "Uniform"; break;
                    case "v": word = "Victor"; break;
                    case "w": word = "Wiskey"; break;
                    case "x": word = "XRay"; break;
                    case "y": word = "Yankee"; break;
                    case "z": word = "Zulu"; break;

                    case "0": word = "ZEE-RO"; break;
                    case "1": word = "WUN"; break;
                    case "2": word = "TOO"; break;
                    case "3": word = "TREE"; break;
                    case "4": word = "FOW-ER"; break;
                    case "5": word = "FIFE"; break;
                    case "6": word = "SIX"; break;
                    case "7": word = "SEV-EN"; break;
                    case "8": word = "AIT"; break;
                    case "9": word = "NIN-ER"; break;

                    default: word = strChar; break;
                }
                return word;
            }

            //GERMAN (Anton, Berta, ...)
            if (ComboBoxOutputType.SelectedIndex == 1)
            {
                switch (strChar)
                {
                    case "a": word = "Anton"; break;
                    case "b": word = "Berta"; break;
                    case "c": word = "Caesar"; break;
                    case "d": word = "Dora"; break;
                    case "e": word = "Emil"; break;
                    case "f": word = "Friedrich"; break;
                    case "g": word = "Gustav"; break;
                    case "h": word = "Heinrich"; break;
                    case "i": word = "Ida"; break;
                    case "j": word = "Julius"; break;
                    case "k": word = "Kaufmann"; break;
                    case "l": word = "Ludwig"; break;
                    case "m": word = "Martha"; break;
                    case "n": word = "Nordpol"; break;
                    case "o": word = "Otto"; break;
                    case "p": word = "Paula"; break;
                    case "q": word = "Quelle"; break;
                    case "r": word = "Richard"; break;
                    case "s": word = "Samuel"; break;
                    case "t": word = "Theodor"; break;
                    case "u": word = "Ulrich"; break;
                    case "v": word = "Viktor"; break;
                    case "w": word = "Wilhelm"; break;
                    case "x": word = "Xantippe"; break;
                    case "y": word = "Xantippe"; break;
                    case "z": word = "Zacharias"; break;

                    case "0": word = "Null"; break;
                    case "1": word = "Eins"; break;
                    case "2": word = "Zwei"; break;
                    case "3": word = "Drei"; break;
                    case "4": word = "Vier"; break;
                    case "5": word = "Fünf"; break;
                    case "6": word = "Sechs"; break;
                    case "7": word = "Sieben"; break;
                    case "8": word = "Acht"; break;
                    case "9": word = "Neun"; break;

                    default: word = strChar; break;
                }
                return word;
            }

            //GERMAN (Aachen, Berlin, ...)
            if (ComboBoxOutputType.SelectedIndex == 2)
            {
                switch (strChar)
                {
                    case "a": word = "Aachen"; break;
                    case "b": word = "Berlin"; break;
                    case "c": word = "Chemnitz"; break;
                    case "d": word = "Düsseldorf"; break;
                    case "e": word = "Essen"; break;
                    case "f": word = "Frankfurt"; break;
                    case "g": word = "Goslar"; break;
                    case "h": word = "Hamburg"; break;
                    case "i": word = "Ingelheim"; break;
                    case "j": word = "Jena"; break;
                    case "k": word = "Köln"; break;
                    case "l": word = "Leipzip"; break;
                    case "m": word = "München"; break;
                    case "n": word = "Nürnberg"; break;
                    case "o": word = "Offenbach"; break;
                    case "p": word = "Potsdam"; break;
                    case "q": word = "Quickborn"; break;
                    case "r": word = "Rostock"; break;
                    case "s": word = "Salzwedel"; break;
                    case "ß": word = "Eszett"; break;
                    case "t": word = "Tübingen"; break;
                    case "u": word = "Unna"; break;
                    case "v": word = "Völklingen"; break;
                    case "w": word = "Wuppertal"; break;
                    case "x": word = "Xanten"; break;
                    case "y": word = "Ypsilon"; break;
                    case "z": word = "Zwickau"; break;

                    case "0": word = "Null"; break;
                    case "1": word = "Eins"; break;
                    case "2": word = "Zwei"; break;
                    case "3": word = "Drei"; break;
                    case "4": word = "Vier"; break;
                    case "5": word = "Fünf"; break;
                    case "6": word = "Sechs"; break;
                    case "7": word = "Sieben"; break;
                    case "8": word = "Acht"; break;
                    case "9": word = "Neun"; break;

                    default: word = strChar; break;
                }
                return word;
            }
            return word;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ComboBoxOutputType_Initialized(object sender, EventArgs e)
        {
            ComboBoxOutputType.Items.Add("NATO (Alpha, Bravo, ...)");
            ComboBoxOutputType.Items.Add("GERMAN (Anton, Berta, ...)");
            ComboBoxOutputType.Items.Add("GERMAN (Aachen, Berlin, ...)");

            ComboBoxOutputType.SelectedIndex = 0;
        }

        private void ComboBoxOutputType_SelectionChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void TextBoxInput_Initialized(object sender, EventArgs e)
        {
            TextBoxInput_isInitialized = true;
        }
    }
}