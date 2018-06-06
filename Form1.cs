using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography; // 加解密用
namespace CSharpAES
{
    public partial class FormAESTest : Form
    {
        public FormAESTest()
        {
            InitializeComponent();
        }

        private void BtnGenIV_Click(object sender, EventArgs e)
        {
            txtAESIV.Text = GetINVKEY(16);
        }
        public static string GetINVKEY(int length = 16)
        {
            var str = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var next = new Random();
            var builder = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                builder.Append(str[next.Next(0, str.Length)]);
            }
            return builder.ToString();
        }
        public static string KeyGenerator(string text)
        {
            Byte[] salt = new Byte[] { 172, 137, 25, 56, 156, 100, 136, 211, 84, 67, 96, 10, 24, 111, 112, 137, 3 };
            int iterations = 1024;
            Rfc2898DeriveBytes rfc1024 = new Rfc2898DeriveBytes(text, salt, iterations);
            Byte[] key = rfc1024.GetBytes(16);
            string base64StringKey = System.Convert.ToBase64String(key);
            return base64StringKey;
        }
        public static string AESEncrypt(string str, string strkey, string strivKey, bool isVasEncrypt = false)
        {
         
            var aesCipher = new AesManaged
            {
                KeySize = 128,
                BlockSize = 128,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };
 
            var keyStr = KeyGenerator(strkey);
            var key = Convert.FromBase64String(keyStr);
            var ivKey = Encoding.UTF8.GetBytes(strivKey);
            var input = str;
            var ivStr = Convert.ToBase64String(ivKey);
    
            aesCipher.Key = key;
            aesCipher.IV = ivKey;
            byte[] b = System.Text.Encoding.UTF8.GetBytes(str); // plain text to be encrypted            
            ICryptoTransform encryptTransform = aesCipher.CreateEncryptor();
            byte[] cipherText = encryptTransform.TransformFinalBlock(b, 0, b.Length);
            return Convert.ToBase64String(cipherText);
        }
        public static string AESDecrypt(string encstring, string strkey, string strivKey)
        {
            var aesCipher = new AesManaged
            {
                KeySize = 128,
                BlockSize = 128,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7
            };
            var keyStr = KeyGenerator(strkey);
            var key = Convert.FromBase64String(keyStr);
            aesCipher.Key = key;
            aesCipher.IV = Encoding.UTF8.GetBytes(strivKey);
            var encryptBytes = Convert.FromBase64String(encstring);
            ICryptoTransform decryptTransform = aesCipher.CreateDecryptor();
            byte[] plainText = decryptTransform.TransformFinalBlock(encryptBytes, 0, encryptBytes.Length);
            return System.Text.Encoding.UTF8.GetString(plainText);
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtAESIV.Text == "")
            {
                BtnGenIV_Click(BtnGenIV,null);
            }
            txtEncrypted.Text = AESEncrypt(txtSource.Text, txtAESKEY.Text, txtAESIV.Text);
        }

        private void BtnDecrpt_Click(object sender, EventArgs e)
        {
            txtDecrpt.Text = AESDecrypt(txtEncrypted.Text, txtAESKEY.Text, txtAESIV.Text);

        }
    }
}
