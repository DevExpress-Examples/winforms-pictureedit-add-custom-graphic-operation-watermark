Namespace WatermarkDemo
	Partial Public Class WatermarkToolControl
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.stackPanel1 = New DevExpress.Utils.Layout.StackPanel()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.teText = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.cpeColor = New DevExpress.XtraEditors.ColorPickEdit()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.seFontSize = New DevExpress.XtraEditors.SpinEdit()
			Me.ceRepeat = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.stackPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.stackPanel1.SuspendLayout()
			CType(Me.teText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cpeColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seFontSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceRepeat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' stackPanel1
			' 
			Me.stackPanel1.Controls.Add(Me.labelControl1)
			Me.stackPanel1.Controls.Add(Me.teText)
			Me.stackPanel1.Controls.Add(Me.labelControl4)
			Me.stackPanel1.Controls.Add(Me.cpeColor)
			Me.stackPanel1.Controls.Add(Me.labelControl2)
			Me.stackPanel1.Controls.Add(Me.seFontSize)
			Me.stackPanel1.Controls.Add(Me.ceRepeat)
			Me.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.stackPanel1.Location = New System.Drawing.Point(0, 0)
			Me.stackPanel1.Name = "stackPanel1"
			Me.stackPanel1.Size = New System.Drawing.Size(802, 49)
			Me.stackPanel1.TabIndex = 3
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(3, 18)
			Me.labelControl1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(26, 13)
			Me.labelControl1.TabIndex = 3
			Me.labelControl1.Text = "Text:"
			' 
			' teText
			' 
			Me.teText.Location = New System.Drawing.Point(32, 14)
			Me.teText.Name = "teText"
			Me.teText.Size = New System.Drawing.Size(128, 20)
			Me.teText.TabIndex = 0
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(181, 18)
			Me.labelControl4.Margin = New System.Windows.Forms.Padding(18, 3, 0, 3)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(29, 13)
			Me.labelControl4.TabIndex = 7
			Me.labelControl4.Text = "Color:"
			' 
			' cpeColor
			' 
			Me.cpeColor.EditValue = System.Drawing.Color.Empty
			Me.cpeColor.Location = New System.Drawing.Point(213, 14)
			Me.cpeColor.Name = "cpeColor"
			Me.cpeColor.Properties.AutomaticColor = System.Drawing.Color.Black
			Me.cpeColor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cpeColor.Properties.ColorAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.cpeColor.Size = New System.Drawing.Size(64, 20)
			Me.cpeColor.TabIndex = 6
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(298, 18)
			Me.labelControl2.Margin = New System.Windows.Forms.Padding(18, 3, 0, 3)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(47, 13)
			Me.labelControl2.TabIndex = 9
			Me.labelControl2.Text = "Font size:"
			' 
			' seFontSize
			' 
			Me.seFontSize.EditValue = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.seFontSize.Location = New System.Drawing.Point(348, 14)
			Me.seFontSize.Name = "seFontSize"
			Me.seFontSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.seFontSize.Properties.MaxValue = New Decimal(New Integer() { 100, 0, 0, 0})
			Me.seFontSize.Properties.MinValue = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.seFontSize.Size = New System.Drawing.Size(64, 20)
			Me.seFontSize.TabIndex = 8
			' 
			' ceRepeat
			' 
			Me.ceRepeat.Location = New System.Drawing.Point(433, 14)
			Me.ceRepeat.Margin = New System.Windows.Forms.Padding(18, 3, 3, 3)
			Me.ceRepeat.Name = "ceRepeat"
			Me.ceRepeat.Properties.Caption = "Repeat"
			Me.ceRepeat.Size = New System.Drawing.Size(75, 20)
			Me.ceRepeat.TabIndex = 10
			' 
			' WatermarkToolControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.stackPanel1)
			Me.Name = "WatermarkToolControl"
			Me.Size = New System.Drawing.Size(802, 49)
			CType(Me.stackPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.stackPanel1.ResumeLayout(False)
			Me.stackPanel1.PerformLayout()
			CType(Me.teText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cpeColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seFontSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceRepeat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private stackPanel1 As DevExpress.Utils.Layout.StackPanel
		Private teText As DevExpress.XtraEditors.TextEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private cpeColor As DevExpress.XtraEditors.ColorPickEdit
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private seFontSize As DevExpress.XtraEditors.SpinEdit
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private ceRepeat As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace
