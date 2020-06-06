namespace GDITest
{
    partial class GDITest
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.comboCompositingMode = new System.Windows.Forms.ComboBox();
            this.comboInterpolationMode = new System.Windows.Forms.ComboBox();
            this.comboPixelOffsetMode = new System.Windows.Forms.ComboBox();
            this.comboTextRenderingHint = new System.Windows.Forms.ComboBox();
            this.comboSmoothingMode = new System.Windows.Forms.ComboBox();
            this.comboCompositingQuality = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // picPicture
            // 
            this.picPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPicture.Location = new System.Drawing.Point(12, 111);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(544, 395);
            this.picPicture.TabIndex = 0;
            this.picPicture.TabStop = false;
            // 
            // comboCompositingMode
            // 
            this.comboCompositingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCompositingMode.Items.AddRange(new object[] {
            "SourceOver",
            "SourceCopy"});
            this.comboCompositingMode.Location = new System.Drawing.Point(12, 12);
            this.comboCompositingMode.Name = "comboCompositingMode";
            this.comboCompositingMode.Size = new System.Drawing.Size(121, 20);
            this.comboCompositingMode.TabIndex = 1;
            this.comboCompositingMode.SelectedIndexChanged += new System.EventHandler(this.comboCompositingMode_SelectedIndexChanged);
            // 
            // comboInterpolationMode
            // 
            this.comboInterpolationMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInterpolationMode.Items.AddRange(new object[] {
            "Default",
            "Low",
            "High",
            "Bilinear",
            "Bicubic",
            "NearestNeighbor",
            "HighQualityBilinear",
            "HighQualityBicubic"});
            this.comboInterpolationMode.Location = new System.Drawing.Point(139, 12);
            this.comboInterpolationMode.Name = "comboInterpolationMode";
            this.comboInterpolationMode.Size = new System.Drawing.Size(177, 20);
            this.comboInterpolationMode.TabIndex = 2;
            this.comboInterpolationMode.SelectedIndexChanged += new System.EventHandler(this.comboInterpolationMode_SelectedIndexChanged);
            // 
            // comboPixelOffsetMode
            // 
            this.comboPixelOffsetMode.AutoCompleteCustomSource.AddRange(new string[] {
            "Default",
            "HighSpeed",
            "HighQuality",
            "None",
            "Half"});
            this.comboPixelOffsetMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPixelOffsetMode.Items.AddRange(new object[] {
            "Default",
            "HighSpeed",
            "HighQuality",
            "None",
            "Half"});
            this.comboPixelOffsetMode.Location = new System.Drawing.Point(322, 12);
            this.comboPixelOffsetMode.Name = "comboPixelOffsetMode";
            this.comboPixelOffsetMode.Size = new System.Drawing.Size(177, 20);
            this.comboPixelOffsetMode.TabIndex = 3;
            this.comboPixelOffsetMode.SelectedIndexChanged += new System.EventHandler(this.comboPixelOffsetMode_SelectedIndexChanged);
            // 
            // comboTextRenderingHint
            // 
            this.comboTextRenderingHint.AutoCompleteCustomSource.AddRange(new string[] {
            "Default",
            "HighSpeed",
            "HighQuality",
            "None",
            "AntiAlias"});
            this.comboTextRenderingHint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTextRenderingHint.Items.AddRange(new object[] {
            "None",
            "SingleBitPerPixelGridFit",
            "SingleBitPerPixel",
            "AntiAliasGridFit",
            "AntiAlias",
            "ClearTypeGridFit"});
            this.comboTextRenderingHint.Location = new System.Drawing.Point(12, 38);
            this.comboTextRenderingHint.Name = "comboTextRenderingHint";
            this.comboTextRenderingHint.Size = new System.Drawing.Size(177, 20);
            this.comboTextRenderingHint.TabIndex = 4;
            this.comboTextRenderingHint.SelectedIndexChanged += new System.EventHandler(this.comboSmoothingMode_SelectedIndexChanged);
            // 
            // comboSmoothingMode
            // 
            this.comboSmoothingMode.AutoCompleteCustomSource.AddRange(new string[] {
            "Default",
            "HighSpeed",
            "HighQuality",
            "None",
            "AntiAlias"});
            this.comboSmoothingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSmoothingMode.Items.AddRange(new object[] {
            "Default",
            "HighSpeed",
            "HighQuality",
            "None",
            "AntiAlias"});
            this.comboSmoothingMode.Location = new System.Drawing.Point(195, 38);
            this.comboSmoothingMode.Name = "comboSmoothingMode";
            this.comboSmoothingMode.Size = new System.Drawing.Size(177, 20);
            this.comboSmoothingMode.TabIndex = 5;
            this.comboSmoothingMode.SelectedIndexChanged += new System.EventHandler(this.comboSmoothingMode_SelectedIndexChanged_1);
            // 
            // comboCompositingQuality
            // 
            this.comboCompositingQuality.AutoCompleteCustomSource.AddRange(new string[] {
            "Default",
            "HighSpeed",
            "HighQuality",
            "None",
            "AntiAlias"});
            this.comboCompositingQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCompositingQuality.Items.AddRange(new object[] {
            "Default",
            "HighSpeed",
            "HighQuality",
            "GammaCorrected",
            "AssumeLinear"});
            this.comboCompositingQuality.Location = new System.Drawing.Point(12, 64);
            this.comboCompositingQuality.Name = "comboCompositingQuality";
            this.comboCompositingQuality.Size = new System.Drawing.Size(177, 20);
            this.comboCompositingQuality.TabIndex = 6;
            this.comboCompositingQuality.SelectedIndexChanged += new System.EventHandler(this.comboCompositingQuality_SelectedIndexChanged);
            // 
            // GDITest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 518);
            this.Controls.Add(this.comboCompositingQuality);
            this.Controls.Add(this.comboSmoothingMode);
            this.Controls.Add(this.comboTextRenderingHint);
            this.Controls.Add(this.comboPixelOffsetMode);
            this.Controls.Add(this.comboInterpolationMode);
            this.Controls.Add(this.comboCompositingMode);
            this.Controls.Add(this.picPicture);
            this.Name = "GDITest";
            this.Text = "GDITest";
            this.Load += new System.EventHandler(this.GDITest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPicture;
        private System.Windows.Forms.ComboBox comboCompositingMode;
        private System.Windows.Forms.ComboBox comboInterpolationMode;
        private System.Windows.Forms.ComboBox comboPixelOffsetMode;
        private System.Windows.Forms.ComboBox comboTextRenderingHint;
        private System.Windows.Forms.ComboBox comboSmoothingMode;
        private System.Windows.Forms.ComboBox comboCompositingQuality;
    }
}

