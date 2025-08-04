using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LicenseKeyGenerator
{
    public partial class LicenseKeyGeneratorForm : Form
    {
        static string privateKeyXml = @"<RSAKeyValue><Modulus>ogmRbH0LJLLsJ1nEtNGUP8NJSuPvfIa+SKVwgczU8xgfdfRKPvXJ2tBd7uRWZzf6DM8WzvcbLQQu9EAMQZ0C6Go7Ft1sgo4guGDTEfMfSQlVijJyGTR8jGrBOd1RF19jHwJipp3Ndv4gk8YcXoR+Zuy/CU4FWbqxIUzJCzLbxyZ2bSvrQu0/jCvXwzgIIhn4PVrpFCvbDmTSnRiIbZfrJVOFOoKZreVYS4wG1gKBZWY7jWZ3GczSUypZdEkBDArQAdcufUY8edzPQuYR9+QHxUgCoLTsgw9krEOQBYw4n+CB4isFUGSjc85NXp/ozGxloqprl6dPCrxMqjCO+kVnsQ==</Modulus><Exponent>AQAB</Exponent><P>w+pPoYUE4Y4IukAYaInXm9+s8hLNUDVXwO3fLFsB7nmhT7Ex3xg2KNR4f96hreDpErMB92Eh87Z0IAOXkzpf6r28MKIw8+EzRN6VQwiBSBSNruy5oChbfenTBA02xiaqAsI1wFiI6yHSUIEVF6EwWkw92ABOt64NAno44PwBVW8=</P><Q>07tv5XNf834No4fKtBaG/IW3AcIdv738pQ1evwRkZeW+7I9suRPpjfmJrMr7BUruKcyGHyF8iuJMpQv/nn9Ny+/OnEHhmV7pvgEDlK3thFWyTK3i75N79JZbPKXLYIkptDLEGu+Q0VeXcUME88qjwEmGwaazedxZ0NgF6I/9xN8=</Q><DP>ZQqLVzpLcijWx3gXHpM45+NMRuz7hsp8H7yOxUmKjXudfoRcvDq4dAZgv1ILAKpmioZYFUW7RP5slbZEjmIk5eRFErATnzQeRP6m7JOOWaaADB96/ObTiPT3J7fI8BkwxYt0PWdr9hjTZ0Grpywyy99WZfiCoKjbfNOcUiymY3E=</DP><DQ>Pa2FTA7O7axTpsaAyvMhAWCmTfHRHrDmbuI1LmnGIVTKyDiDkGp3h68gZuB+PS11sWFt1JW5pO+FKjMTlIU7EWRbCHO8lyPp7Tp4Y5BC92DLXsDssaOB4V8HVuRpGUb7ig2byMjuo7zjVdATGj12dCY3BiRcdew1kbvMBNIlN3s=</DQ><InverseQ>WBbXPqqXII5AMx0y4s1pz9Whau4uFFApSPCal90hNOfc+4KzwVvfq00Vk1XLSF1k5MJxARm237idGKPOsqQDqrZh6ZEiJIRZkXRR72zGFUMvMo58Lk1fn/wnAQzAK+NT1+JiaFXZCoQvn5grPe1y0oUsOl2Yo0Z64WJhvTa2dHc=</InverseQ><D>A7awbIoZHUg0fVpjVbmP6j4xidPbg0EbT1LrVy44mzGsVum4YeUEMU2hOX5mNItl4bFFVoz3RHraEKL/JOnSTT1SCV4dxIg5W8BsVfb6epQKL9akIsu/JwCzWP4ng5+eB/HoDOWE9fsxB/H8aHYk53r5jd8J5FqRALBf0y/hNZk0ueFUExk5R6I2X3o8w4Zl1e9FA6Qag45GzxbRjqe4SuUegQumtTCwWM41/9p9dXg/hDPahtx68sTEr+IbXEnh8LqnaflzRKGOr5/ve9yR9a4jaxJX3gD8PeJnJP8hFh1U8Ua1Led5j7eKM4pp3nLfFXaW7yr5mB1dYJSb78EQuQ==</D></RSAKeyValue>";

        public LicenseKeyGeneratorForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string machineId = txtMachineCode.Text.Trim();
            if (string.IsNullOrEmpty(machineId))
            {
                MessageBox.Show("Please enter a machine code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKeyXml);
                byte[] data = Encoding.UTF8.GetBytes(machineId);
                byte[] signature = rsa.SignData(data, SHA256.Create());
                string licenseKey = Convert.ToBase64String(signature);
                string maskedKey = ToMaskedKey(licenseKey);
                txtMaskedKey.Text = maskedKey;
                txtOriginalKey.Text = licenseKey;
            }
        }

        private void btnCopyMasked_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMaskedKey.Text);
            MessageBox.Show("Masked license key copied to clipboard.", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCopyOriginal_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOriginalKey.Text);
            MessageBox.Show("Original license key copied to clipboard.", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        static string ToMaskedKey(string base64)
        {
            var bytes = Convert.FromBase64String(base64);
            var hex = BitConverter.ToString(bytes).Replace("-", "");
            // Group every 8 chars with a dash for better readability
            return string.Join("-", Enumerable.Range(0, (hex.Length + 7) / 8)
                .Select(i => hex.Substring(i * 8, Math.Min(8, hex.Length - i * 8))));
        }
    }
}