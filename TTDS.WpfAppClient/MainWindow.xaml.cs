using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using TTDS.WpfAppClient.Common;
using TTDSMathLibraryWrapper;

namespace TTDS.WpfAppClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MathLibraryWrapper _calculator;
        public MainWindow()
        {
            InitializeComponent();

            btnCalculate.Click += OnCalculateButtonClick;
            _calculator = new MathLibraryWrapper();
        }

        private async void OnCalculateButtonClick(object sender, RoutedEventArgs e)
        {
            var item = (ComboBoxItem)cbOperation.SelectedItem;
            var op = item.Content.ToString();

            try
            {
                double firstNumber = double.Parse(tbFirstNumber.Text, CultureInfo.InvariantCulture);
                double secondNumber = double.Parse(tbSecondNumber.Text, CultureInfo.InvariantCulture);

                var task = await GetCalculationResult(firstNumber, secondNumber, op);

                await Dispatcher.BeginInvoke(() =>
                {
                    tbAnswer.Text = task?.ToString(CultureInfo.InvariantCulture);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async Task<double?> GetCalculationResult(double a, double b, string op)
        {
            return await Task.Run(() =>
            {
                double? result = null;

                try
                {
                    checked
                    {
                        switch (op)
                        {
                            case Constants.Sum:
                                result = _calculator.Sum(a, b);
                                break;

                            case Constants.Difference:
                                result = _calculator.Difference(a, b);
                                break;
                        }
                    }
                }
                catch (OverflowException e)
                {
                    throw;
                }

                return result;
            });
        }
    }
}