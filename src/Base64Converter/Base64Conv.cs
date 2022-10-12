using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64Converter
{
    public partial class Base64Conv : Form
    {
        public static string Base64Encode(string textboxtext)
        {
            var base64encoding = System.Text.Encoding.UTF8.GetBytes(textboxtext);
            return System.Convert.ToBase64String(base64encoding);
        }
        public static string Base64Decode(string decodedbase64)
        {
            var dec_base64 = System.Convert.FromBase64String(decodedbase64);
            return System.Text.Encoding.UTF8.GetString(dec_base64);
        }
        public Base64Conv()
        {
            InitializeComponent();
        }

        private void encodebase64_Click(object sender, EventArgs e)
        {
            base64_textbox2.Text = Base64Encode(base64_textbox1.Text);
        }

        private void decodebase64_Click(object sender, EventArgs e)
        {
            base64_textbox1.Text = Base64Decode(base64_textbox2.Text);
        }
    }
}
