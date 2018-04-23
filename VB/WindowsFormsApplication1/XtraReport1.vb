Imports System.Drawing.Printing
' ...

Namespace WindowsFormsApplication1
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub lbShowHide_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles lbShowHide.BeforePrint
            lbShowHide.Text = If(DetailReport.DrillDownExpanded, "Hide Details", "Show Details")
        End Sub

    End Class
End Namespace
