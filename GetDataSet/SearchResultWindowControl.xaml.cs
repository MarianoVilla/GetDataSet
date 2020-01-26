namespace GetDataSet
{
    using GetDataSet.Model.Mendeley;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for SearchResultWindowControl.
    /// </summary>
    public partial class SearchResultWindowControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultWindowControl"/> class.
        /// </summary>
        public SearchResultWindowControl(IEnumerable<MendeleyJSONResult> SearchResults)
        {
            this.InitializeComponent();
            gridSearchResults.ItemsSource = SearchResults;
        }
        public SearchResultWindowControl()
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
        }
    }
}