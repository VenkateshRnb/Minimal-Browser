using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        public Form1()
        {
            InitializeComponent();           
        }

        ToolTip t1 = new ToolTip(); //Tooltip for accessibility

        private void Form1_Load(object sender, EventArgs e)
        {
            
            CefSettings settings = new CefSettings();
            //Screen Rendering issues
            settings.SetOffScreenRenderingBestPerformanceArgs();
            //initialize with given settings
            Cef.Initialize(settings);

            //Start Chrome at start
            InitializeChromium();
        }

        private void InitializeChromium()
        {
            urlBox.Text = "https://www.google.co.in";

            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.SizeMode = TabSizeMode.Fixed;
            //tabControl.Controls.Add(tab);
            //tabControl.SelectTab(tabControl.TabCount - 1);

            chromeBrowser = new ChromiumWebBrowser(urlBox.Text);

            //Add browser to form
            this.panelArea.Controls.Add(chromeBrowser); 
            // Fills Browser to form
            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.AddressChanged += ChromeBrowser_AddressChanged;
        }

        private void ChromeBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                urlBox.Text = e.Address;
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void urlBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoButtonClick(object sender, EventArgs e)
        {
            if(urlBox.Text!=null)
            {
                chromeBrowser.Load(urlBox.Text);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Refresh();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(chromeBrowser.CanGoBack)
            {
                chromeBrowser.Back();
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if(chromeBrowser.CanGoForward)
            {
                chromeBrowser.Forward();
            }
        }

        private void urlBoxEnterPressed(object sender, EventArgs e)
        {
            if (urlBox.Text != null)
            {
                chromeBrowser.Load(urlBox.Text);
            }
        }

        private void closeTabButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab.Dispose();
        }

        private void newTabButton_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab        ";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
           // tabControl.ItemSize = Tab
            InitializeChromium();
            chromeBrowser.Parent = tab;

            
        }

        private void ChromeBrowser_AddressChanged1(object sender, AddressChangedEventArgs e)
        {
            tabControl.SelectedTab.Text = chromeBrowser.Text;
            this.Invoke(new MethodInvoker(() =>
            {
                urlBox.Text = e.Address;
            }));
        }

        //Draws the X button in every tab
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            //This code will render a "x" mark at the end of the Tab caption. 
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControl.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        //Used to close the tab after clicking the X button
        private void tabControl_MouseDown(object sender, MouseEventArgs e)        
        {
            //Looping through the controls.
            for (int i = 0; i < this.tabControl.TabPages.Count; i++)
            {
                Rectangle r = tabControl.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabControl.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void panelArea_Paint(object sender, PaintEventArgs e)
        {

        }

        //TOOLTIP FOR BUTTONS FOR EASY ACCESSIBILITY
        //Tool tip for Back Button
        private void backButton_MouseHover(object sender, EventArgs e) => t1.Show("Back", backButton);

        //Tool tip for Forward Button
        private void forwardButton_MouseHover(object sender, EventArgs e) => t1.Show("Forward", forwardButton);

        //Tool tip for Refresh Button
        private void refreshButton_MouseHover(object sender, EventArgs e) => t1.Show("Refresh", refreshButton);

        //Tool tip for Stop Button
        private void stopButton_MouseHover(object sender, EventArgs e) => t1.Show("Stop", stopButton);

        //Tool tip for Go Button
        private void goButton_MouseHover(object sender, EventArgs e) => t1.Show("Go", goButton);

        //Tool tip for new tab button
        private void newTabButton_MouseHover(object sender, EventArgs e) => t1.Show("New Tab", newTabButton);
        
    }
}
