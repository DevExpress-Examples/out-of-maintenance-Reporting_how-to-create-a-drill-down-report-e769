Imports Microsoft.VisualBasic
Imports System.Collections
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
' ...

Namespace DrillDownReport
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Const sShowDetail As String = "Show Detail"
		Private Const sHideDetail As String = "Hide Detail"

		Private expandedValues As New ArrayList()

		Private Function ShouldShowDetail(ByVal catID As Integer) As Boolean
			Return expandedValues.Contains(catID)
		End Function

		Private Sub lbShowHide_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles lbShowHide.BeforePrint
			Dim label As XRLabel = CType(sender, XRLabel)
			If ShouldShowDetail(CInt(Fix(label.Tag))) Then
				label.Text = sHideDetail
			Else
				label.Text = sShowDetail
			End If
		End Sub

		Private Sub DetailReport_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles DetailReport.BeforePrint
			e.Cancel = Not ShouldShowDetail(CInt(Fix(GetCurrentColumnValue("CategoryID"))))
		End Sub

		Private Sub lbShowHide_PreviewClick(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles lbShowHide.PreviewClick
			Dim index As Integer = CInt(Fix(e.Brick.Value))

			Dim showDetail As Boolean = ShouldShowDetail(index)

			If showDetail Then
				expandedValues.Remove(index)
			Else
				expandedValues.Add(index)
			End If

			CreateDocument()
		End Sub

		Private Sub lbShowHide_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewMouseEventArgs) Handles lbShowHide.PreviewMouseMove
			Cursor.Current = Cursors.Hand
		End Sub

	End Class
End Namespace
