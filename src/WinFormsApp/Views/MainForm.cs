namespace WinFormsApp.Views;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        // DataBindings

        CurrentBehavior();
        //ExpectedBehavior();

        mainViewModelBindingSource.DataSource = new MainViewModel();
    }

    void CurrentBehavior()
    {
        // comboBox1
        comboBox1.DataBindings.Add(new Binding(nameof(ComboBox.DataSource), mainViewModelBindingSource, nameof(MainViewModel.Values), true));
        comboBox1.DataBindings.Add(new Binding(nameof(ComboBox.SelectedIndex), mainViewModelBindingSource, nameof(MainViewModel.SelectedValue1), true, DataSourceUpdateMode.OnPropertyChanged));
        //comboBox2
        comboBox2.DataBindings.Add(new Binding(nameof(ComboBox.DataSource), mainViewModelBindingSource, nameof(MainViewModel.Values), true));
        comboBox2.DataBindings.Add(new Binding(nameof(ComboBox.SelectedIndex), mainViewModelBindingSource, nameof(MainViewModel.SelectedValue2), true, DataSourceUpdateMode.OnPropertyChanged));
    }

    void ExpectedBehavior()
    {
        // comboBox1
        comboBox1.DataBindings.Add(new Binding(nameof(ComboBox.DataSource), mainViewModelBindingSource, nameof(MainViewModel.Values1), true));
        comboBox1.DataBindings.Add(new Binding(nameof(ComboBox.SelectedIndex), mainViewModelBindingSource, nameof(MainViewModel.SelectedValue1), true, DataSourceUpdateMode.OnPropertyChanged));
        //comboBox2
        comboBox2.DataBindings.Add(new Binding(nameof(ComboBox.DataSource), mainViewModelBindingSource, nameof(MainViewModel.Values2), true));
        comboBox2.DataBindings.Add(new Binding(nameof(ComboBox.SelectedIndex), mainViewModelBindingSource, nameof(MainViewModel.SelectedValue2), true, DataSourceUpdateMode.OnPropertyChanged));
    }
}
