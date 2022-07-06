using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace Avaruz.DataGridViewAutoFilter
{
  class LanguageHandler
  {
    internal static LanguageHandler handler = new LanguageHandler();
    internal static ComboBox languageSelector;
    internal static string userChoice;
    internal static ResourceManager resourceManager;

    private LanguageHandler()
    {
    }

    /// <summary>
    /// Checks the for language set by the user
    /// </summary>
    internal void CheckUserChoice()
    {
      switch (Properties.Settings.Default.Language)
      {
        case "ar": userChoice = "ar"; break;
        case "ur": userChoice = "ur"; break;
        case "es": userChoice = "es"; break;
        case "ja": userChoice = "ja"; break;
        case "zh": userChoice = "zh"; break;
        case "en": userChoice = "en"; break;
        case "ru": userChoice = "ru"; break;
      }

      resourceManager = new ResourceManager("DataGridViewAutoFilter.lang_" + userChoice,
                                            Assembly.GetExecutingAssembly());
    }
    /// <summary>
    /// Sets the language selector to the user's choosen language
    /// </summary>
    internal void SetLanguageSelector()
    {
      switch (Properties.Settings.Default.Language)
      {
        case "ar": languageSelector.SelectedIndex = 0; break;
        case "ur": languageSelector.SelectedIndex = 1; break;
        case "es": languageSelector.SelectedIndex = 2; break;
        case "ja": languageSelector.SelectedIndex = 3; break;
        case "zh": languageSelector.SelectedIndex = 4; break;
        case "en": languageSelector.SelectedIndex = 5; break;
        case "ru": languageSelector.SelectedIndex = 6; break;
      }
    }
  }
}
