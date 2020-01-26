namespace GetDataSet
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GetDataSet.Model.Mendeley;
    using Microsoft.VisualStudio.Shell;

    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("cdcf2cad-3585-454d-a828-2e72c1e94bad")]
    public class SearchResultWindow : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultWindow"/> class.
        /// </summary>
        public SearchResultWindow(IEnumerable<MendeleyJSONResult> SearchResults) : base(null)
        {
            this.Caption = "Search results";

            this.Content = new SearchResultWindowControl(SearchResults);
        }
        public SearchResultWindow()
        {
            this.Caption = "Search results";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new SearchResultWindowControl();
        }
    }
}
