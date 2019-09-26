Namespace WatermarkDemo
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
			Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
			Me.btnShowImageEditor = New DevExpress.XtraEditors.SimpleButton()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.svgImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pictureEdit1
			' 
			Me.pictureEdit1.EditValue = (CObj(resources.GetObject("pictureEdit1.EditValue")))
			Me.pictureEdit1.Location = New System.Drawing.Point(34, 30)
			Me.pictureEdit1.Name = "pictureEdit1"
			Me.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto
			Me.pictureEdit1.Properties.ShowEditMenuItem = DevExpress.Utils.DefaultBoolean.True
			Me.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
			Me.pictureEdit1.Size = New System.Drawing.Size(467, 352)
			Me.pictureEdit1.TabIndex = 0
			' 
			' svgImageCollection1
			' 
			Me.svgImageCollection1.Add("text2", "image://svgimages/spreadsheet/text2.svg")
			Me.svgImageCollection1.Add("changetextcase", "image://svgimages/outlook inspired/changetextcase.svg")
			' 
			' btnShowImageEditor
			' 
			Me.btnShowImageEditor.Location = New System.Drawing.Point(193, 388)
			Me.btnShowImageEditor.Name = "btnShowImageEditor"
			Me.btnShowImageEditor.Size = New System.Drawing.Size(149, 23)
			Me.btnShowImageEditor.TabIndex = 1
			Me.btnShowImageEditor.Text = "Show Image Editor"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnShowImageEditor.Click += new System.EventHandler(this.btnShowImageEditor_Click);
			' 
			' labelControl1
			' 
			Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
			Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.labelControl1.Location = New System.Drawing.Point(0, 441)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Padding = New System.Windows.Forms.Padding(5)
			Me.labelControl1.Size = New System.Drawing.Size(550, 36)
			Me.labelControl1.TabIndex = 3
			Me.labelControl1.Text = "This example adds two custom commands (Add Watermark and Watermark Preset) to the" &
	" Image Editor." & vbCrLf & " "
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(550, 477)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.btnShowImageEditor)
			Me.Controls.Add(Me.pictureEdit1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Form1"
			CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.svgImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit
		Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
		Private WithEvents btnShowImageEditor As DevExpress.XtraEditors.SimpleButton
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

