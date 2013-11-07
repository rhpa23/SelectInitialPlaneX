using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace SelectInitialPlane
{
    public partial class MainForm : Form
    {

        #region Mensagens
        
        private string _msgChangeSucess = "The initial aircraft for FSX was changing with success. Close this application?";
        private string _msgErroFSXDirectory = "Could not find the FSX directory. Make sure the software is properly installed.";
        private string _msgUnexpectedErro = "An unexpected error occurred: ";

        #endregion

        #region Variáveis da classe
        
        private string _fsPath;

        private string _fsSituation;

        private string _fsxCFG;

        private string _selectedItemTitle;

        private Dictionary<string, AirplanesInfo> _lstAirplanes;

        #endregion

        #region Imports
        
        /// <summary>Escreve um dado para um arquivo de texto. Como um arquivo INI, por exemplo.</summary>
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        #endregion
        
        #region Inicialização
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SetFsVariables();

                _lstAirplanes = new Dictionary<string, AirplanesInfo>();

                BindAllAirplanesInfo();
                BindListPlanes(string.Empty, string.Empty);
                BindExtraOptions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(_msgUnexpectedErro + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Eventos

        private void cmbAircraftManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAircraftManufacturer.SelectedItem != null)
            {
                BindListPlanes(cmbAircraftManufacturer.SelectedItem.ToString(), txbAircraftTitle.Text);    
            }
        }

        private void txbAircraftTitle_TextChanged(object sender, EventArgs e)
        {
            string uiManufacturer = cmbAircraftManufacturer.SelectedItem != null ? cmbAircraftManufacturer.SelectedItem.ToString() : string.Empty;

            if (!string.IsNullOrEmpty(txbAircraftTitle.Text) && txbAircraftTitle.Text.Length >= 3)
            {
                BindListPlanes(uiManufacturer, txbAircraftTitle.Text);
            }
            else if (txbAircraftTitle.Text.Length == 0)
            {
                BindListPlanes(uiManufacturer, string.Empty);
            }
        }

        void icon_OnIconSelect(object sender, EventArgs e)
        {
            if (sender != null)
            {
                ClearSelection();
                ((UiIcon)sender).SetCheckChange(true);
                _selectedItemTitle = ((UiIcon)sender).AirplaneInfo.Title;
                SetInfoFromSelectedPlane();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(_selectedItemTitle))
                {
                    WritePrivateProfileString("Sim.0", "Sim", _selectedItemTitle, _fsSituation);
                    WritePrivateProfileString("GRAPHICS", "D3D10", ckbDX10.Checked ? "1" : "0", _fsxCFG);
                    WritePrivateProfileString("Display", "BLOOM_EFFECTS", ckbBloomEffects.Checked ? "1" : "0", _fsxCFG);

                    if (MessageBox.Show(_msgChangeSucess, "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
   
        #region Métodos

        private void SetInfoFromSelectedPlane()
        {
            try
            {
                if (!string.IsNullOrEmpty(_selectedItemTitle))
                {
                    AirplanesInfo selectedAirplanesInfo = _lstAirplanes[_selectedItemTitle];
                    string planeDirectoryRoot = Path.GetDirectoryName(selectedAirplanesInfo.PathAircraftCFG);

                    SetLabelValue(lblAirlineName, selectedAirplanesInfo.AirlineName);
                    SetLabelValue(lblAtcAirline, selectedAirplanesInfo.AtcAirline);
                    SetLabelValue(lblAtcFlightNumber, selectedAirplanesInfo.AtcFlightNumber);
                    SetLabelValue(lblAtcId, selectedAirplanesInfo.AtcId);
                    SetLabelValue(lblAtcParkingCodes, selectedAirplanesInfo.AtcParkingCodes);
                    SetLabelValue(lblUiCreatedBy, selectedAirplanesInfo.UiCreatedby);
                    SetLabelValue(lblUiManufacturer, selectedAirplanesInfo.UiManufacturer);
                    SetLabelValue(lblUiType, selectedAirplanesInfo.UiType);
                    SetLabelValue(lblUiTypeRole, selectedAirplanesInfo.UiTypeRole);
                    SetLabelValue(lblUiVariation, selectedAirplanesInfo.UiVariation);
                    SetLabelValue(lblAtcParkingCodes, selectedAirplanesInfo.AtcParkingCodes);
                    SetLabelValue(lblAtcParkingCodes, selectedAirplanesInfo.AtcParkingCodes);

                    //toolTipForm.SetToolTip(pbxThumbnail, selectedAirplanesInfo.Description.Replace("\\n", Environment.NewLine));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(_msgUnexpectedErro + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearSelection()
        {
            foreach (UiIcon controlIcon in pnlIcons.Controls)
            {
                controlIcon.SetCheckChange(false);
            }
        }

        private void SetFsVariables()
        {
            _fsPath = GetInstallPathFS(); // "C:\\temp\\FSX"
            SetLabelValue(lblPathFS, _fsPath);

            _fsxCFG = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\FSX\\fsx.cfg";

            _fsSituation = GetFileProperty(_fsxCFG, "USERINTERFACE", "SITUATION") + ".flt";
            SetLabelValue(lblCurrentSituation, Path.GetFileName(_fsSituation));
        }

        private void BindListPlanes(string uiManufacturer, string title)
        {
            pnlIcons.Controls.Clear();
            _selectedItemTitle = GetFileProperty(_fsSituation, "Sim.0", "Sim"); 
            foreach (KeyValuePair<string, AirplanesInfo> item in _lstAirplanes)
            {
                if ((string.IsNullOrEmpty(uiManufacturer) || item.Value.UiManufacturer == uiManufacturer) &&
                    (string.IsNullOrEmpty(title) || item.Value.Title.ToLower().Contains(title.ToLower())))
                {
                    UiIcon icon = new UiIcon(item.Value);
                    icon.OnIconSelect += icon_OnIconSelect;
                    pnlIcons.Controls.Add(icon);
                    toolTipForm.SetToolTip(icon, item.Value.Description.Replace("\\n", Environment.NewLine));

                    if (item.Value.Title == _selectedItemTitle)
                    {
                        icon.SetCheckChange(true);
                    }

                    if (!cmbAircraftManufacturer.Items.Contains(item.Value.UiManufacturer))
                    {
                        cmbAircraftManufacturer.Items.Add(item.Value.UiManufacturer);
                    }
                }
            }
        }

        private void BindExtraOptions()
        {
            int propertyDX10;
            if (int.TryParse(GetFileProperty(_fsxCFG, "GRAPHICS", "D3D10"), out propertyDX10))
            {
                ckbDX10.Checked = Convert.ToBoolean(propertyDX10);
            }

            int propertyBloomEffects;
            if (int.TryParse(GetFileProperty(_fsxCFG, "Display", "BLOOM_EFFECTS"), out propertyBloomEffects))
            {
                ckbBloomEffects.Checked = Convert.ToBoolean(propertyBloomEffects);
            }
        }

        private void BindAllAirplanesInfo()
        {
            try
            {
                string pathAirplanes = @"\SimObjects\Airplanes\";

                DirectoryInfo dirPlanesInfo = new DirectoryInfo(_fsPath + pathAirplanes);
                DirectoryInfo[] lstDirPlanesInfo = dirPlanesInfo.GetDirectories();
                foreach (DirectoryInfo itemDirInfo in lstDirPlanesInfo)
                {
                    AddPlanesInfoByPath(itemDirInfo.FullName + "\\aircraft.cfg");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(_msgUnexpectedErro + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPlanesInfoByPath(string planePath)
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    string session = string.Format("fltsim.{0}", i);
                    AirplanesInfo planeInfo = new AirplanesInfo();

                    planeInfo.Title = GetFileProperty(planePath, session, "title");
                    planeInfo.AirlineName = GetFileProperty(planePath, session, "airline_name");
                    planeInfo.AtcAirline = GetFileProperty(planePath, session, "atc_airline");
                    planeInfo.AtcFlightNumber = GetFileProperty(planePath, session, "atc_flight_number");
                    planeInfo.AtcId = GetFileProperty(planePath, session, "atc_id");
                    planeInfo.AtcParkingCodes = GetFileProperty(planePath, session, "atc_parking_codes");
                    planeInfo.Description = GetFileProperty(planePath, session, "description");
                    planeInfo.Texture = GetFileProperty(planePath, session, "texture");
                    planeInfo.UiCreatedby = GetFileProperty(planePath, session, "ui_createdby");
                    planeInfo.UiManufacturer = GetFileProperty(planePath, session, "ui_manufacturer");
                    planeInfo.UiType = GetFileProperty(planePath, session, "ui_type");
                    planeInfo.UiTypeRole = GetFileProperty(planePath, session, "ui_typerole");
                    planeInfo.UiVariation = GetFileProperty(planePath, session, "ui_variation");

                    planeInfo.PathAircraftCFG = planePath;

                    if (string.IsNullOrEmpty(planeInfo.Title.Trim()))
                    {
                        break;
                    }

                    _lstAirplanes.Add(planeInfo.Title, planeInfo);
                }
                SetLabelValue(lblAmountPlanes, "( " + _lstAirplanes.Count + " )");
            }
            catch (Exception ex)
            {
                MessageBox.Show(_msgUnexpectedErro + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetFileProperty(string path, string session, string property)
        {
            StringBuilder value = new StringBuilder(255);
            GetPrivateProfileString(session, property, "", value, 255, path);
            return value.ToString();
        }

        private string GetInstallPathFS()
        {
            try
            {
                string strPath = @"Software\Microsoft\Microsoft Games\Flight Simulator\10.0";
                RegistryKey regKeyAppRoot = Registry.CurrentUser.CreateSubKey(strPath);
                string appPath = (string)regKeyAppRoot.GetValue("AppPath");

                if (string.IsNullOrEmpty(appPath))
                {
                    MessageBox.Show(_msgErroFSXDirectory, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return @"C:\Program Files\Microsoft Games\Flight Simulator X\";
                }

                return appPath;
            }
            catch (Exception)
            {
                MessageBox.Show(_msgErroFSXDirectory, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return @"C:\Program Files\Microsoft Games\Flight Simulator X\";
        }

        private void SetLabelValue(Label Label, string text)
        {
            Label.Text = Label.Text.Split(':').GetValue(0) + ": " + text;
        }

        #endregion

    }
}
