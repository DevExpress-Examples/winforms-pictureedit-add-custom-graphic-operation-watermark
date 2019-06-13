using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ImageEditor;

namespace WatermarkDemo {
    public partial class WatermarkToolControl : XtraUserControl, IToolSettingsControl {
        public event EventHandler Changed;

        public WatermarkToolControl() {
            InitializeComponent();

            teText.TextChanged += (s, e) => RaiseChanged();
            cpeColor.EditValueChanged += (s, e) => RaiseChanged();
            seFontSize.EditValueChanged += (s, e) => RaiseChanged();
            ceRepeat.CheckedChanged += (s, e) => RaiseChanged();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            teText.Text = "devexpress.com";
            cpeColor.Color = Color.FromArgb(180, Color.Silver);
            seFontSize.Value = 30;
            ceRepeat.Checked = true;
        }
        void RaiseChanged() {
            if(Changed != null)
                Changed(this, EventArgs.Empty);
        }
        public BaseGraphicOperation GetOperation() {
            return new WatermarkGraphicOperation(teText.Text, cpeColor.Color, (int)seFontSize.Value, ceRepeat.Checked);
        }
    }

    public class WatermarkGraphicOperation : BaseCachedGraphicOperation {
        public string Text { get; protected set; }
        public Color Color { get; protected set; }
        public bool Repeat { get; protected set; }
        public int FontSize { get; protected set; }

        public WatermarkGraphicOperation(String text, Color color, int fontSize, bool repeat) {
            this.Text = text;
            this.FontSize = fontSize;
            this.Color = color;
            this.Repeat = repeat;
        }
        public override Image Apply(Image input) {
            Image newImg = new Bitmap(input);
            if(!String.IsNullOrEmpty(Text)) {
                using(Graphics g = Graphics.FromImage(newImg)) {
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    using(Font font = new Font("Tahoma", FontSize)) {
                        using(SolidBrush brush = new SolidBrush(this.Color)) {
                            if(this.Repeat) {
                                float centerX = ((float)newImg.Width / 2);
                                float centerY = ((float)newImg.Height / 2);
                                g.TranslateTransform(centerX, centerY);
                                g.RotateTransform(-45);
                                g.TranslateTransform(-centerX, -centerY);
                                Size textSize = g.MeasureString(Text, font).ToSize();
                                int max = Math.Max(newImg.Width, newImg.Height);
                                int start = -Math.Abs(newImg.Width - newImg.Height);
                                for(int y = start; y < max; y += textSize.Height + 64) {
                                    for(int x = start - (textSize.Width / 2); x < max; x += textSize.Width + 64) {
                                        g.DrawString(Text, font, brush, new PointF(x, y));
                                    }
                                }
                            } else {
                                RectangleF rect = new RectangleF(0, 0, input.Width, input.Height);
                                using(StringFormat format = new StringFormat()) {
                                    format.Alignment = StringAlignment.Center;
                                    format.LineAlignment = StringAlignment.Center;
                                    g.DrawString(Text, font, brush, rect, format);
                                }
                            }
                        }
                    }
                }
            }
            return newImg;
        }
    }
}
