using System.Collections;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace DrillDownReport {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        const string sShowDetail = "Show Detail";
        const string sHideDetail = "Hide Detail";

        ArrayList expandedValues = new ArrayList();

        bool ShouldShowDetail(int catID) {
            return expandedValues.Contains(catID);
        }

        private void lbShowHide_BeforePrint(object sender, PrintEventArgs e) {
            XRLabel label = (XRLabel)sender;
            if (ShouldShowDetail((int)label.Tag)) {
                label.Text = sHideDetail;
            }
            else {
                label.Text = sShowDetail;
            }
        }

        private void DetailReport_BeforePrint(object sender, PrintEventArgs e) {
            e.Cancel = !ShouldShowDetail((int)GetCurrentColumnValue("CategoryID"));
        }

        private void lbShowHide_PreviewClick(object sender, PreviewMouseEventArgs e) {
            int index = (int)e.Brick.Value;

            bool showDetail = ShouldShowDetail(index);

            if (showDetail) {
                expandedValues.Remove(index);
            }
            else {
                expandedValues.Add(index);
            }

            CreateDocument();
        }

        private void lbShowHide_PreviewMouseMove(object sender, PreviewMouseEventArgs e) {
            e.PreviewControl.Cursor = Cursors.Hand;
        }

    }
}
