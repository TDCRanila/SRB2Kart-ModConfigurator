
namespace SRB2KModConfigurator.Forms
{
    partial class GeneralSettingsPanel
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
            this.GSP_MainPanel = new System.Windows.Forms.Panel();
            this.GSP_TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GSP_LabelBonusCharacter = new System.Windows.Forms.Label();
            this.GSP_CheckboxBonusCharacters = new System.Windows.Forms.CheckBox();
            this.GSP_LabelSkipGameIntro = new System.Windows.Forms.Label();
            this.GSP_CheckBoxSkipGameIntro = new System.Windows.Forms.CheckBox();
            this.GSP_LabelSaveDataActions = new System.Windows.Forms.Label();
            this.GSP_ComboBoxDataActions = new System.Windows.Forms.ComboBox();
            this.GSP_CheckBoxAdditionalConsole = new System.Windows.Forms.CheckBox();
            this.GSP_LabelConsole = new System.Windows.Forms.Label();
            this.GSP_LabelCustomConfigFile = new System.Windows.Forms.Label();
            this.GSP_TableLayoutCustomConfigFile = new System.Windows.Forms.TableLayoutPanel();
            this.GSP_ButtonCustomConfigFile = new System.Windows.Forms.Button();
            this.GSP_TextBoxCustomConfigFile = new System.Windows.Forms.TextBox();
            this.GSP_LabelAdditionalParameters = new System.Windows.Forms.Label();
            this.GSP_TextBoxAdditionalParameters = new System.Windows.Forms.TextBox();
            this.GSP_MasterToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GSP_MainPanel.SuspendLayout();
            this.GSP_TableLayout.SuspendLayout();
            this.GSP_TableLayoutCustomConfigFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // GSP_MainPanel
            // 
            this.GSP_MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.GSP_MainPanel.Controls.Add(this.GSP_TableLayout);
            this.GSP_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GSP_MainPanel.Location = new System.Drawing.Point(0, 0);
            this.GSP_MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.GSP_MainPanel.Name = "GSP_MainPanel";
            this.GSP_MainPanel.Size = new System.Drawing.Size(720, 195);
            this.GSP_MainPanel.TabIndex = 0;
            // 
            // GSP_TableLayout
            // 
            this.GSP_TableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.GSP_TableLayout.ColumnCount = 2;
            this.GSP_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.43F));
            this.GSP_TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.57F));
            this.GSP_TableLayout.Controls.Add(this.GSP_LabelBonusCharacter, 0, 0);
            this.GSP_TableLayout.Controls.Add(this.GSP_CheckboxBonusCharacters, 1, 0);
            this.GSP_TableLayout.Controls.Add(this.GSP_LabelSkipGameIntro, 0, 1);
            this.GSP_TableLayout.Controls.Add(this.GSP_CheckBoxSkipGameIntro, 1, 1);
            this.GSP_TableLayout.Controls.Add(this.GSP_LabelSaveDataActions, 0, 2);
            this.GSP_TableLayout.Controls.Add(this.GSP_ComboBoxDataActions, 1, 2);
            this.GSP_TableLayout.Controls.Add(this.GSP_CheckBoxAdditionalConsole, 1, 3);
            this.GSP_TableLayout.Controls.Add(this.GSP_LabelConsole, 0, 3);
            this.GSP_TableLayout.Controls.Add(this.GSP_LabelCustomConfigFile, 0, 4);
            this.GSP_TableLayout.Controls.Add(this.GSP_TableLayoutCustomConfigFile, 1, 4);
            this.GSP_TableLayout.Controls.Add(this.GSP_LabelAdditionalParameters, 0, 5);
            this.GSP_TableLayout.Controls.Add(this.GSP_TextBoxAdditionalParameters, 1, 5);
            this.GSP_TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GSP_TableLayout.Location = new System.Drawing.Point(0, 0);
            this.GSP_TableLayout.Name = "GSP_TableLayout";
            this.GSP_TableLayout.RowCount = 6;
            this.GSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.GSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.GSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.GSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.GSP_TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.GSP_TableLayout.Size = new System.Drawing.Size(720, 195);
            this.GSP_TableLayout.TabIndex = 0;
            // 
            // GSP_LabelBonusCharacter
            // 
            this.GSP_LabelBonusCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GSP_LabelBonusCharacter.AutoSize = true;
            this.GSP_LabelBonusCharacter.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GSP_LabelBonusCharacter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GSP_LabelBonusCharacter.Location = new System.Drawing.Point(4, 7);
            this.GSP_LabelBonusCharacter.Name = "GSP_LabelBonusCharacter";
            this.GSP_LabelBonusCharacter.Size = new System.Drawing.Size(176, 14);
            this.GSP_LabelBonusCharacter.TabIndex = 2;
            this.GSP_LabelBonusCharacter.Text = "Add Bonus Characters";
            this.GSP_MasterToolTip.SetToolTip(this.GSP_LabelBonusCharacter, "The setting adds the additional bonus characters WAD which comes with SRB2Kart.");
            // 
            // GSP_CheckboxBonusCharacters
            // 
            this.GSP_CheckboxBonusCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GSP_CheckboxBonusCharacters.AutoSize = true;
            this.GSP_CheckboxBonusCharacters.Location = new System.Drawing.Point(187, 7);
            this.GSP_CheckboxBonusCharacters.Name = "GSP_CheckboxBonusCharacters";
            this.GSP_CheckboxBonusCharacters.Size = new System.Drawing.Size(529, 14);
            this.GSP_CheckboxBonusCharacters.TabIndex = 8;
            this.GSP_MasterToolTip.SetToolTip(this.GSP_CheckboxBonusCharacters, "The setting adds the additional bonus characters WAD which comes with SRB2Kart.");
            this.GSP_CheckboxBonusCharacters.UseVisualStyleBackColor = true;
            // 
            // GSP_LabelSkipGameIntro
            // 
            this.GSP_LabelSkipGameIntro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GSP_LabelSkipGameIntro.AutoSize = true;
            this.GSP_LabelSkipGameIntro.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GSP_LabelSkipGameIntro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GSP_LabelSkipGameIntro.Location = new System.Drawing.Point(4, 33);
            this.GSP_LabelSkipGameIntro.Name = "GSP_LabelSkipGameIntro";
            this.GSP_LabelSkipGameIntro.Size = new System.Drawing.Size(176, 14);
            this.GSP_LabelSkipGameIntro.TabIndex = 6;
            this.GSP_LabelSkipGameIntro.Text = "Skip Game Intro";
            // 
            // GSP_CheckBoxSkipGameIntro
            // 
            this.GSP_CheckBoxSkipGameIntro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GSP_CheckBoxSkipGameIntro.AutoSize = true;
            this.GSP_CheckBoxSkipGameIntro.Location = new System.Drawing.Point(187, 33);
            this.GSP_CheckBoxSkipGameIntro.Name = "GSP_CheckBoxSkipGameIntro";
            this.GSP_CheckBoxSkipGameIntro.Size = new System.Drawing.Size(529, 14);
            this.GSP_CheckBoxSkipGameIntro.TabIndex = 12;
            this.GSP_CheckBoxSkipGameIntro.UseVisualStyleBackColor = true;
            // 
            // GSP_LabelSaveDataActions
            // 
            this.GSP_LabelSaveDataActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GSP_LabelSaveDataActions.AutoSize = true;
            this.GSP_LabelSaveDataActions.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GSP_LabelSaveDataActions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GSP_LabelSaveDataActions.Location = new System.Drawing.Point(4, 64);
            this.GSP_LabelSaveDataActions.Name = "GSP_LabelSaveDataActions";
            this.GSP_LabelSaveDataActions.Size = new System.Drawing.Size(176, 14);
            this.GSP_LabelSaveDataActions.TabIndex = 5;
            this.GSP_LabelSaveDataActions.Text = "Save Data Actions";
            // 
            // GSP_ComboBoxDataActions
            // 
            this.GSP_ComboBoxDataActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GSP_ComboBoxDataActions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GSP_ComboBoxDataActions.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GSP_ComboBoxDataActions.FormattingEnabled = true;
            this.GSP_ComboBoxDataActions.Items.AddRange(new object[] {
            "No Action",
            "Reset Data",
            "No Data"});
            this.GSP_ComboBoxDataActions.Location = new System.Drawing.Point(187, 60);
            this.GSP_ComboBoxDataActions.Name = "GSP_ComboBoxDataActions";
            this.GSP_ComboBoxDataActions.Size = new System.Drawing.Size(529, 21);
            this.GSP_ComboBoxDataActions.TabIndex = 11;
            // 
            // GSP_CheckBoxAdditionalConsole
            // 
            this.GSP_CheckBoxAdditionalConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GSP_CheckBoxAdditionalConsole.AutoSize = true;
            this.GSP_CheckBoxAdditionalConsole.Location = new System.Drawing.Point(187, 99);
            this.GSP_CheckBoxAdditionalConsole.Name = "GSP_CheckBoxAdditionalConsole";
            this.GSP_CheckBoxAdditionalConsole.Size = new System.Drawing.Size(529, 14);
            this.GSP_CheckBoxAdditionalConsole.TabIndex = 9;
            this.GSP_CheckBoxAdditionalConsole.UseVisualStyleBackColor = true;
            // 
            // GSP_LabelConsole
            // 
            this.GSP_LabelConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GSP_LabelConsole.AutoSize = true;
            this.GSP_LabelConsole.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GSP_LabelConsole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GSP_LabelConsole.Location = new System.Drawing.Point(4, 92);
            this.GSP_LabelConsole.Name = "GSP_LabelConsole";
            this.GSP_LabelConsole.Size = new System.Drawing.Size(176, 28);
            this.GSP_LabelConsole.TabIndex = 3;
            this.GSP_LabelConsole.Text = "Enable Additional Console";
            // 
            // GSP_LabelCustomConfigFile
            // 
            this.GSP_LabelCustomConfigFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GSP_LabelCustomConfigFile.AutoSize = true;
            this.GSP_LabelCustomConfigFile.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GSP_LabelCustomConfigFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GSP_LabelCustomConfigFile.Location = new System.Drawing.Point(4, 133);
            this.GSP_LabelCustomConfigFile.Name = "GSP_LabelCustomConfigFile";
            this.GSP_LabelCustomConfigFile.Size = new System.Drawing.Size(176, 14);
            this.GSP_LabelCustomConfigFile.TabIndex = 13;
            this.GSP_LabelCustomConfigFile.Text = "Custom Config File";
            this.GSP_LabelCustomConfigFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GSP_TableLayoutCustomConfigFile
            // 
            this.GSP_TableLayoutCustomConfigFile.ColumnCount = 2;
            this.GSP_TableLayoutCustomConfigFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.GSP_TableLayoutCustomConfigFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 483F));
            this.GSP_TableLayoutCustomConfigFile.Controls.Add(this.GSP_ButtonCustomConfigFile, 0, 0);
            this.GSP_TableLayoutCustomConfigFile.Controls.Add(this.GSP_TextBoxCustomConfigFile, 1, 0);
            this.GSP_TableLayoutCustomConfigFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GSP_TableLayoutCustomConfigFile.Location = new System.Drawing.Point(185, 124);
            this.GSP_TableLayoutCustomConfigFile.Margin = new System.Windows.Forms.Padding(1);
            this.GSP_TableLayoutCustomConfigFile.Name = "GSP_TableLayoutCustomConfigFile";
            this.GSP_TableLayoutCustomConfigFile.RowCount = 1;
            this.GSP_TableLayoutCustomConfigFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GSP_TableLayoutCustomConfigFile.Size = new System.Drawing.Size(533, 33);
            this.GSP_TableLayoutCustomConfigFile.TabIndex = 14;
            // 
            // GSP_ButtonCustomConfigFile
            // 
            this.GSP_ButtonCustomConfigFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GSP_ButtonCustomConfigFile.BackColor = System.Drawing.Color.White;
            this.GSP_ButtonCustomConfigFile.BackgroundImage = global::SRB2KModConfigurator.Properties.Resources.spr_folder;
            this.GSP_ButtonCustomConfigFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GSP_ButtonCustomConfigFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GSP_ButtonCustomConfigFile.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GSP_ButtonCustomConfigFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GSP_ButtonCustomConfigFile.Location = new System.Drawing.Point(1, 2);
            this.GSP_ButtonCustomConfigFile.Margin = new System.Windows.Forms.Padding(1);
            this.GSP_ButtonCustomConfigFile.MinimumSize = new System.Drawing.Size(0, 28);
            this.GSP_ButtonCustomConfigFile.Name = "GSP_ButtonCustomConfigFile";
            this.GSP_ButtonCustomConfigFile.Size = new System.Drawing.Size(48, 28);
            this.GSP_ButtonCustomConfigFile.TabIndex = 12;
            this.GSP_ButtonCustomConfigFile.UseVisualStyleBackColor = false;
            this.GSP_ButtonCustomConfigFile.Click += new System.EventHandler(this.GSP_ButtonCustomConfigFile_Click);
            // 
            // GSP_TextBoxCustomConfigFile
            // 
            this.GSP_TextBoxCustomConfigFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GSP_TextBoxCustomConfigFile.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GSP_TextBoxCustomConfigFile.Location = new System.Drawing.Point(53, 5);
            this.GSP_TextBoxCustomConfigFile.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.GSP_TextBoxCustomConfigFile.Name = "GSP_TextBoxCustomConfigFile";
            this.GSP_TextBoxCustomConfigFile.Size = new System.Drawing.Size(477, 22);
            this.GSP_TextBoxCustomConfigFile.TabIndex = 11;
            // 
            // GSP_LabelAdditionalParameters
            // 
            this.GSP_LabelAdditionalParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GSP_LabelAdditionalParameters.AutoSize = true;
            this.GSP_LabelAdditionalParameters.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GSP_LabelAdditionalParameters.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GSP_LabelAdditionalParameters.Location = new System.Drawing.Point(4, 169);
            this.GSP_LabelAdditionalParameters.Name = "GSP_LabelAdditionalParameters";
            this.GSP_LabelAdditionalParameters.Size = new System.Drawing.Size(176, 14);
            this.GSP_LabelAdditionalParameters.TabIndex = 4;
            this.GSP_LabelAdditionalParameters.Text = "Additional Parameters";
            this.GSP_LabelAdditionalParameters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GSP_TextBoxAdditionalParameters
            // 
            this.GSP_TextBoxAdditionalParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GSP_TextBoxAdditionalParameters.Font = new System.Drawing.Font("envypn7x15", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GSP_TextBoxAdditionalParameters.Location = new System.Drawing.Point(187, 165);
            this.GSP_TextBoxAdditionalParameters.Name = "GSP_TextBoxAdditionalParameters";
            this.GSP_TextBoxAdditionalParameters.Size = new System.Drawing.Size(529, 22);
            this.GSP_TextBoxAdditionalParameters.TabIndex = 10;
            // 
            // GeneralSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 195);
            this.Controls.Add(this.GSP_MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralSettingsPanel";
            this.Text = "GeneralSettingsPanel";
            this.GSP_MainPanel.ResumeLayout(false);
            this.GSP_TableLayout.ResumeLayout(false);
            this.GSP_TableLayout.PerformLayout();
            this.GSP_TableLayoutCustomConfigFile.ResumeLayout(false);
            this.GSP_TableLayoutCustomConfigFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GSP_MainPanel;
        private System.Windows.Forms.TableLayoutPanel GSP_TableLayout;
        private System.Windows.Forms.Label GSP_LabelBonusCharacter;
        private System.Windows.Forms.Label GSP_LabelSaveDataActions;
        private System.Windows.Forms.CheckBox GSP_CheckboxBonusCharacters;
        private System.Windows.Forms.ComboBox GSP_ComboBoxDataActions;
        private System.Windows.Forms.CheckBox GSP_CheckBoxSkipGameIntro;
        private System.Windows.Forms.Label GSP_LabelSkipGameIntro;
        private System.Windows.Forms.Label GSP_LabelConsole;
        private System.Windows.Forms.CheckBox GSP_CheckBoxAdditionalConsole;
        private System.Windows.Forms.ToolTip GSP_MasterToolTip;
        private System.Windows.Forms.Label GSP_LabelCustomConfigFile;
        private System.Windows.Forms.TableLayoutPanel GSP_TableLayoutCustomConfigFile;
        private System.Windows.Forms.TextBox GSP_TextBoxCustomConfigFile;
        private System.Windows.Forms.Button GSP_ButtonCustomConfigFile;
        private System.Windows.Forms.Label GSP_LabelAdditionalParameters;
        private System.Windows.Forms.TextBox GSP_TextBoxAdditionalParameters;
    }
}