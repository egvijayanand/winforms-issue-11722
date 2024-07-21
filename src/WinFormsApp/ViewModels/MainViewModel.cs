namespace WinFormsApp.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    [ObservableProperty]
    private int selectedValue1;

    [ObservableProperty]
    private int selectedValue2;

    public IReadOnlyList<int> Values { get; } = Enumerable.Range(0, 10).ToList();
    
    public IReadOnlyList<int> Values1 { get; } = Enumerable.Range(0, 10).ToList();
    
    public IReadOnlyList<int> Values2 { get; } = Enumerable.Range(0, 10).ToList();
}
