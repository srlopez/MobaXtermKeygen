using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace MobaXterm_Keygen
{
    public partial class FrmMain : Form
    {
        public class LicenseType
        {
            static Dictionary<string, int> licenseTypes = new Dictionary<string, int>()
                { { "Professional", 1 }, { "Educatinal", 3 }, { "Personal", 4 } };

            public static int getId(string type)
            {
                licenseTypes.TryGetValue(type, out var id);
                return id;
            }
        }

        public FrmMain()
        {
            InitializeComponent();
            licenseComboBox.SelectedIndex = 0;
        }

        private void btnGetVersion_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "File Exe |MobaXterm.exe";

            if (fileDialog.ShowDialog() != DialogResult.OK)
                return;

            var exeVersion = FileVersionInfo.GetVersionInfo(fileDialog.FileName);
            majorVersion.Value = exeVersion.FileMajorPart;
            minorVersion.Value = exeVersion.FileMinorPart;
        }

        private static byte[] EncryptBytes(int key, byte[] bytes)
        {
            byte[] encodedBytes = { };
            for (var i = 0; i < bytes.Length; i++)
            {
                encodedBytes = encodedBytes.Append(Convert.ToByte(bytes[i] ^ ((key >> 8) & 0xff))).ToArray();
                key = encodedBytes[i] & key | 0x482D;
            }

            return encodedBytes;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                GenerateLicense(LicenseType.getId(licenseComboBox.SelectedItem.ToString()),
                    (int)users.Value, txtBoxName.Text, (int)majorVersion.Value, (int)minorVersion.Value);
                MessageBox.Show("Actived License Successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not active license successful...","Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GenerateLicense(
            int type,
            int count,
            string userName,
            int majorVersion,
            int minorVersion)
        {
            var licenseString = string.Format("{0}#{1}|{2}{3}#{4}#{2}3{3}6{0}#{5}#{6}#{7}#", type, userName,
                majorVersion, minorVersion, count, 0, 0, 0);
            var encodedLicenseString = Base64Encoder.Encode(EncryptBytes(0x787, Encoding.UTF8.GetBytes(licenseString)));

            using (var memoryStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    var licenseFile = archive.CreateEntry("Pro.key");

                    using (var entryStream = licenseFile.Open())
                    using (var streamWriter = new StreamWriter(entryStream))
                    {
                        streamWriter.Write(encodedLicenseString);
                    }
                }

                using (var fileStream = new FileStream( @"C:\Program Files (x86)\Mobatek\MobaXterm\Custom.mxtpro", FileMode.Create))
                {
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    memoryStream.CopyTo(fileStream);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}