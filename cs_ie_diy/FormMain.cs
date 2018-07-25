using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_ie_diy
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void toolForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void toolRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void toolHome_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate("http://www.hnhcyy.com");
        }

        private void iE11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine;
                RegistryKey software = key.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true); //该项必须已存在
                software.SetValue("cs_ie_diy.exe", 0x2af8, RegistryValueKind.DWord);//11000
                //在HKEY_LOCAL_MACHINE\SOFTWARE\test下创建一个名为“test”，值为“博客园”的键值。如果该键值原本已经存在，则会修改替换原来的键值，如果不存在则是创建该键值。
                // 注意：SetValue()还有第三个参数，主要是用于设置键值的类型，如：字符串，二进制，Dword等等~~默认是字符串。如：
                // software.SetValue("test", "0", RegistryValueKind.DWord); //二进制信息
                key.Close();
                MessageBox.Show("IE版本设置成功！", "提示");
            }
            catch
            {
                MessageBox.Show("IE版本设置失败！", "提示");
            }
        }

        private void iE10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine;
                RegistryKey software = key.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true); //该项必须已存在
                software.SetValue("cs_ie_diy.exe", 0x2710, RegistryValueKind.DWord);//10000
                //在HKEY_LOCAL_MACHINE\SOFTWARE\test下创建一个名为“test”，值为“博客园”的键值。如果该键值原本已经存在，则会修改替换原来的键值，如果不存在则是创建该键值。
                // 注意：SetValue()还有第三个参数，主要是用于设置键值的类型，如：字符串，二进制，Dword等等~~默认是字符串。如：
                // software.SetValue("test", "0", RegistryValueKind.DWord); //二进制信息
                key.Close();
                MessageBox.Show("IE版本设置成功！", "提示");
            }
            catch
            {
                MessageBox.Show("IE版本设置失败！", "提示");
            }
        }

        private void iE9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine;
                RegistryKey software = key.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true); //该项必须已存在
                software.SetValue("cs_ie_diy.exe", 0x2328, RegistryValueKind.DWord);//9000
                //在HKEY_LOCAL_MACHINE\SOFTWARE\test下创建一个名为“test”，值为“博客园”的键值。如果该键值原本已经存在，则会修改替换原来的键值，如果不存在则是创建该键值。
                // 注意：SetValue()还有第三个参数，主要是用于设置键值的类型，如：字符串，二进制，Dword等等~~默认是字符串。如：
                // software.SetValue("test", "0", RegistryValueKind.DWord); //二进制信息
                key.Close();
                MessageBox.Show("IE版本设置成功！", "提示");
            }
            catch
            {
                MessageBox.Show("IE版本设置失败！", "提示");
            }
        }

        private void iE8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine;
                RegistryKey software = key.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true); //该项必须已存在
                software.SetValue("cs_ie_diy.exe", 0x1f40, RegistryValueKind.DWord);//8000
                //在HKEY_LOCAL_MACHINE\SOFTWARE\test下创建一个名为“test”，值为“博客园”的键值。如果该键值原本已经存在，则会修改替换原来的键值，如果不存在则是创建该键值。
                // 注意：SetValue()还有第三个参数，主要是用于设置键值的类型，如：字符串，二进制，Dword等等~~默认是字符串。如：
                // software.SetValue("test", "0", RegistryValueKind.DWord); //二进制信息
                key.Close();
                MessageBox.Show("IE版本设置成功！", "提示");
            }
            catch
            {
                MessageBox.Show("IE版本设置失败！", "提示");
            }
        }

        private void iE7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine;
                RegistryKey software = key.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true); //该项必须已存在
                software.SetValue("cs_ie_diy.exe", 0x1b58, RegistryValueKind.DWord);//7000
                //在HKEY_LOCAL_MACHINE\SOFTWARE\test下创建一个名为“test”，值为“博客园”的键值。如果该键值原本已经存在，则会修改替换原来的键值，如果不存在则是创建该键值。
                // 注意：SetValue()还有第三个参数，主要是用于设置键值的类型，如：字符串，二进制，Dword等等~~默认是字符串。如：
                // software.SetValue("test", "0", RegistryValueKind.DWord); //二进制信息
                key.Close();
                MessageBox.Show("IE版本设置成功！", "提示");
            } 
            catch
            {
                MessageBox.Show("IE版本设置失败！", "提示");
            }
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            foreach (HtmlElement links in this.webBrowser.Document.Links)
            {
                links.SetAttribute("target", "_self");
            }
            foreach (HtmlElement form in this.webBrowser.Document.Forms)
            {
                form.SetAttribute("target", "_self");
            }  
        }

        private void webBrowser_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
