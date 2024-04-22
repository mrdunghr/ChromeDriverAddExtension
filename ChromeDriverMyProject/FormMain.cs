using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Threading;
using System.Windows.Forms;

namespace ChromeDriverMyProject
{
    public partial class FormMain : Form
    {
        private List<ChromeDriver> chromeWindows = new List<ChromeDriver>();
        private int itemCounter = 1;
        private object counterLock = new object();
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            openChrome();
        }

        private void bnt_newplus_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int windowCount))
            {
                if (windowCount > 0)
                {
                    for (int i = 0; i < windowCount; i++)
                    {
                        openChrome();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một số nguyên dương vào ô số lượng cửa sổ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên dương vào ô số lượng cửa sổ.");
            }
        }

        private void btn_newThread_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int windowCount))
            {
                if (windowCount > 0)
                {
                    for (int i = 0; i < windowCount; i++)
                    {
                        int index = i;

                        Thread thread = new Thread(() => {
                            openChrome();
                        });
                        thread.IsBackground = true;
                        thread.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một số nguyên dương vào ô số lượng cửa sổ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên dương vào ô số lượng cửa sổ.");
            }
        }

        private void openChrome()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--window-size=428,520"); // x428 y923
            options.AddArgument("--window-position=-7,0");
            //options.AddArgument("app=https://web.telegram.org/");
            options.AddArgument("load-extension=" + Path.Combine(Application.StartupPath, "auto-catizen-airdroptrieudo"));

            ChromeDriver chrome = new ChromeDriver(service, options);
            chromeWindows.Add(chrome);
            //chrome.Url = "https://twitter.com/";
            chrome.Url = "https://web.telegram.org/";
            chrome.Navigate();

            lock (counterLock) // Sử dụng lock để đảm bảo đồng bộ hóa việc tăng giá trị của itemCounter
            {
                ListViewItem newItem = new ListViewItem(itemCounter.ToString());
                newItem.SubItems.Add(chrome.Url + " - " + chrome.Title);
                newItem.Tag = chrome; // Gắn chrome vào Tag của ListViewItem
                listView1.Items.Add(newItem);

                itemCounter++; // Tăng giá trị của itemCounter
            }
        }

        private void btn_sorting_Click(object sender, EventArgs e)
        {
            // Sắp xếp danh sách các cửa sổ theo vị trí và kích thước
            chromeWindows = chromeWindows.OrderBy(chrome => chrome.Manage().Window.Position.X).ToList();
            int currentX = -7;
            int currentY = 0;

            foreach (ChromeDriver chrome in chromeWindows)
            {
                // Kiểm tra nếu vị trí X mới vượt quá giới hạn của màn hình (1920), sắp xếp cửa sổ xuống dưới
                if (currentX + 428 > Screen.PrimaryScreen.Bounds.Width)
                {
                    currentX = -7; // Đặt lại vị trí X
                    currentY += 100; // Tăng vị trí Y cho cửa sổ tiếp theo
                }

                chrome.Manage().Window.Position = new System.Drawing.Point(currentX, currentY);
                currentX += 413; // Tăng vị trí X cho cửa sổ tiếp theo
            }
        }

        private void btn_closeAll_Click(object sender, EventArgs e)
        {
            foreach (ChromeDriver chrome in chromeWindows)
            {
                chrome.Quit();
            }

            chromeWindows.Clear();
            listView1.Items.Clear();
            itemCounter = 1;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectItem = listView1.SelectedItems[0];
                ChromeDriver chromeSelect = selectItem.Tag as ChromeDriver;
                if (chromeSelect != null)
                {
                    chromeSelect.Url = "https://google.com/";
                    chromeSelect.Navigate();
                }
            }
        }

        //private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (listView1.SelectedItems.Count > 0)
        //    {
        //        ListViewItem selectedItem = listView1.SelectedItems[0];
        //        ChromeDriver chromeToClose = selectedItem.Tag as ChromeDriver;
        //        if (chromeToClose != null)
        //        {
        //            chromeToClose.Quit();
        //            chromeWindows.Remove(chromeToClose);
        //            listView1.Items.Remove(selectedItem);
        //            itemCounter--; // Cập nhật lại itemCounter
        //        }
        //    }
        //}

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                ChromeDriver chromeToClose = selectedItem.Tag as ChromeDriver;
                if (chromeToClose != null)
                {
                    chromeToClose.Quit();
                    chromeWindows.Remove(chromeToClose);
                }
                listView1.Items.Remove(selectedItem);
                itemCounter--; // Cập nhật lại itemCounter
            }
        }
    }
}
