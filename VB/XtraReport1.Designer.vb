Namespace DrillDownReport
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.lbShowHide = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.nwindDataSet1 = New DrillDownReport.nwindDataSet()
            Me.categoriesTableAdapter = New DrillDownReport.nwindDataSetTableAdapters.CategoriesTableAdapter()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.productsTableAdapter = New DrillDownReport.nwindDataSetTableAdapters.ProductsTableAdapter()
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox1, Me.lbShowHide, Me.xrLabel2, Me.xrLabel1})
            Me.Detail.Height = 117
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture", "")})
            Me.xrPictureBox1.Location = New System.Drawing.Point(517, 17)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.Size = New System.Drawing.Size(125, 89)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
            ' 
            ' lbShowHide
            ' 
            Me.lbShowHide.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "Categories.CategoryID", "")})
            Me.lbShowHide.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline)
            Me.lbShowHide.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(128)))), (CInt((CByte(192)))))
            Me.lbShowHide.Location = New System.Drawing.Point(8, 83)
            Me.lbShowHide.Name = "lbShowHide"
            Me.lbShowHide.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbShowHide.Size = New System.Drawing.Size(100, 25)
            Me.lbShowHide.StylePriority.UseFont = False
            Me.lbShowHide.StylePriority.UseForeColor = False
            Me.lbShowHide.StylePriority.UseTextAlignment = False
            Me.lbShowHide.Text = "Show Detail"
            Me.lbShowHide.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description", "")})
            Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic)
            Me.xrLabel2.Location = New System.Drawing.Point(8, 50)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.Size = New System.Drawing.Size(492, 25)
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.Text = "xrLabel2"
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.BackColor = System.Drawing.Color.White
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName", "")})
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(128)))), (CInt((CByte(192)))))
            Me.xrLabel1.Location = New System.Drawing.Point(8, 17)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.Size = New System.Drawing.Size(492, 25)
            Me.xrLabel1.StylePriority.UseBackColor = False
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' nwindDataSet1
            ' 
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' categoriesTableAdapter
            ' 
            Me.categoriesTableAdapter.ClearBeforeFill = True
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.GroupHeader1})
            Me.DetailReport.DataAdapter = Me.productsTableAdapter
            Me.DetailReport.DataMember = "Categories.CategoriesProducts"
            Me.DetailReport.DataSource = Me.nwindDataSet1
            Me.DetailReport.Name = "DetailReport"
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.Detail1.Height = 25
            Me.Detail1.Name = "Detail1"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable1.Location = New System.Drawing.Point(8, 0)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.Size = New System.Drawing.Size(625, 25)
            Me.xrTable1.StylePriority.UseBorders = False
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Size = New System.Drawing.Size(625, 25)
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName", "")})
            Me.xrTableCell1.Location = New System.Drawing.Point(0, 0)
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell1.Size = New System.Drawing.Size(206, 25)
            Me.xrTableCell1.StylePriority.UseTextAlignment = False
            Me.xrTableCell1.Text = "xrTableCell1"
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.QuantityPerUnit", "")})
            Me.xrTableCell2.Location = New System.Drawing.Point(206, 0)
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.Size = New System.Drawing.Size(206, 25)
            Me.xrTableCell2.StylePriority.UseTextAlignment = False
            Me.xrTableCell2.Text = "xrTableCell2"
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice", "{0:$0.00}")})
            Me.xrTableCell3.Location = New System.Drawing.Point(412, 0)
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell3.Size = New System.Drawing.Size(213, 25)
            Me.xrTableCell3.StylePriority.UseTextAlignment = False
            Me.xrTableCell3.Text = "xrTableCell3"
            Me.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.GroupHeader1.Height = 25
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable2.Location = New System.Drawing.Point(8, 0)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
            Me.xrTable2.Size = New System.Drawing.Size(625, 25)
            Me.xrTable2.StylePriority.UseBorders = False
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Size = New System.Drawing.Size(625, 25)
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
            Me.xrTableCell4.Location = New System.Drawing.Point(0, 0)
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell4.Size = New System.Drawing.Size(206, 25)
            Me.xrTableCell4.StylePriority.UseFont = False
            Me.xrTableCell4.StylePriority.UseTextAlignment = False
            Me.xrTableCell4.Text = "Product Name"
            Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
            Me.xrTableCell5.Location = New System.Drawing.Point(206, 0)
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell5.Size = New System.Drawing.Size(206, 25)
            Me.xrTableCell5.StylePriority.UseFont = False
            Me.xrTableCell5.StylePriority.UseTextAlignment = False
            Me.xrTableCell5.Text = "Quantity Per Unit"
            Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
            Me.xrTableCell6.Location = New System.Drawing.Point(412, 0)
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell6.Size = New System.Drawing.Size(213, 25)
            Me.xrTableCell6.StylePriority.UseFont = False
            Me.xrTableCell6.StylePriority.UseTextAlignment = False
            Me.xrTableCell6.Text = "Unit Price"
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' productsTableAdapter
            ' 
            Me.productsTableAdapter.ClearBeforeFill = True
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.DetailReport})
            Me.DataAdapter = Me.categoriesTableAdapter
            Me.DataMember = "Categories"
            Me.DataSource = Me.nwindDataSet1
            Me.DrawGrid = False
            Me.Version = "8.2"
            DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private nwindDataSet1 As nwindDataSet
        Private categoriesTableAdapter As DrillDownReport.nwindDataSetTableAdapters.CategoriesTableAdapter
        Private WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
        Private Detail1 As DevExpress.XtraReports.UI.DetailBand
        Private productsTableAdapter As DrillDownReport.nwindDataSetTableAdapters.ProductsTableAdapter
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Private WithEvents lbShowHide As DevExpress.XtraReports.UI.XRLabel
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    End Class
End Namespace
