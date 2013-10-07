using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SelectInitialPlane
{
    public partial class UiIcon : UserControl
    {
        private AirplanesInfo _airplanesInfo;
        public AirplanesInfo AirplaneInfo
        {
            get { return _airplanesInfo; }
        }

        public event EventHandler OnIconSelect;

        public UiIcon(AirplanesInfo airplanesInfo)
        {
            InitializeComponent();
            _airplanesInfo = airplanesInfo;
            BindInfo();
        }

        #region Methods

        private void BindInfo()
        {
            lblName.Text = _airplanesInfo.Title;
            string planeDirectoryRoot = Path.GetDirectoryName(_airplanesInfo.PathAircraftCFG);

            pbxImage.ImageLocation = planeDirectoryRoot + "\\Texture." + _airplanesInfo.Texture + "\\thumbnail.jpg";
            // TODO: set
        }

        #endregion

        private void UI_Click(object sender, EventArgs e)
        {
            if ( !(sender is CheckBox))
                checkBox1.Checked = !checkBox1.Checked;

            

            if (OnIconSelect != null)
            {
                OnIconSelect(this, e);
            }
        }

        public void SetCheckChange(bool check)
        {
            checkBox1.Checked = check;

            if (check)
            {
                this.BackColor = SystemColors.Highlight;
            }
            else
            {
                this.BackColor = SystemColors.Control;
            }
        }
        
        public bool IsChecked()
        {
            return checkBox1.Checked;
        }

    }
}
