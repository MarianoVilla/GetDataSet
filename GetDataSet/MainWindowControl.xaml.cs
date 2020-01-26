namespace GetDataSet
{
    using GetDataSet.Lib.Mendeley;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for MainWindowControl.
    /// </summary>
    public partial class MainWindowControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowControl"/> class.
        /// </summary>
        public MainWindowControl()
        {
            this.InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (InvalidQuery())
                return;
            var SearchResults = MendeleyRESTConsumer.Search(txtSearchQuery.Text);
            new SearchResultWindowControl(SearchResults);
            //TODO: validate result (handle none and so).
            //new SearchResultWindow(SearchResult);
        }
        bool InvalidQuery()
        {
            if (string.IsNullOrWhiteSpace(txtSearchQuery.Text))
            {
                MessageBox.Show("A search box needs a text!");
                return true;
            }
            return false;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            cboDataTypes.ItemsSource = Enum.GetValues(typeof(MendeleyDataType));
        }
    }
}