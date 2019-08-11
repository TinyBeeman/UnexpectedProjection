using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnexpectedProjection
{
    public partial class MainForm : Form
    {
        private static ImageProjectionForm m_frmProject;
        private FileSystemWatcher m_watcher;
        private UPScreens m_screens;
        private UPScreen m_currentScreen;
        private string m_currentPath;

        public string CurrentPath
        {
            set
            {
                m_currentPath = value;
                tbPath.Text = m_currentPath;
                if (m_watcher != null)
                {
                    StopListening();
                    ListenToFolder();
                }
            }
            get
            {
                return m_currentPath;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            m_screens = new UPScreens();
            RefreshScreens();
            LoadSettings();
            if (Directory.Exists(CurrentPath))
                ListenToFolder();
            else
                StopListening();
        }

        public UPScreen ProjectionScreen
        {
            get { return m_currentScreen; }
            set
            {
                m_currentScreen = value;
            }
        }

        public void ShowProjection()
        {
            if (m_currentScreen == null)
            {
                if (m_frmProject != null)
                {
                    m_frmProject.Close();
                }
                btnProject.Text = "Start Projecting";
            }
            else
            {
                EnsureProjectionWindow();
            }
        }

        public void EnsureProjectionWindow()
        {
            if (m_frmProject == null)
            {
                m_frmProject = new ImageProjectionForm();
                
                m_frmProject.FormClosed += (o, i) => { m_frmProject = null; };
                btnProject.Text = "Stop Projecting";
                UpdateMargins();
                m_frmProject.MaxToScreen(m_currentScreen.WindowsScreen);
            }
        }

        public void RefreshScreens()
        {
            string strCurrent = "";
            if (m_currentScreen != null)
            {
                strCurrent = m_currentScreen.WindowsScreen.DeviceName;
            }
            m_screens = new UPScreens();
            lbScreens.Items.Clear();
            int iFirstNonPrimary = -1;

            foreach (var s in m_screens.Screens)
            {
                int i = lbScreens.Items.Add(s);
                if (iFirstNonPrimary < 0 && !s.WindowsScreen.Primary)
                    iFirstNonPrimary = i;

                if (strCurrent.Length > 0)
                {
                    if (s.WindowsScreen.DeviceName == strCurrent)
                        lbScreens.SelectedIndex = i;
                }
            }

            if (lbScreens.SelectedItem == null && iFirstNonPrimary > 0)
                lbScreens.SelectedIndex = iFirstNonPrimary;
            else
                lbScreens.SelectedIndex = 0;  // No Second Monitor Has Been Found!

        }

        private void BtnRefreshScreens_Click(object sender, EventArgs e)
        {
            RefreshScreens();
        }

        private void BtnProject_Click(object sender, EventArgs e)
        {
            if (m_frmProject == null)
            {
                ShowProjection();
            }
            else
            {
                m_frmProject.Close();
                btnProject.Text = "Project";
            }
        }

        private void BtnListen_Click(object sender, EventArgs e)
        {
            if (m_watcher != null)
            {
                StopListening();
            }
            else
            {
                ListenToFolder();
            }
        }

        private void StopListening()
        {
            if (m_watcher != null)
            {
                m_watcher.EnableRaisingEvents = false;
                m_watcher.Dispose();
                m_watcher = null;
            }
            btnListen.Text = "Listen";
        }

        private void ListenToFolder()
        {
            if (m_watcher == null)
            {
                if (Directory.Exists(m_currentPath))
                {
                    m_watcher = new FileSystemWatcher(m_currentPath);
                    m_watcher.Created += OnCreated;
                    m_watcher.EnableRaisingEvents = true;
                    btnListen.Text = "Stop Listening";
                }
            }

        }

        private static void OnCreated(object source, FileSystemEventArgs e)
        {
            m_frmProject.ShowImage(e.FullPath);
        }

        private void MainForm_Close(object sender, EventArgs e)
        {
            if (m_frmProject != null)
            {
                m_frmProject.Close();
            }
        }

        private void LbScreens_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_currentScreen = (UPScreen)lbScreens.SelectedItem;
        }

        private void BtnChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDlg = new FolderBrowserDialog();
            fbDlg.SelectedPath = CurrentPath;
            fbDlg.ShowNewFolderButton = true;
            if (fbDlg.ShowDialog(this) == DialogResult.OK)
            {
                CurrentPath = fbDlg.SelectedPath;
                SaveSettings();
            }
        }

        private void BtnTestImage_Click(object sender, EventArgs e)
        {
            if (m_frmProject == null)
                ShowProjection();

            m_frmProject.ShowTestImage();
        }

        void SaveSettings()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey("Unexpected", true);
            key.SetValue("ListenPath", CurrentPath);
            key.SetValue("LeftMargin", (int)udLeft.Value);
            key.SetValue("TopMargin", (int)udTop.Value);
            key.SetValue("RightMargin", (int)udRight.Value);
            key.SetValue("BottomMargin", (int)udBottom.Value);
            key.Close();
        }

        private bool m_disableMargins = false;

        void LoadSettings()
        {
            m_disableMargins = true;

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey("Unexpected", false);
            object pathObj = key.GetValue("ListenPath");
            if (pathObj != null)
            {
                CurrentPath = (string)pathObj;
            }
            else
            {
                CurrentPath = "c:\\Temp";
            }

            object leftObject = key.GetValue("LeftMargin");
            if (leftObject != null)
                udLeft.Value = (int)leftObject;

            object topObject = key.GetValue("TopMargin");
            if (topObject != null)
                udTop.Value = (int)topObject;

            object rightObject = key.GetValue("RightMargin");
            if (rightObject != null)
                udRight.Value = (int)rightObject;

            object bottomObject = key.GetValue("BottomMargin");
            if (bottomObject != null)
                udBottom.Value = (int)bottomObject;

            m_disableMargins = false;
            UpdateMargins();
        }

         private void BtnPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void UpdateMargins()
        {
            if (m_disableMargins)
                return;

            if (m_frmProject != null)
            {
                m_frmProject.UpdateMargins((int)udLeft.Value, (int)udTop.Value, (int)udRight.Value, (int)udBottom.Value);
            }
            SaveSettings();
        }

        private void UdLeft_ValueChanged(object sender, EventArgs e)
        {
            UpdateMargins();
        }

        private void UdTop_ValueChanged(object sender, EventArgs e)
        {
            UpdateMargins();
        }

        private void UdRight_ValueChanged(object sender, EventArgs e)
        {
            UpdateMargins();
        }

        private void UdBottom_ValueChanged(object sender, EventArgs e)
        {
            UpdateMargins();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.P:
                    Paste();
                    e.Handled = true;
                    break;
                case Keys.B:
                    BlackOut();
                    e.Handled = true;
                    break;
            }
                
        }


        private void BtnBlackOut_Click(object sender, EventArgs e)
        {
            BlackOut();
        }

        private void BlackOut()
        {
            if (m_frmProject != null)
            {
                m_frmProject.BlackOut();
            }
        }


        private void Paste()
        {
            EnsureProjectionWindow();

            Image iClipboard = Clipboard.GetImage();
            if (iClipboard != null)
                m_frmProject.ShowImage(iClipboard);

            string strPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string strUnique = "\\" + DateTime.Now.ToString("yy-MM-dd-hh-mm-ss-") + DateTime.Now.Ticks.ToString() + ".jpg";

            try
            {
                iClipboard.Save(strPath + strUnique);
            }
            catch (Exception)
            {
                // Silent fail
            }
        }

    }
}
