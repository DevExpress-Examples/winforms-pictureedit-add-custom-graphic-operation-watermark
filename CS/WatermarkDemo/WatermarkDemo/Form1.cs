using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ImageEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatermarkDemo {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            pictureEdit1.ImageEditorDialogShowing += PictureEdit1_ImageEditorDialogShowing;
        }

        void PictureEdit1_ImageEditorDialogShowing(object sender, ImageEditorDialogShowingEventArgs e) {
            e.Commands.Insert(0, new WatermarkCommand() { Image = svgImageCollection1[0] });
            e.Commands.Insert(1, new WatermarkPreset() { Image = svgImageCollection1[1] });
        }

        void btnShowImageEditor_Click(object sender, EventArgs e) {
            pictureEdit1.ShowImageEditorDialog();
        }
    }

    public class WatermarkCommand : IGraphicCommand {
        public virtual SvgImage Image {
            get;
            set;
        }
        public virtual string ToolTip {
            get { return "Add Watermark"; }
        }
        public virtual void Execute(ImageEditorControl editorControl) {
            editorControl.SetActiveTool(new WatermarkToolControl());
        }
    }

    public class WatermarkPreset : WatermarkCommand {
        public override string ToolTip {
            get { return "Watermark Preset"; }
        }
        public override void Execute(ImageEditorControl editorControl) {
            // Perform the WatermarkGraphicOperation operation in code, using the EditController. Users can undo this operation while the Image Editor is active.
            editorControl.EditController.DoOperation(new WatermarkGraphicOperation("devexpress.com", Color.LightBlue, 15, true));
        }
    }
}
