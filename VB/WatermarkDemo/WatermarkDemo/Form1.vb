Imports DevExpress.Utils.Svg
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ImageEditor
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace WatermarkDemo
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            AddHandler pictureEdit1.ImageEditorDialogShowing, AddressOf PictureEdit1_ImageEditorDialogShowing
        End Sub

        Private Sub PictureEdit1_ImageEditorDialogShowing(ByVal sender As Object, ByVal e As ImageEditorDialogShowingEventArgs)
            e.Commands.Insert(0, New WatermarkCommand() With {.Image = svgImageCollection1(0)})
            e.Commands.Insert(1, New WatermarkPreset() With {.Image = svgImageCollection1(1)})
        End Sub

        Private Sub btnShowImageEditor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowImageEditor.Click
            pictureEdit1.ShowImageEditorDialog()
        End Sub
    End Class
    Public Class WatermarkCommand
        Implements IGraphicCommand
        Public Overridable Property Image As SvgImage Implements IGraphicCommand.Image
        Public Overridable ReadOnly Property ToolTip() As String Implements IGraphicCommand.ToolTip
            Get
                Return "Add Watermark"
            End Get
        End Property
        Public Overridable Sub Execute(ByVal editorControl As ImageEditorControl) Implements IGraphicCommand.Execute
            editorControl.SetActiveTool(New WatermarkToolControl())
        End Sub
    End Class
    Public Class WatermarkPreset
		Inherits WatermarkCommand

		Public Overrides ReadOnly Property ToolTip() As String
			Get
				Return "Watermark Preset"
			End Get
		End Property
		Public Overrides Sub Execute(ByVal editorControl As ImageEditorControl)
			' Perform the WatermarkGraphicOperation operation in code, using the EditController. Users can undo this operation while the Image Editor is active.
			editorControl.EditController.DoOperation(New WatermarkGraphicOperation("devexpress.com", Color.LightBlue, 15, True))
		End Sub
	End Class
End Namespace
