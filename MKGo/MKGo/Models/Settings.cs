// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace MKGo
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>
  public static class Settings
  {
    private static ISettings AppSettings
    {
      get
      {
        return CrossSettings.Current;
      }
    }

    #region Setting Constants

    private const string CurrentTourKey = "currentTour";
    private static readonly int CurrentTourDefault = -1;

    #endregion


    public static int currentTourId
    {
      get
      {
        return AppSettings.GetValueOrDefault<int>(CurrentTourKey, CurrentTourDefault);
      }
      set
      {
        AppSettings.AddOrUpdateValue<int>(CurrentTourKey, value);
      }
    }


  }
}