using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SRB2KModConfigurator
{
    public class NiceGroupBox : GroupBox
    {
        private Color _borderColor          = Color.White;
        private int _borderWidthOffset  = 0;
        private int _borderHeightOffset = 0;

        public Color BorderColor
        {
            get { return this._borderColor; }
            set { this._borderColor = value; }
        }

        public int BorderRectangleWidthOffset
        {
            get { return this._borderWidthOffset; }
            set { this._borderWidthOffset = value; }
        }

        public int BorderRectangleHeightOffset
        {
            get { return this._borderHeightOffset; }
            set { this._borderHeightOffset = value; }
        }

        public NiceGroupBox()
        {
            _borderColor        = Color.White;
            _borderWidthOffset  = 0;
            _borderHeightOffset = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //get the text size in groupbox
            Size textSize = TextRenderer.MeasureText(this.Text, this.Font);

            Rectangle boxDimensions = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
            int standardBorderHeightOffset = 2;

            boxDimensions.Y         = (textSize.Height * 0.5f) + _borderHeightOffset - standardBorderHeightOffset;
            boxDimensions.Height    = (boxDimensions.Height - (textSize.Height / 2) - (2 * _borderHeightOffset));

            boxDimensions.X         = _borderWidthOffset;
            boxDimensions.Width     = (boxDimensions.Width - (2 * _borderWidthOffset));

            ControlPaint.DrawBorder(e.Graphics, boxDimensions, this._borderColor, ButtonBorderStyle.Solid);

            Rectangle textRect = boxDimensions;
            // Magic Numbers to make group look nicer.
            textRect.X      = textRect.X + 8 + _borderWidthOffset;
            textRect.Y      = textRect.Y - 6;
            textRect.Width  = textSize.Width;
            textRect.Height = textSize.Height;

            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);
        }
    }

}
