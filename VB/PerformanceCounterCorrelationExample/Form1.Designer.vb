Namespace PerformanceCounterCorrelation

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim columnDefinition3 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim columnDefinition4 As DevExpress.XtraLayout.ColumnDefinition = New DevExpress.XtraLayout.ColumnDefinition()
            Dim rowDefinition7 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition8 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition9 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition10 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition11 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Dim rowDefinition12 As DevExpress.XtraLayout.RowDefinition = New DevExpress.XtraLayout.RowDefinition()
            Me.textEditCategory1 = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.labelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.arcScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
            Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.textEditCounter2 = New DevExpress.XtraEditors.TextEdit()
            Me.textEditInstance2 = New DevExpress.XtraEditors.TextEdit()
            Me.textEditInstance1 = New DevExpress.XtraEditors.TextEdit()
            Me.textEditCounter1 = New DevExpress.XtraEditors.TextEdit()
            Me.textEditCategory2 = New DevExpress.XtraEditors.TextEdit()
            Me.btnStart = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.simpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.textEditCategory1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleRangeBarComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditCounter2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditInstance2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditInstance1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditCounter1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEditCategory2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' textEditCategory1
            ' 
            Me.textEditCategory1.Location = New System.Drawing.Point(71, 29)
            Me.textEditCategory1.Name = "textEditCategory1"
            Me.textEditCategory1.Size = New System.Drawing.Size(155, 20)
            Me.textEditCategory1.StyleController = Me.layoutControl1
            Me.textEditCategory1.TabIndex = 0
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Controls.Add(Me.textEditCounter2)
            Me.layoutControl1.Controls.Add(Me.textEditInstance2)
            Me.layoutControl1.Controls.Add(Me.textEditInstance1)
            Me.layoutControl1.Controls.Add(Me.textEditCounter1)
            Me.layoutControl1.Controls.Add(Me.textEditCategory1)
            Me.layoutControl1.Controls.Add(Me.textEditCategory2)
            Me.layoutControl1.Controls.Add(Me.btnStart)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(512, 153, 450, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(457, 400)
            Me.layoutControl1.TabIndex = 4
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' gaugeControl1
            ' 
            Me.gaugeControl1.ColorScheme.TargetElements = CType(((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar Or DevExpress.XtraGauges.Core.Base.TargetElement.Label)), DevExpress.XtraGauges.Core.Base.TargetElement)
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(12, 127)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(433, 261)
            Me.gaugeControl1.TabIndex = 10
            ' 
            ' circularGauge1
            ' 
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 421, 249)
            Me.circularGauge1.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.labelComponent1})
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent() {Me.arcScaleRangeBarComponent1})
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1})
            ' 
            ' labelComponent1
            ' 
            Me.labelComponent1.AppearanceText.Font = New System.Drawing.Font("Segoe UI", 27.75F)
            Me.labelComponent1.Name = "circularGauge1_Label1"
            Me.labelComponent1.Size = New System.Drawing.SizeF(140F, 60F)
            Me.labelComponent1.Text = "0.5"
            Me.labelComponent1.ZOrder = -1001
            ' 
            ' arcScaleRangeBarComponent1
            ' 
            Me.arcScaleRangeBarComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleRangeBarComponent1.Name = "circularGauge1_RangeBar2"
            Me.arcScaleRangeBarComponent1.RoundedCaps = True
            Me.arcScaleRangeBarComponent1.ShowBackground = True
            Me.arcScaleRangeBarComponent1.StartOffset = 80F
            Me.arcScaleRangeBarComponent1.ZOrder = -10
            ' 
            ' arcScaleComponent1
            ' 
            Me.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.5F)
            Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
            Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent1.EndAngle = 90F
            Me.arcScaleComponent1.MajorTickCount = 0
            Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -14F
            Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1
            Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent1.MinorTickCount = 0
            Me.arcScaleComponent1.MinorTickmark.ShapeOffset = -7F
            Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
            Me.arcScaleComponent1.Name = "scale1"
            Me.arcScaleComponent1.StartAngle = -270F
            Me.arcScaleComponent1.Value = 0.5F
            ' 
            ' textEditCounter2
            ' 
            Me.textEditCounter2.Location = New System.Drawing.Point(289, 53)
            Me.textEditCounter2.Name = "textEditCounter2"
            Me.textEditCounter2.Size = New System.Drawing.Size(156, 20)
            Me.textEditCounter2.StyleController = Me.layoutControl1
            Me.textEditCounter2.TabIndex = 7
            ' 
            ' textEditInstance2
            ' 
            Me.textEditInstance2.Location = New System.Drawing.Point(289, 77)
            Me.textEditInstance2.Name = "textEditInstance2"
            Me.textEditInstance2.Size = New System.Drawing.Size(156, 20)
            Me.textEditInstance2.StyleController = Me.layoutControl1
            Me.textEditInstance2.TabIndex = 6
            ' 
            ' textEditInstance1
            ' 
            Me.textEditInstance1.Location = New System.Drawing.Point(71, 77)
            Me.textEditInstance1.Name = "textEditInstance1"
            Me.textEditInstance1.Size = New System.Drawing.Size(155, 20)
            Me.textEditInstance1.StyleController = Me.layoutControl1
            Me.textEditInstance1.TabIndex = 5
            ' 
            ' textEditCounter1
            ' 
            Me.textEditCounter1.Location = New System.Drawing.Point(71, 53)
            Me.textEditCounter1.Name = "textEditCounter1"
            Me.textEditCounter1.Size = New System.Drawing.Size(155, 20)
            Me.textEditCounter1.StyleController = Me.layoutControl1
            Me.textEditCounter1.TabIndex = 4
            ' 
            ' textEditCategory2
            ' 
            Me.textEditCategory2.Location = New System.Drawing.Point(289, 29)
            Me.textEditCategory2.Name = "textEditCategory2"
            Me.textEditCategory2.Size = New System.Drawing.Size(156, 20)
            Me.textEditCategory2.StyleController = Me.layoutControl1
            Me.textEditCategory2.TabIndex = 8
            ' 
            ' btnStart
            ' 
            Me.btnStart.Location = New System.Drawing.Point(153, 101)
            Me.btnStart.MaximumSize = New System.Drawing.Size(150, 0)
            Me.btnStart.Name = "btnStart"
            Me.btnStart.Size = New System.Drawing.Size(150, 22)
            Me.btnStart.StyleController = Me.layoutControl1
            Me.btnStart.TabIndex = 9
            Me.btnStart.Text = "Start"
            AddHandler Me.btnStart.Click, New System.EventHandler(AddressOf Me.btnStart_Click)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.simpleLabelItem1, Me.simpleLabelItem2, Me.layoutControlItem7, Me.layoutControlItem8})
            Me.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition3.Width = 50R
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent
            columnDefinition4.Width = 50R
            Me.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(New DevExpress.XtraLayout.ColumnDefinition() {columnDefinition3, columnDefinition4})
            rowDefinition7.Height = 17R
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition8.Height = 24R
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition9.Height = 24R
            rowDefinition9.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition10.Height = 24R
            rowDefinition10.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition11.Height = 26R
            rowDefinition11.SizeType = System.Windows.Forms.SizeType.AutoSize
            rowDefinition12.Height = 265R
            rowDefinition12.SizeType = System.Windows.Forms.SizeType.AutoSize
            Me.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(New DevExpress.XtraLayout.RowDefinition() {rowDefinition7, rowDefinition8, rowDefinition9, rowDefinition10, rowDefinition11, rowDefinition12})
            Me.layoutControlGroup1.Size = New System.Drawing.Size(457, 400)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.textEditCategory1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 17)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
            Me.layoutControlItem1.Size = New System.Drawing.Size(218, 24)
            Me.layoutControlItem1.Text = "Category"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(48, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.textEditCounter1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 41)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 2
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
            Me.layoutControlItem2.Size = New System.Drawing.Size(218, 24)
            Me.layoutControlItem2.Text = "Counter"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(48, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.textEditInstance1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 65)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 3
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
            Me.layoutControlItem3.Size = New System.Drawing.Size(218, 24)
            Me.layoutControlItem3.Text = "Instance"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(48, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.textEditInstance2
            Me.layoutControlItem4.Location = New System.Drawing.Point(218, 65)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem4.OptionsTableLayoutItem.RowIndex = 3
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
            Me.layoutControlItem4.Size = New System.Drawing.Size(219, 24)
            Me.layoutControlItem4.Text = "Instance"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(48, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.textEditCounter2
            Me.layoutControlItem5.Location = New System.Drawing.Point(218, 41)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem5.OptionsTableLayoutItem.RowIndex = 2
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
            Me.layoutControlItem5.Size = New System.Drawing.Size(219, 24)
            Me.layoutControlItem5.Text = "Counter"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(48, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.textEditCategory2
            Me.layoutControlItem6.Location = New System.Drawing.Point(218, 17)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.OptionsTableLayoutItem.ColumnIndex = 1
            Me.layoutControlItem6.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2)
            Me.layoutControlItem6.Size = New System.Drawing.Size(219, 24)
            Me.layoutControlItem6.Text = "Category"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(48, 13)
            ' 
            ' simpleLabelItem1
            ' 
            Me.simpleLabelItem1.AllowHotTrack = False
            Me.simpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = True
            Me.simpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.simpleLabelItem1.Location = New System.Drawing.Point(0, 0)
            Me.simpleLabelItem1.Name = "simpleLabelItem1"
            Me.simpleLabelItem1.Size = New System.Drawing.Size(218, 17)
            Me.simpleLabelItem1.Text = "Counter 1"
            Me.simpleLabelItem1.TextSize = New System.Drawing.Size(48, 13)
            ' 
            ' simpleLabelItem2
            ' 
            Me.simpleLabelItem2.AllowHotTrack = False
            Me.simpleLabelItem2.AppearanceItemCaption.Options.UseTextOptions = True
            Me.simpleLabelItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.simpleLabelItem2.Location = New System.Drawing.Point(218, 0)
            Me.simpleLabelItem2.Name = "simpleLabelItem2"
            Me.simpleLabelItem2.OptionsTableLayoutItem.ColumnIndex = 1
            Me.simpleLabelItem2.Size = New System.Drawing.Size(219, 17)
            Me.simpleLabelItem2.Text = "Counter 2"
            Me.simpleLabelItem2.TextSize = New System.Drawing.Size(48, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.btnStart
            Me.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 89)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.OptionsTableLayoutItem.ColumnSpan = 2
            Me.layoutControlItem7.OptionsTableLayoutItem.RowIndex = 4
            Me.layoutControlItem7.Size = New System.Drawing.Size(437, 26)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.gaugeControl1
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 115)
            Me.layoutControlItem8.MinSize = New System.Drawing.Size(214, 24)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.OptionsTableLayoutItem.ColumnSpan = 2
            Me.layoutControlItem8.OptionsTableLayoutItem.RowIndex = 5
            Me.layoutControlItem8.Size = New System.Drawing.Size(437, 265)
            Me.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem8.Text = " "
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(457, 400)
            Me.Controls.Add(Me.layoutControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "Form1"
            Me.Text = "Performance Counter Correlation Example"
            CType((Me.textEditCategory1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleRangeBarComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditCounter2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditInstance2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditInstance1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditCounter1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEditCategory2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private textEditCategory1 As DevExpress.XtraEditors.TextEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private textEditInstance1 As DevExpress.XtraEditors.TextEdit

        Private textEditCounter1 As DevExpress.XtraEditors.TextEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private textEditCounter2 As DevExpress.XtraEditors.TextEdit

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private textEditInstance2 As DevExpress.XtraEditors.TextEdit

        Private textEditCategory2 As DevExpress.XtraEditors.TextEdit

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private simpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem

        Private simpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem

        Private btnStart As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent

        Private labelComponent1 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    End Class
End Namespace
