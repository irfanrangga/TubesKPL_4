using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManajemenPerpus.CLI.Service;

namespace ManajemenPerpus.GUI.CustomControl
{
    public partial class UlasanList : UserControl
    {
        private UlasanService _ulasanService = new UlasanService();
        public UlasanList()
        {
            InitializeComponent();
            this.AutoSize = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Margin = new Padding(10);
        }

        #region Properties
        private string _idUlasan;
        private string _isiUlasan;

        [Category("Custom Properties")]
        public string IdUlasan
        {
            get { return _idUlasan; }
            set { _idUlasan = value; IdUlasanLabel.Text = value; }
        }

        [Category("Custom Properties")]
        public string IsiUlasan
        {
            get { return _isiUlasan; }
            set { _isiUlasan = value; IsiUlasanLabel.Text = value; IsiUlasanLabel.MaximumSize = new Size(700, 0); IsiUlasanLabel.AutoSize = true; }
        }

        public void SetUlasan(string isiUlasan)
        {
            IdUlasan = _ulasanService.GenerateUlasanId();
            IsiUlasan = isiUlasan;
        }

        #endregion
    }
}
