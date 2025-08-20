using MudBlazor;

private readonly MudTheme _darkTheme = new()
{
    Palette = new Palette
    {
        Black = "#27272f",
        Background = "#32333d",
        BackgroundGrey = "#27272f",
        Surface = "#373740",
        TextPrimary = "#ffffffb3",
        TextSecondary = "rgba(255,255,255, 0.50)"
    }
};

private bool _isDarkMode;
private MudTheme _currentTheme => _isDarkMode ? _darkTheme : new MudTheme();

private void ToggleTheme() => _isDarkMode = !_isDarkMode;
