using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChooseColor
{
    [DesignTimeVisible(true)]
    [DefaultEvent("ValueChanged")]
    public partial class ChooseColor : UserControl
    {
        public ChooseColor()
        {
            InitializeComponent();
        }

        private int _redChannel = 0;
        private int _greenChannel = 0;
        private int _blueChannel = 0;
        private Color _color = Color.Black;
        public event EventHandler ValueOfColorChanged;

        [Browsable(true)]
        [RefreshProperties(RefreshProperties.All)]
        public int RedChannel
        {
            get { return _redChannel; }
            set
            {
                if (value < 0 || value > 255) { throw new ArgumentException("channel of color can't be < 0 and > 255"); }
                _redChannel = value;
                SetColor();
                ValueChanged();;
            }
        }

        [Browsable(true)]
        [RefreshProperties(RefreshProperties.All)]
        public int GreenChannel
        {
            get { return _greenChannel; }
            set
            {
                if (value < 0 || value > 255) { throw new ArgumentException("channel of color can't be < 0 and > 255"); }
                _greenChannel = value;
                SetColor();
                ValueChanged();
            }
        }

        [Browsable(true)]
        [RefreshProperties(RefreshProperties.All)]
        public int BlueChannel
        {
            get { return _blueChannel; }
            set
            {
                if (value < 0 || value > 255) { throw new ArgumentException("channel of color can't be < 0 and > 255"); }
                _blueChannel = value;
                SetColor();
                ValueChanged();
            }
        }

        [Browsable(true)]
        [RefreshProperties(RefreshProperties.All)]
        public Color ColorChoosed
        {
            get { return _color; }
            set
            {
                RedChannel = value.R;
                GreenChannel = value.G;
                BlueChannel = value.B;
                ValueChanged();
                SetColor();
            }
        }

        private void SetColor()
        {
            _color = Color.FromArgb(RedChannel, GreenChannel, BlueChannel);
            colorPB.BackColor = _color;
            ValueOfColorChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ValueChanged()
        {
            redTrackBar.Value = RedChannel;
            greenTrackBar.Value = GreenChannel;
            blueTrackBar.Value = BlueChannel;
        }

        private void redTrackBar_ValueChanged(object sender, EventArgs e)
        {
            RedChannel = redTrackBar.Value;
            toolTip.Show(RedChannel.ToString(), redTrackBar);
        }

        private void greenTrackBar_ValueChanged(object sender, EventArgs e)
        {
            GreenChannel = greenTrackBar.Value;
            toolTip.Show(GreenChannel.ToString(), greenTrackBar);
        }

        private void blueTrackBar_ValueChanged(object sender, EventArgs e)
        {
            BlueChannel = blueTrackBar.Value;
            toolTip.Show(BlueChannel.ToString(), blueTrackBar);
        }

        private void colorPB_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show(String.Format("R: {0}, G: {1}, B: {2}", RedChannel, GreenChannel, BlueChannel), colorPB);
        }
        
    }
}
