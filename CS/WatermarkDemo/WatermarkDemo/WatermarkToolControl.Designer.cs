namespace WatermarkDemo {
    partial class WatermarkToolControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cpeColor = new DevExpress.XtraEditors.ColorPickEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.seFontSize = new DevExpress.XtraEditors.SpinEdit();
            this.ceRepeat = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.stackPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpeColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFontSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRepeat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // stackPanel1
            // 
            this.stackPanel1.Controls.Add(this.labelControl1);
            this.stackPanel1.Controls.Add(this.teText);
            this.stackPanel1.Controls.Add(this.labelControl4);
            this.stackPanel1.Controls.Add(this.cpeColor);
            this.stackPanel1.Controls.Add(this.labelControl2);
            this.stackPanel1.Controls.Add(this.seFontSize);
            this.stackPanel1.Controls.Add(this.ceRepeat);
            this.stackPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel1.Location = new System.Drawing.Point(0, 0);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(802, 49);
            this.stackPanel1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 18);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Text:";
            // 
            // teText
            // 
            this.teText.Location = new System.Drawing.Point(32, 14);
            this.teText.Name = "teText";
            this.teText.Size = new System.Drawing.Size(128, 20);
            this.teText.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(181, 18);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(18, 3, 0, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Color:";
            // 
            // cpeColor
            // 
            this.cpeColor.EditValue = System.Drawing.Color.Empty;
            this.cpeColor.Location = new System.Drawing.Point(213, 14);
            this.cpeColor.Name = "cpeColor";
            this.cpeColor.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.cpeColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cpeColor.Properties.ColorAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cpeColor.Size = new System.Drawing.Size(64, 20);
            this.cpeColor.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(298, 18);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(18, 3, 0, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Font size:";
            // 
            // seFontSize
            // 
            this.seFontSize.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.seFontSize.Location = new System.Drawing.Point(348, 14);
            this.seFontSize.Name = "seFontSize";
            this.seFontSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seFontSize.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seFontSize.Properties.MinValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.seFontSize.Size = new System.Drawing.Size(64, 20);
            this.seFontSize.TabIndex = 8;
            // 
            // ceRepeat
            // 
            this.ceRepeat.Location = new System.Drawing.Point(433, 14);
            this.ceRepeat.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            this.ceRepeat.Name = "ceRepeat";
            this.ceRepeat.Properties.Caption = "Repeat";
            this.ceRepeat.Size = new System.Drawing.Size(75, 20);
            this.ceRepeat.TabIndex = 10;
            // 
            // WatermarkToolControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.stackPanel1);
            this.Name = "WatermarkToolControl";
            this.Size = new System.Drawing.Size(802, 49);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.stackPanel1.ResumeLayout(false);
            this.stackPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpeColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFontSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRepeat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private DevExpress.XtraEditors.TextEdit teText;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ColorPickEdit cpeColor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit seFontSize;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit ceRepeat;
    }
}
