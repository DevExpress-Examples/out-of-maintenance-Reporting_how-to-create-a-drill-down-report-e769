Namespace WindowsFormsApplication1
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
            Me.components = New System.ComponentModel.Container()
            Dim tableQuery1 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo1 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo1 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo2 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo3 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo4 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim tableQuery2 As New DevExpress.DataAccess.Sql.TableQuery()
            Dim tableInfo2 As New DevExpress.DataAccess.Sql.TableInfo()
            Dim columnInfo5 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo6 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo7 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo8 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo9 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo10 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo11 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo12 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo13 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo14 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim columnInfo15 As New DevExpress.DataAccess.Sql.ColumnInfo()
            Dim masterDetailInfo1 As New DevExpress.DataAccess.Sql.MasterDetailInfo()
            Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.lbShowHide = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbShowHide, Me.xrPictureBox1, Me.xrLabel3, Me.xrLabel1})
            Me.Detail.HeightF = 97.20832F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbShowHide
            ' 
            Me.lbShowHide.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Underline)
            Me.lbShowHide.ForeColor = System.Drawing.Color.SteelBlue
            Me.lbShowHide.LocationFloat = New DevExpress.Utils.PointFloat(10.00013F, 74.20832F)
            Me.lbShowHide.Name = "lbShowHide"
            Me.lbShowHide.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbShowHide.SizeF = New System.Drawing.SizeF(365.625F, 23F)
            Me.lbShowHide.StylePriority.UseFont = False
            Me.lbShowHide.StylePriority.UseForeColor = False
            Me.lbShowHide.Text = "Show Detail"
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(503.5416F, 10.00001F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(136.4583F, 83.99999F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description")})
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 45.79166F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(365.625F, 28.41666F)
            Me.xrLabel3.Text = "xrLabel3"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName")})
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold)
            Me.xrLabel1.ForeColor = System.Drawing.Color.SteelBlue
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(365.625F, 35.79165F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' sqlDataSource1
            ' 
            Me.sqlDataSource1.ConnectionName = "nwind"
            Me.sqlDataSource1.Name = "sqlDataSource1"
            tableQuery1.Name = "Categories"
            tableInfo1.Name = "Categories"
            columnInfo1.Name = "CategoryID"
            columnInfo2.Name = "CategoryName"
            columnInfo3.Name = "Description"
            columnInfo4.Name = "Picture"
            tableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo1, columnInfo2, columnInfo3, columnInfo4})
            tableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo1})
            tableQuery2.Name = "Products"
            tableInfo2.Name = "Products"
            columnInfo5.Name = "ProductID"
            columnInfo6.Name = "ProductName"
            columnInfo7.Name = "SupplierID"
            columnInfo8.Name = "CategoryID"
            columnInfo9.Name = "QuantityPerUnit"
            columnInfo10.Name = "UnitPrice"
            columnInfo11.Name = "UnitsInStock"
            columnInfo12.Name = "UnitsOnOrder"
            columnInfo13.Name = "ReorderLevel"
            columnInfo14.Name = "Discontinued"
            columnInfo15.Name = "EAN13"
            tableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() { columnInfo5, columnInfo6, columnInfo7, columnInfo8, columnInfo9, columnInfo10, columnInfo11, columnInfo12, columnInfo13, columnInfo14, columnInfo15})
            tableQuery2.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() { tableInfo2})
            Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { tableQuery1, tableQuery2})
            masterDetailInfo1.DetailQueryName = "Products"
            relationColumnInfo1.NestedKeyColumn = "CategoryID"
            relationColumnInfo1.ParentKeyColumn = "CategoryID"
            masterDetailInfo1.KeyColumns.Add(relationColumnInfo1)
            masterDetailInfo1.MasterQueryName = "Categories"
            masterDetailInfo1.Name = "CategoriesProducts"
            Me.sqlDataSource1.Relations.AddRange(New DevExpress.DataAccess.Sql.MasterDetailInfo() { masterDetailInfo1})
            Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
            ' 
            ' Title
            ' 
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1F
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold)
            Me.Title.ForeColor = System.Drawing.Color.Maroon
            Me.Title.Name = "Title"
            ' 
            ' FieldCaption
            ' 
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1F
            Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
            Me.FieldCaption.Name = "FieldCaption"
            ' 
            ' PageInfo
            ' 
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1F
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            ' 
            ' DataField
            ' 
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1F
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10F)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1, Me.GroupHeader1})
            Me.DetailReport.DataMember = "Categories.CategoriesProducts"
            Me.DetailReport.DataSource = Me.sqlDataSource1
            Me.DetailReport.DrillDownControl = Me.lbShowHide
            Me.DetailReport.DrillDownExpanded = False
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.Detail1.HeightF = 25F
            Me.Detail1.Name = "Detail1"
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10.00012F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(629.9999F, 25F)
            Me.xrTable2.StylePriority.UseBorders = False
            Me.xrTable2.StylePriority.UsePadding = False
            Me.xrTable2.StylePriority.UseTextAlignment = False
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Weight = 1R
            ' 
            ' xrTableCell4
            ' 
            Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName")})
            Me.xrTableCell4.Name = "xrTableCell4"
            Me.xrTableCell4.Text = "xrTableCell1"
            Me.xrTableCell4.Weight = 1R
            ' 
            ' xrTableCell5
            ' 
            Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.QuantityPerUnit")})
            Me.xrTableCell5.Name = "xrTableCell5"
            Me.xrTableCell5.Text = "xrTableCell2"
            Me.xrTableCell5.Weight = 1R
            ' 
            ' xrTableCell6
            ' 
            Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice", "{0:$0.00}")})
            Me.xrTableCell6.Name = "xrTableCell6"
            Me.xrTableCell6.StylePriority.UseTextAlignment = False
            Me.xrTableCell6.Text = "xrTableCell3"
            Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.xrTableCell6.Weight = 1R
            ' 
            ' GroupHeader1
            ' 
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
            Me.GroupHeader1.HeightF = 35.00001F
            Me.GroupHeader1.Name = "GroupHeader1"
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTable1.Font = New System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold)
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.00013F, 10.00001F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(629.9999F, 25F)
            Me.xrTable1.StylePriority.UseBorders = False
            Me.xrTable1.StylePriority.UseFont = False
            Me.xrTable1.StylePriority.UsePadding = False
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Weight = 1R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Text = "Product Name"
            Me.xrTableCell1.Weight = 1R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Text = "Quantity per Unit"
            Me.xrTableCell2.Weight = 1R
            ' 
            ' xrTableCell3
            ' 
            Me.xrTableCell3.Name = "xrTableCell3"
            Me.xrTableCell3.Text = "Unit Price"
            Me.xrTableCell3.Weight = 1R
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
            Me.DataMember = "Categories"
            Me.DataSource = Me.sqlDataSource1
            Me.Margins = New System.Drawing.Printing.Margins(51, 100, 100, 100)
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "15.2"
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
        Private Title As DevExpress.XtraReports.UI.XRControlStyle
        Private FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
        Private PageInfo As DevExpress.XtraReports.UI.XRControlStyle
        Private DataField As DevExpress.XtraReports.UI.XRControlStyle
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
        Private Detail1 As DevExpress.XtraReports.UI.DetailBand
        Private WithEvents lbShowHide As DevExpress.XtraReports.UI.XRLabel
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Private GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace
