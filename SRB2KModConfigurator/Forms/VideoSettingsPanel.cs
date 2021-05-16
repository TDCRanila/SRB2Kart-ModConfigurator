using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Linq;

using SRB2KModConfigurator.Data;

namespace SRB2KModConfigurator.Forms
{
    public partial class VideoSettingsPanel : Form
    {
        public VideoSettingsPanel()
        {
            InitializeComponent();

            InitializeSettingsControls();
        }

        private int currentWidth;
        private int currentHeight;

        private void InitializeSettingsControls()
        {
            currentWidth    = 0;
            currentHeight   = 0;

            VSP_ComboBoxWindowMode.Items.Clear();
            VSP_ComboBoxWindowMode.Items.AddRange(Enum.GetNames(typeof(WindowMode)));
            VSP_ComboBoxWindowMode.SelectedIndex = 0;

            string[] resolutions = Enum.GetNames(typeof(RenderResolution));
            for (int it = 0; it < resolutions.Length; ++it)
            {
                // Remove the 'r' in front of every resolution.
                resolutions[it] = resolutions[it].Remove(0, 1);

                // Find other 'r's and replace with ' '.
                if (it != 0) // Skip ~ NoOverride
                    resolutions[it] = resolutions[it].Replace('r', ' ');
            }

            VSP_ComboBoxRenderResolution.Items.Clear();
            VSP_ComboBoxRenderResolution.Items.AddRange(resolutions);
            VSP_ComboBoxRenderResolution.SelectedIndex = 0;

            VSP_ComboBoxRenderType.Items.Clear();
            VSP_ComboBoxRenderType.Items.AddRange(Enum.GetNames(typeof(RendererType)));
            VSP_ComboBoxRenderType.SelectedIndex = 0;
        }

        public void LoadData(VideoSettingsDataStruct data)
        {
            VSP_ComboBoxWindowMode.SelectedIndex        = (int)data.windowMode;
            VSP_ComboBoxRenderType.SelectedIndex        = (int)data.rendererType;
            VSP_ComboBoxRenderResolution.SelectedIndex  = (int)data.renderResolution;

            VSP_TextBoxHeight.Text  = data.resolitionHeight.ToString();
            VSP_TextBoxWidth.Text   = data.resolutionWidth.ToString();
        }

        public VideoSettingsDataStruct ReturnData()
        {
            int NoOverrideIndex             = 0;
            int CustomOverrideIndex         = 1;
            VideoSettingsDataStruct data    = new VideoSettingsDataStruct();

            data.windowMode                 = (WindowMode)Enum.Parse(typeof(WindowMode), VSP_ComboBoxWindowMode.SelectedItem.ToString());
            data.overrideWindowMode         = (int)data.windowMode != NoOverrideIndex;
            data.rendererType               = (RendererType)Enum.Parse(typeof(RendererType), VSP_ComboBoxRenderType.SelectedItem.ToString());
            data.overrideRendererType       = (int)data.rendererType != NoOverrideIndex;
            data.renderResolution           = (RenderResolution)VSP_ComboBoxRenderResolution.SelectedIndex;
            data.overrideRenderResolution   = (int)data.renderResolution != NoOverrideIndex;

            int renderResolutionSelectionIndex  = VSP_ComboBoxRenderResolution.SelectedIndex;
            if (renderResolutionSelectionIndex == NoOverrideIndex)
            {
                data.overrideRenderResolution = false;
                data.resolutionWidth  = 0;
                data.resolitionHeight = 0;
            }
            
            if (renderResolutionSelectionIndex == CustomOverrideIndex)
            {
                data.overrideRenderResolution = true;
                data.resolutionWidth  = currentWidth;
                data.resolitionHeight = currentHeight;
            }

            if (renderResolutionSelectionIndex != NoOverrideIndex && renderResolutionSelectionIndex != CustomOverrideIndex)
            {
                string resolutionValueString = VSP_ComboBoxRenderResolution.Text;

                // Remove all characters after ' ' /(recommended)
                int resultIndex = resolutionValueString.IndexOf(' ');
                if (resultIndex >= 0)
                    resolutionValueString = resolutionValueString.Remove(resultIndex);

                int convertedWidthValue     = 0;
                int convertedHeightValue    = 0;
                try
                {
                    int dividerIndex        = resolutionValueString.ToLower().IndexOf('x');
                    string stringWidth      = resolutionValueString.Substring(0, dividerIndex);
                    string stringHeight     = resolutionValueString.Substring(dividerIndex + 1);
                    
                    convertedWidthValue     = Convert.ToInt32(stringWidth);
                    convertedHeightValue    = Convert.ToInt32(stringHeight);
                }
                catch (FormatException /*exception*/)
                {
                    convertedWidthValue     = 0;
                    convertedHeightValue    = 0;
                    throw;
                }

                data.overrideRenderResolution = true;
                data.resolutionWidth  = convertedWidthValue;
                data.resolitionHeight = convertedHeightValue;
            }

            return data;
        }

        #region Callbacks

        private void VSP_ComboBoxRenderResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CustomResolutionIndex        = 1;
            bool allowCustomRenderResolution = false;

            int currentIndex = VSP_ComboBoxRenderResolution.SelectedIndex;

            allowCustomRenderResolution = currentIndex == CustomResolutionIndex;
            if (allowCustomRenderResolution)
                allowCustomRenderResolution = true;
            else
                allowCustomRenderResolution = false;

            VSP_TextBoxWidth.Enabled    = allowCustomRenderResolution;
            VSP_TextBoxHeight.Enabled   = allowCustomRenderResolution;
        }

        private void VSP_TextBoxWidth_TextChanged(object sender, EventArgs e)
        {
            string newWidthText = VSP_TextBoxWidth.Text;
            if (newWidthText.Length == 0)
            {
                VSP_TextBoxHeight.Text = currentWidth.ToString();
                return;
            }

            bool containsNonDigits = newWidthText.Any(c => !char.IsDigit(c));
            if (containsNonDigits)
                VSP_TextBoxWidth.Text = currentWidth.ToString();
            else
            {
                try
                {
                    currentWidth = Convert.ToInt32(newWidthText);
                }
                catch (FormatException /*exception*/)
                {
                    VSP_TextBoxWidth.Text   = "0";
                    currentWidth            = 0;
                    throw;
                }
            }
        }

        private void VSP_TextBoxHeight_TextChanged(object sender, EventArgs e)
        {
            string newHeightText = VSP_TextBoxHeight.Text;
            if (newHeightText.Length == 0)
            {
                VSP_TextBoxHeight.Text = currentHeight.ToString();
                return;
            }

            bool containsNonDigits = newHeightText.Any(c => !char.IsDigit(c));
            if (containsNonDigits)
                VSP_TextBoxHeight.Text = currentHeight.ToString();
            else
            {
                try
                {
                    currentHeight = Convert.ToInt32(newHeightText);
                }
                catch (FormatException /*exception*/)
                {
                    VSP_TextBoxHeight.Text  = "0";
                    currentHeight           = 0;
                    throw;
                }
            }
        }

        private void VSP_TextBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void VSP_TextBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #endregion // End of region ~ Callbacks.
    }
}
