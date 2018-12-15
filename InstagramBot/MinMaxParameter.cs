using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramBot
{
    public partial class MinMaxParameter : UserControl
    {
        public MinMaxParameter()
        {
            InitializeComponent();
        }
        public string TitleText
        {
            get
            {
                return Title.Text;
            }
            set
            {
                Title.Text = value;
                Title_TextChanged(new object(), new EventArgs());
            }
        }
        public int MinValue
        {
            get
            {
                return (int)MinimalValue.Value;
            }
            set
            {
                MinimalValue.Value = value;
                if (MinimalValue.Value > MaximalValue.Value)
                {
                    MaximalValue.Value = MinimalValue.Value;
                }
            }
        }
        public int MaxValue
        {
            get
            {
                return (int)MaximalValue.Value;
            }
            set
            {
                MaximalValue.Value = value;
                if(MaximalValue.Value<MinimalValue.Value)
                {
                    MaximalValue.Value = MinimalValue.Value;
                }
            }
        }
        public bool IsEnabled
        {
            get
            {
                return ElementEnable.Checked;
            }
            set
            {
                ElementEnable.Checked = value;
            }
        }
        private void ElementEnable_CheckedChanged(object sender, EventArgs e)
        {
            MinimalValue.Enabled = MaximalValue.Enabled = ElementEnable.Checked;
        }

        private void Title_TextChanged(object sender, EventArgs e)
        {
            Title.Location = new Point((Size.Width - Title.Width) / 2, Title.Location.Y);
        }

        private void MinimalValue_ValueChanged(object sender, EventArgs e)
        {
            MaximalValue.Minimum = MinimalValue.Value;
        }
    }
}
