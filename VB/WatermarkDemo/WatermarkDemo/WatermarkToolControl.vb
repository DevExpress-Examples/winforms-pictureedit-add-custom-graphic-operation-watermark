Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ImageEditor

Namespace WatermarkDemo
	Partial Public Class WatermarkToolControl
		Inherits XtraUserControl
		Implements IToolSettingsControl

		Public Event Changed As EventHandler

		Public Sub New()
			InitializeComponent()

			AddHandler teText.TextChanged, Sub(s, e) RaiseChanged()
			AddHandler cpeColor.EditValueChanged, Sub(s, e) RaiseChanged()
			AddHandler seFontSize.EditValueChanged, Sub(s, e) RaiseChanged()
			AddHandler ceRepeat.CheckedChanged, Sub(s, e) RaiseChanged()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			teText.Text = "devexpress.com"
			cpeColor.Color = Color.FromArgb(180, Color.Silver)
			seFontSize.Value = 30
			ceRepeat.Checked = True
		End Sub
		Private Sub RaiseChanged()
			RaiseEvent Changed(Me, EventArgs.Empty)
		End Sub
		Public Function GetOperation() As BaseGraphicOperation
			Return New WatermarkGraphicOperation(teText.Text, cpeColor.Color, CInt(Math.Truncate(seFontSize.Value)), ceRepeat.Checked)
		End Function
	End Class

	Public Class WatermarkGraphicOperation
		Inherits BaseCachedGraphicOperation

		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Protected Set(ByVal value As String)
				privateText = value
			End Set
		End Property
		Private privateColor As Color
		Public Property Color() As Color
			Get
				Return privateColor
			End Get
			Protected Set(ByVal value As Color)
				privateColor = value
			End Set
		End Property
		Private privateRepeat As Boolean
		Public Property Repeat() As Boolean
			Get
				Return privateRepeat
			End Get
			Protected Set(ByVal value As Boolean)
				privateRepeat = value
			End Set
		End Property
		Private privateFontSize As Integer
		Public Property FontSize() As Integer
			Get
				Return privateFontSize
			End Get
			Protected Set(ByVal value As Integer)
				privateFontSize = value
			End Set
		End Property

		Public Sub New(ByVal text As String, ByVal color As Color, ByVal fontSize As Integer, ByVal repeat As Boolean)
			Me.Text = text
			Me.FontSize = fontSize
			Me.Color = color
			Me.Repeat = repeat
		End Sub
		Public Overrides Function Apply(ByVal input As Image) As Image
			Dim newImg As Image = New Bitmap(input)
			If Not String.IsNullOrEmpty(Text) Then
				Using g As Graphics = Graphics.FromImage(newImg)
					g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias
					Using font As New Font("Tahoma", FontSize)
						Using brush As New SolidBrush(Me.Color)
							If Me.Repeat Then
								Dim centerX As Single = (CSng(newImg.Width) / 2)
								Dim centerY As Single = (CSng(newImg.Height) / 2)
								g.TranslateTransform(centerX, centerY)
								g.RotateTransform(-45)
								g.TranslateTransform(-centerX, -centerY)
								Dim textSize As Size = g.MeasureString(Text, font).ToSize()
								Dim max As Integer = Math.Max(newImg.Width, newImg.Height)
								Dim start As Integer = -Math.Abs(newImg.Width - newImg.Height)
								For y As Integer = start To max - 1 Step textSize.Height + 64
									For x As Integer = start - (textSize.Width \ 2) To max - 1 Step textSize.Width + 64
										g.DrawString(Text, font, brush, New PointF(x, y))
									Next x
								Next y
							Else
								Dim rect As New RectangleF(0, 0, input.Width, input.Height)
								Using format As New StringFormat()
									format.Alignment = StringAlignment.Center
									format.LineAlignment = StringAlignment.Center
									g.DrawString(Text, font, brush, rect, format)
								End Using
							End If
						End Using
					End Using
				End Using
			End If
			Return newImg
		End Function
	End Class
End Namespace
