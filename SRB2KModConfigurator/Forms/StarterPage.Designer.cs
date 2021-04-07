
namespace SRB2KModConfigurator
{
    partial class StarterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarterPage));
            this.SP_MainPanel = new System.Windows.Forms.Panel();
            this.SP_LabelTitle = new System.Windows.Forms.Label();
            this.SP_TableMainOptions = new System.Windows.Forms.TableLayoutPanel();
            this.SP_ButtonCredits = new System.Windows.Forms.Button();
            this.SP_ButtonEditConfig = new System.Windows.Forms.Button();
            this.SP_ButtonNewConfig = new System.Windows.Forms.Button();
            this.SP_TableLaunchOptions = new System.Windows.Forms.TableLayoutPanel();
            this.SP_ButtonLaunchConfig = new System.Windows.Forms.Button();
            this.SP_SwitchPanel = new System.Windows.Forms.Panel();
            this.SP_ButtonLaunchFileDialog = new System.Windows.Forms.Button();
            this.SP_MainPanel.SuspendLayout();
            this.SP_TableMainOptions.SuspendLayout();
            this.SP_TableLaunchOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // SP_MainPanel
            // 
            this.SP_MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.SP_MainPanel.Controls.Add(this.SP_TableLaunchOptions);
            this.SP_MainPanel.Controls.Add(this.SP_LabelTitle);
            this.SP_MainPanel.Controls.Add(this.SP_TableMainOptions);
            this.SP_MainPanel.Controls.Add(this.SP_SwitchPanel);
            this.SP_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SP_MainPanel.Location = new System.Drawing.Point(0, 0);
            this.SP_MainPanel.Name = "SP_MainPanel";
            this.SP_MainPanel.Size = new System.Drawing.Size(1264, 681);
            this.SP_MainPanel.TabIndex = 0;
            // 
            // SP_LabelTitle
            // 
            this.SP_LabelTitle.AutoSize = true;
            this.SP_LabelTitle.Font = new System.Drawing.Font("envypn7x15", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SP_LabelTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SP_LabelTitle.Location = new System.Drawing.Point(387, 318);
            this.SP_LabelTitle.Name = "SP_LabelTitle";
            this.SP_LabelTitle.Size = new System.Drawing.Size(523, 43);
            this.SP_LabelTitle.TabIndex = 1;
            this.SP_LabelTitle.Text = "SRB2Kart ModConfigurator";
            // 
            // SP_TableMainOptions
            // 
            this.SP_TableMainOptions.ColumnCount = 5;
            this.SP_TableMainOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.SP_TableMainOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.SP_TableMainOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.SP_TableMainOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.SP_TableMainOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 303F));
            this.SP_TableMainOptions.Controls.Add(this.SP_ButtonCredits, 3, 0);
            this.SP_TableMainOptions.Controls.Add(this.SP_ButtonEditConfig, 1, 0);
            this.SP_TableMainOptions.Controls.Add(this.SP_ButtonNewConfig, 2, 0);
            this.SP_TableMainOptions.Location = new System.Drawing.Point(12, 364);
            this.SP_TableMainOptions.Name = "SP_TableMainOptions";
            this.SP_TableMainOptions.RowCount = 1;
            this.SP_TableMainOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SP_TableMainOptions.Size = new System.Drawing.Size(1240, 40);
            this.SP_TableMainOptions.TabIndex = 0;
            // 
            // SP_ButtonCredits
            // 
            this.SP_ButtonCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SP_ButtonCredits.Font = new System.Drawing.Font("envypn7x15", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SP_ButtonCredits.Location = new System.Drawing.Point(847, 3);
            this.SP_ButtonCredits.Name = "SP_ButtonCredits";
            this.SP_ButtonCredits.Size = new System.Drawing.Size(87, 34);
            this.SP_ButtonCredits.TabIndex = 2;
            this.SP_ButtonCredits.Text = "Credits";
            this.SP_ButtonCredits.UseVisualStyleBackColor = true;
            // 
            // SP_ButtonEditConfig
            // 
            this.SP_ButtonEditConfig.BackColor = System.Drawing.Color.Transparent;
            this.SP_ButtonEditConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SP_ButtonEditConfig.FlatAppearance.BorderSize = 10;
            this.SP_ButtonEditConfig.Font = new System.Drawing.Font("envypn7x15", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SP_ButtonEditConfig.Location = new System.Drawing.Point(343, 3);
            this.SP_ButtonEditConfig.Name = "SP_ButtonEditConfig";
            this.SP_ButtonEditConfig.Size = new System.Drawing.Size(245, 34);
            this.SP_ButtonEditConfig.TabIndex = 0;
            this.SP_ButtonEditConfig.Text = "Edit Configuration";
            this.SP_ButtonEditConfig.UseVisualStyleBackColor = false;
            // 
            // SP_ButtonNewConfig
            // 
            this.SP_ButtonNewConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SP_ButtonNewConfig.Font = new System.Drawing.Font("envypn7x15", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SP_ButtonNewConfig.Location = new System.Drawing.Point(594, 3);
            this.SP_ButtonNewConfig.Name = "SP_ButtonNewConfig";
            this.SP_ButtonNewConfig.Size = new System.Drawing.Size(247, 34);
            this.SP_ButtonNewConfig.TabIndex = 1;
            this.SP_ButtonNewConfig.Text = "New Configuration";
            this.SP_ButtonNewConfig.UseVisualStyleBackColor = true;
            // 
            // SP_TableLaunchOptions
            // 
            this.SP_TableLaunchOptions.ColumnCount = 4;
            this.SP_TableLaunchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.35394F));
            this.SP_TableLaunchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 545F));
            this.SP_TableLaunchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.SP_TableLaunchOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 303F));
            this.SP_TableLaunchOptions.Controls.Add(this.SP_ButtonLaunchFileDialog, 2, 0);
            this.SP_TableLaunchOptions.Controls.Add(this.SP_ButtonLaunchConfig, 1, 0);
            this.SP_TableLaunchOptions.Location = new System.Drawing.Point(12, 409);
            this.SP_TableLaunchOptions.Name = "SP_TableLaunchOptions";
            this.SP_TableLaunchOptions.RowCount = 1;
            this.SP_TableLaunchOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SP_TableLaunchOptions.Size = new System.Drawing.Size(1240, 50);
            this.SP_TableLaunchOptions.TabIndex = 2;
            // 
            // SP_ButtonLaunchConfig
            // 
            this.SP_ButtonLaunchConfig.BackColor = System.Drawing.Color.Transparent;
            this.SP_ButtonLaunchConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SP_ButtonLaunchConfig.FlatAppearance.BorderSize = 10;
            this.SP_ButtonLaunchConfig.Font = new System.Drawing.Font("envypn7x15", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SP_ButtonLaunchConfig.Location = new System.Drawing.Point(343, 3);
            this.SP_ButtonLaunchConfig.Name = "SP_ButtonLaunchConfig";
            this.SP_ButtonLaunchConfig.Size = new System.Drawing.Size(539, 44);
            this.SP_ButtonLaunchConfig.TabIndex = 2;
            this.SP_ButtonLaunchConfig.Text = "Launch Configuration";
            this.SP_ButtonLaunchConfig.UseVisualStyleBackColor = false;
            // 
            // SP_SwitchPanel
            // 
            this.SP_SwitchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SP_SwitchPanel.Location = new System.Drawing.Point(0, 0);
            this.SP_SwitchPanel.Margin = new System.Windows.Forms.Padding(0);
            this.SP_SwitchPanel.Name = "SP_SwitchPanel";
            this.SP_SwitchPanel.Size = new System.Drawing.Size(1264, 681);
            this.SP_SwitchPanel.TabIndex = 3;
            this.SP_SwitchPanel.Visible = false;
            // 
            // SP_ButtonLaunchFileDialog
            // 
            this.SP_ButtonLaunchFileDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SP_ButtonLaunchFileDialog.Font = new System.Drawing.Font("envypn7x15", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SP_ButtonLaunchFileDialog.Location = new System.Drawing.Point(888, 3);
            this.SP_ButtonLaunchFileDialog.Name = "SP_ButtonLaunchFileDialog";
            this.SP_ButtonLaunchFileDialog.Size = new System.Drawing.Size(46, 44);
            this.SP_ButtonLaunchFileDialog.TabIndex = 4;
            this.SP_ButtonLaunchFileDialog.Text = "V";
            this.SP_ButtonLaunchFileDialog.UseVisualStyleBackColor = true;
            // 
            // StarterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SP_MainPanel);
            this.Name = "StarterPage";
            this.Text = "StarterPage";
            this.SP_MainPanel.ResumeLayout(false);
            this.SP_MainPanel.PerformLayout();
            this.SP_TableMainOptions.ResumeLayout(false);
            this.SP_TableLaunchOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SP_MainPanel;
        private System.Windows.Forms.Label SP_LabelTitle;
        private System.Windows.Forms.TableLayoutPanel SP_TableMainOptions;
        private System.Windows.Forms.Button SP_ButtonEditConfig;
        private System.Windows.Forms.Button SP_ButtonNewConfig;
        private System.Windows.Forms.Button SP_ButtonCredits;
        private System.Windows.Forms.TableLayoutPanel SP_TableLaunchOptions;
        private System.Windows.Forms.Button SP_ButtonLaunchConfig;
        private System.Windows.Forms.Panel SP_SwitchPanel;
        private System.Windows.Forms.Button SP_ButtonLaunchFileDialog;
    }
}