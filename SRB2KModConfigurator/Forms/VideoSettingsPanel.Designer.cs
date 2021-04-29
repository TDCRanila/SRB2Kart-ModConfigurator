
namespace SRB2KModConfigurator.Forms
{
    partial class VideoSettingsPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VSP_MainPanel = new System.Windows.Forms.Panel();
            this.VSP_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.VSP_LabelWindowMode = new System.Windows.Forms.Label();
            this.VSP_LabelRenderResolution = new System.Windows.Forms.Label();
            this.VSP_ComboBoxWindowMode = new System.Windows.Forms.ComboBox();
            this.VSP_TableLayoutRenderResolutionOptions = new System.Windows.Forms.TableLayoutPanel();
            this.VSP_ComboBoxRenderResolution = new System.Windows.Forms.ComboBox();
            this.VSP_TableLayoutCustomResolution = new System.Windows.Forms.TableLayoutPanel();
            this.VSP_TextBoxHeight = new System.Windows.Forms.TextBox();
            this.VSP_LabelWidthHeightDivider = new System.Windows.Forms.Label();
            this.VSP_TextBoxWidth = new System.Windows.Forms.TextBox();
            this.VSP_LabelCustomWidthHeight = new System.Windows.Forms.Label();
            this.VSP_ComboBoxRenderType = new System.Windows.Forms.ComboBox();
            this.VSP_LabelRenderType = new System.Windows.Forms.Label();
            this.GSP_MasterToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.VSP_MainPanel.SuspendLayout();
            this.VSP_TableLayout.SuspendLayout();
            this.VSP_TableLayoutRenderResolutionOptions.SuspendLayout();
            this.VSP_TableLayoutCustomResolution.SuspendLayout();
            this.SuspendLayout();
            // 
            // VSP_MainPanel
            // 
            this.VSP_MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.VSP_MainPanel.Controls.Add(this.VSP_TableLayout);
            this.VSP_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSP_MainPanel.Location = new System.Drawing.Point(0, 0);
            this.VSP_MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.VSP_MainPanel.Name = "VSP_MainPanel";
            this.VSP_MainPanel.Size = new System.Drawing.Size(720, 135);
            this.VSP_MainPanel.TabIndex = 0;
            // 
            // VSP_TableLayout
            // 
            this.VSP_TableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.VSP_TableLayout.ColumnCount = 2;
            this.VSP_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.42857F));
            this.VSP_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.57143F));
            this.VSP_TableLayout.Controls.Add(this.VSP_LabelWindowMode, 0, 0);
            this.VSP_TableLayout.Controls.Add(this.VSP_LabelRenderResolution, 0, 1);
            this.VSP_TableLayout.Controls.Add(this.VSP_ComboBoxWindowMode, 1, 0);
            this.VSP_TableLayout.Controls.Add(this.VSP_TableLayoutRenderResolutionOptions, 1, 1);
            this.VSP_TableLayout.Controls.Add(this.VSP_ComboBoxRenderType, 1, 2);
            this.VSP_TableLayout.Controls.Add(this.VSP_LabelRenderType, 0, 2);
            this.VSP_TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSP_TableLayout.Location = new System.Drawing.Point(0, 0);
            this.VSP_TableLayout.Name = "VSP_TableLayout";
            this.VSP_TableLayout.RowCount = 3;
            this.VSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.VSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.VSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.VSP_TableLayout.Size = new System.Drawing.Size(720, 135);
            this.VSP_TableLayout.TabIndex = 0;
            // 
            // VSP_LabelWindowMode
            // 
            this.VSP_LabelWindowMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VSP_LabelWindowMode.AutoSize = true;
            this.VSP_LabelWindowMode.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VSP_LabelWindowMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VSP_LabelWindowMode.Location = new System.Drawing.Point(4, 11);
            this.VSP_LabelWindowMode.Name = "VSP_LabelWindowMode";
            this.VSP_LabelWindowMode.Size = new System.Drawing.Size(176, 14);
            this.VSP_LabelWindowMode.TabIndex = 0;
            this.VSP_LabelWindowMode.Text = "Window Mode";
            // 
            // VSP_LabelRenderResolution
            // 
            this.VSP_LabelRenderResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VSP_LabelRenderResolution.AutoSize = true;
            this.VSP_LabelRenderResolution.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VSP_LabelRenderResolution.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VSP_LabelRenderResolution.Location = new System.Drawing.Point(4, 61);
            this.VSP_LabelRenderResolution.Name = "VSP_LabelRenderResolution";
            this.VSP_LabelRenderResolution.Size = new System.Drawing.Size(176, 14);
            this.VSP_LabelRenderResolution.TabIndex = 2;
            this.VSP_LabelRenderResolution.Text = "Resolution";
            this.GSP_MasterToolTip.SetToolTip(this.VSP_LabelRenderResolution, "The setting adds the additional bonus characters WAD which comes with SRB2Kart.");
            // 
            // VSP_ComboBoxWindowMode
            // 
            this.VSP_ComboBoxWindowMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VSP_ComboBoxWindowMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VSP_ComboBoxWindowMode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VSP_ComboBoxWindowMode.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VSP_ComboBoxWindowMode.FormattingEnabled = true;
            this.VSP_ComboBoxWindowMode.Items.AddRange(new object[] {
            "Windowed",
            "Fullscreen"});
            this.VSP_ComboBoxWindowMode.Location = new System.Drawing.Point(187, 7);
            this.VSP_ComboBoxWindowMode.Name = "VSP_ComboBoxWindowMode";
            this.VSP_ComboBoxWindowMode.Size = new System.Drawing.Size(529, 21);
            this.VSP_ComboBoxWindowMode.TabIndex = 12;
            // 
            // VSP_TableLayoutRenderResolutionOptions
            // 
            this.VSP_TableLayoutRenderResolutionOptions.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.VSP_TableLayoutRenderResolutionOptions.ColumnCount = 1;
            this.VSP_TableLayoutRenderResolutionOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.54442F));
            this.VSP_TableLayoutRenderResolutionOptions.Controls.Add(this.VSP_ComboBoxRenderResolution, 0, 0);
            this.VSP_TableLayoutRenderResolutionOptions.Controls.Add(this.VSP_TableLayoutCustomResolution, 0, 1);
            this.VSP_TableLayoutRenderResolutionOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSP_TableLayoutRenderResolutionOptions.Location = new System.Drawing.Point(186, 38);
            this.VSP_TableLayoutRenderResolutionOptions.Margin = new System.Windows.Forms.Padding(2);
            this.VSP_TableLayoutRenderResolutionOptions.Name = "VSP_TableLayoutRenderResolutionOptions";
            this.VSP_TableLayoutRenderResolutionOptions.RowCount = 2;
            this.VSP_TableLayoutRenderResolutionOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.96825F));
            this.VSP_TableLayoutRenderResolutionOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.03175F));
            this.VSP_TableLayoutRenderResolutionOptions.Size = new System.Drawing.Size(531, 60);
            this.VSP_TableLayoutRenderResolutionOptions.TabIndex = 17;
            // 
            // VSP_ComboBoxRenderResolution
            // 
            this.VSP_ComboBoxRenderResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VSP_ComboBoxRenderResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VSP_ComboBoxRenderResolution.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VSP_ComboBoxRenderResolution.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VSP_ComboBoxRenderResolution.FormattingEnabled = true;
            this.VSP_ComboBoxRenderResolution.Items.AddRange(new object[] {
            "Custom",
            "1920 X 1200 (Recommended)",
            "1920 X 1080",
            "1680 X 1050",
            "1600 X 1200",
            "1600 X   900",
            "1366 X   768",
            "1440 X   900",
            "1280 X 1024",
            "1280 X   960",
            "1280 X   800 (Recommended)",
            "1280 X   720",
            "1152 X   864",
            "1024 X   768",
            "800   X   600",
            "640   X   400 (Recommended)",
            "320   X   240",
            "320   X   200 (Recommended)"});
            this.VSP_ComboBoxRenderResolution.Location = new System.Drawing.Point(4, 5);
            this.VSP_ComboBoxRenderResolution.Name = "VSP_ComboBoxRenderResolution";
            this.VSP_ComboBoxRenderResolution.Size = new System.Drawing.Size(523, 21);
            this.VSP_ComboBoxRenderResolution.TabIndex = 13;
            this.VSP_ComboBoxRenderResolution.SelectedIndexChanged += new System.EventHandler(this.VSP_ComboBoxRenderResolution_SelectedIndexChanged);
            // 
            // VSP_TableLayoutCustomResolution
            // 
            this.VSP_TableLayoutCustomResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VSP_TableLayoutCustomResolution.ColumnCount = 5;
            this.VSP_TableLayoutCustomResolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.25087F));
            this.VSP_TableLayoutCustomResolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.VSP_TableLayoutCustomResolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.VSP_TableLayoutCustomResolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.VSP_TableLayoutCustomResolution.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.VSP_TableLayoutCustomResolution.Controls.Add(this.VSP_TextBoxHeight, 3, 0);
            this.VSP_TableLayoutCustomResolution.Controls.Add(this.VSP_LabelWidthHeightDivider, 2, 0);
            this.VSP_TableLayoutCustomResolution.Controls.Add(this.VSP_TextBoxWidth, 1, 0);
            this.VSP_TableLayoutCustomResolution.Controls.Add(this.VSP_LabelCustomWidthHeight, 0, 0);
            this.VSP_TableLayoutCustomResolution.Location = new System.Drawing.Point(1, 32);
            this.VSP_TableLayoutCustomResolution.Margin = new System.Windows.Forms.Padding(0);
            this.VSP_TableLayoutCustomResolution.Name = "VSP_TableLayoutCustomResolution";
            this.VSP_TableLayoutCustomResolution.RowCount = 1;
            this.VSP_TableLayoutCustomResolution.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.VSP_TableLayoutCustomResolution.Size = new System.Drawing.Size(529, 26);
            this.VSP_TableLayoutCustomResolution.TabIndex = 15;
            // 
            // VSP_TextBoxHeight
            // 
            this.VSP_TextBoxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VSP_TextBoxHeight.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VSP_TextBoxHeight.Location = new System.Drawing.Point(285, 3);
            this.VSP_TextBoxHeight.Name = "VSP_TextBoxHeight";
            this.VSP_TextBoxHeight.Size = new System.Drawing.Size(128, 22);
            this.VSP_TextBoxHeight.TabIndex = 6;
            this.VSP_TextBoxHeight.TextChanged += new System.EventHandler(this.VSP_TextBoxHeight_TextChanged);
            // 
            // VSP_LabelWidthHeightDivider
            // 
            this.VSP_LabelWidthHeightDivider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VSP_LabelWidthHeightDivider.AutoSize = true;
            this.VSP_LabelWidthHeightDivider.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VSP_LabelWidthHeightDivider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VSP_LabelWidthHeightDivider.Location = new System.Drawing.Point(266, 6);
            this.VSP_LabelWidthHeightDivider.Name = "VSP_LabelWidthHeightDivider";
            this.VSP_LabelWidthHeightDivider.Size = new System.Drawing.Size(13, 14);
            this.VSP_LabelWidthHeightDivider.TabIndex = 5;
            this.VSP_LabelWidthHeightDivider.Text = "x";
            this.GSP_MasterToolTip.SetToolTip(this.VSP_LabelWidthHeightDivider, "The setting adds the additional bonus characters WAD which comes with SRB2Kart.");
            // 
            // VSP_TextBoxWidth
            // 
            this.VSP_TextBoxWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VSP_TextBoxWidth.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VSP_TextBoxWidth.Location = new System.Drawing.Point(132, 3);
            this.VSP_TextBoxWidth.Name = "VSP_TextBoxWidth";
            this.VSP_TextBoxWidth.Size = new System.Drawing.Size(128, 22);
            this.VSP_TextBoxWidth.TabIndex = 4;
            this.VSP_TextBoxWidth.TextChanged += new System.EventHandler(this.VSP_TextBoxWidth_TextChanged);
            // 
            // VSP_LabelCustomWidthHeight
            // 
            this.VSP_LabelCustomWidthHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VSP_LabelCustomWidthHeight.AutoSize = true;
            this.VSP_LabelCustomWidthHeight.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VSP_LabelCustomWidthHeight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VSP_LabelCustomWidthHeight.Location = new System.Drawing.Point(3, 6);
            this.VSP_LabelCustomWidthHeight.Name = "VSP_LabelCustomWidthHeight";
            this.VSP_LabelCustomWidthHeight.Size = new System.Drawing.Size(123, 14);
            this.VSP_LabelCustomWidthHeight.TabIndex = 16;
            this.VSP_LabelCustomWidthHeight.Text = "Width x Height";
            this.GSP_MasterToolTip.SetToolTip(this.VSP_LabelCustomWidthHeight, "The setting adds the additional bonus characters WAD which comes with SRB2Kart.");
            // 
            // VSP_ComboBoxRenderType
            // 
            this.VSP_ComboBoxRenderType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VSP_ComboBoxRenderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VSP_ComboBoxRenderType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VSP_ComboBoxRenderType.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VSP_ComboBoxRenderType.FormattingEnabled = true;
            this.VSP_ComboBoxRenderType.Items.AddRange(new object[] {
            "OpenGL",
            "Software"});
            this.VSP_ComboBoxRenderType.Location = new System.Drawing.Point(187, 107);
            this.VSP_ComboBoxRenderType.Name = "VSP_ComboBoxRenderType";
            this.VSP_ComboBoxRenderType.Size = new System.Drawing.Size(529, 21);
            this.VSP_ComboBoxRenderType.TabIndex = 14;
            // 
            // VSP_LabelRenderType
            // 
            this.VSP_LabelRenderType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VSP_LabelRenderType.AutoSize = true;
            this.VSP_LabelRenderType.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VSP_LabelRenderType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VSP_LabelRenderType.Location = new System.Drawing.Point(4, 110);
            this.VSP_LabelRenderType.Name = "VSP_LabelRenderType";
            this.VSP_LabelRenderType.Size = new System.Drawing.Size(176, 14);
            this.VSP_LabelRenderType.TabIndex = 6;
            this.VSP_LabelRenderType.Text = "Renderer";
            // 
            // VideoSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 135);
            this.Controls.Add(this.VSP_MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VideoSettingsPanel";
            this.Text = "GeneralSettingsPanel";
            this.VSP_MainPanel.ResumeLayout(false);
            this.VSP_TableLayout.ResumeLayout(false);
            this.VSP_TableLayout.PerformLayout();
            this.VSP_TableLayoutRenderResolutionOptions.ResumeLayout(false);
            this.VSP_TableLayoutCustomResolution.ResumeLayout(false);
            this.VSP_TableLayoutCustomResolution.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel VSP_MainPanel;
        private System.Windows.Forms.TableLayoutPanel VSP_TableLayout;
        private System.Windows.Forms.Label VSP_LabelRenderResolution;
        private System.Windows.Forms.Label VSP_LabelRenderType;
        private System.Windows.Forms.ToolTip GSP_MasterToolTip;
        private System.Windows.Forms.Label VSP_LabelWindowMode;
        private System.Windows.Forms.ComboBox VSP_ComboBoxWindowMode;
        private System.Windows.Forms.ComboBox VSP_ComboBoxRenderResolution;
        private System.Windows.Forms.ComboBox VSP_ComboBoxRenderType;
        private System.Windows.Forms.TableLayoutPanel VSP_TableLayoutCustomResolution;
        private System.Windows.Forms.TextBox VSP_TextBoxHeight;
        private System.Windows.Forms.Label VSP_LabelWidthHeightDivider;
        private System.Windows.Forms.TextBox VSP_TextBoxWidth;
        private System.Windows.Forms.Label VSP_LabelCustomWidthHeight;
        private System.Windows.Forms.TableLayoutPanel VSP_TableLayoutRenderResolutionOptions;
    }
}