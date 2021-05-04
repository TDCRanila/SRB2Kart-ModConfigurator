
namespace SRB2KModConfigurator.Forms
{
    partial class AudioSettingsPanel
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
            this.ASP_MainPanel = new System.Windows.Forms.Panel();
            this.ASP_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ASP_CheckBoxSFXs = new System.Windows.Forms.CheckBox();
            this.ASP_CheckBoxMusic = new System.Windows.Forms.CheckBox();
            this.ASP_LabelMusic = new System.Windows.Forms.Label();
            this.ASP_LabelSFXs = new System.Windows.Forms.Label();
            this.GSP_MasterToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ASP_MainPanel.SuspendLayout();
            this.ASP_TableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ASP_MainPanel
            // 
            this.ASP_MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ASP_MainPanel.Controls.Add(this.ASP_TableLayout);
            this.ASP_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ASP_MainPanel.Location = new System.Drawing.Point(0, 0);
            this.ASP_MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ASP_MainPanel.Name = "ASP_MainPanel";
            this.ASP_MainPanel.Size = new System.Drawing.Size(720, 50);
            this.ASP_MainPanel.TabIndex = 0;
            // 
            // ASP_TableLayout
            // 
            this.ASP_TableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ASP_TableLayout.ColumnCount = 2;
            this.ASP_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.42857F));
            this.ASP_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.57143F));
            this.ASP_TableLayout.Controls.Add(this.ASP_CheckBoxSFXs, 1, 1);
            this.ASP_TableLayout.Controls.Add(this.ASP_CheckBoxMusic, 1, 0);
            this.ASP_TableLayout.Controls.Add(this.ASP_LabelMusic, 0, 0);
            this.ASP_TableLayout.Controls.Add(this.ASP_LabelSFXs, 0, 1);
            this.ASP_TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ASP_TableLayout.Location = new System.Drawing.Point(0, 0);
            this.ASP_TableLayout.Name = "ASP_TableLayout";
            this.ASP_TableLayout.RowCount = 2;
            this.ASP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ASP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.ASP_TableLayout.Size = new System.Drawing.Size(720, 50);
            this.ASP_TableLayout.TabIndex = 0;
            // 
            // ASP_CheckBoxSFXs
            // 
            this.ASP_CheckBoxSFXs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ASP_CheckBoxSFXs.AutoSize = true;
            this.ASP_CheckBoxSFXs.Location = new System.Drawing.Point(187, 29);
            this.ASP_CheckBoxSFXs.Name = "ASP_CheckBoxSFXs";
            this.ASP_CheckBoxSFXs.Size = new System.Drawing.Size(529, 14);
            this.ASP_CheckBoxSFXs.TabIndex = 10;
            this.GSP_MasterToolTip.SetToolTip(this.ASP_CheckBoxSFXs, "The setting adds the additional bonus characters WAD which comes with SRB2Kart.");
            this.ASP_CheckBoxSFXs.UseVisualStyleBackColor = true;
            // 
            // ASP_CheckBoxMusic
            // 
            this.ASP_CheckBoxMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ASP_CheckBoxMusic.AutoSize = true;
            this.ASP_CheckBoxMusic.Location = new System.Drawing.Point(187, 5);
            this.ASP_CheckBoxMusic.Name = "ASP_CheckBoxMusic";
            this.ASP_CheckBoxMusic.Size = new System.Drawing.Size(529, 14);
            this.ASP_CheckBoxMusic.TabIndex = 9;
            this.GSP_MasterToolTip.SetToolTip(this.ASP_CheckBoxMusic, "The setting adds the additional bonus characters WAD which comes with SRB2Kart.");
            this.ASP_CheckBoxMusic.UseVisualStyleBackColor = true;
            // 
            // ASP_LabelMusic
            // 
            this.ASP_LabelMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ASP_LabelMusic.AutoSize = true;
            this.ASP_LabelMusic.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ASP_LabelMusic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ASP_LabelMusic.Location = new System.Drawing.Point(4, 5);
            this.ASP_LabelMusic.Name = "ASP_LabelMusic";
            this.ASP_LabelMusic.Size = new System.Drawing.Size(176, 14);
            this.ASP_LabelMusic.TabIndex = 0;
            this.ASP_LabelMusic.Text = "No Music";
            // 
            // ASP_LabelSFXs
            // 
            this.ASP_LabelSFXs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ASP_LabelSFXs.AutoSize = true;
            this.ASP_LabelSFXs.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ASP_LabelSFXs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ASP_LabelSFXs.Location = new System.Drawing.Point(4, 29);
            this.ASP_LabelSFXs.Name = "ASP_LabelSFXs";
            this.ASP_LabelSFXs.Size = new System.Drawing.Size(176, 14);
            this.ASP_LabelSFXs.TabIndex = 2;
            this.ASP_LabelSFXs.Text = "No SFXs";
            this.GSP_MasterToolTip.SetToolTip(this.ASP_LabelSFXs, "The setting adds the additional bonus characters WAD which comes with SRB2Kart.");
            // 
            // AudioSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 50);
            this.Controls.Add(this.ASP_MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AudioSettingsPanel";
            this.Text = "AudioSettingsPanel";
            this.ASP_MainPanel.ResumeLayout(false);
            this.ASP_TableLayout.ResumeLayout(false);
            this.ASP_TableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ASP_MainPanel;
        private System.Windows.Forms.TableLayoutPanel ASP_TableLayout;
        private System.Windows.Forms.Label ASP_LabelSFXs;
        private System.Windows.Forms.ToolTip GSP_MasterToolTip;
        private System.Windows.Forms.Label ASP_LabelMusic;
        private System.Windows.Forms.CheckBox ASP_CheckBoxSFXs;
        private System.Windows.Forms.CheckBox ASP_CheckBoxMusic;
    }
}