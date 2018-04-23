using System.Drawing.Printing;
// ...

namespace WindowsFormsApplication1 {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void lbShowHide_BeforePrint(object sender, PrintEventArgs e) {
            lbShowHide.Text = DetailReport.DrillDownExpanded ? "Hide Details" : "Show Details";
        }

    }
}
