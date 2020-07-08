using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace GTMT
{
    public partial class COMPortTerminal : Form
    {
        public COMPortTerminal()
        {
            InitializeComponent();
        }

        private void btPS_Click(object sender, EventArgs e)
        {
            //Toàn bộ sự kiện của nút nhấn Port setting sẽ được viết ở trong 
            // [NAME] form2=new [Name](); Name là tên của form cần mở.Name của  form2  là  "Portsetting" ; cho nên:
            Portsetting form2 = new Portsetting();
            form2.ShowDialog();
        }

        private void btOP_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                btOP.Text = "Open Port"; // khi cổng com ngắt kết nối thì sẽ hiển thị trên button là Open Port
                tbxPort.Text = "Đã ngắt kết nối tới cổng COM"; // khi cổng com ngắt kết nối thì sẽ hiển thị trên textbox có Name "tbtPort" là "Đã ...COM"
            }
            else
            {
                try
                {
                    serialPort1.PortName = Properties.Settings.Default.port;// lấy lại thuộc tính port đã lưu lúc nãy
                    serialPort1.BaudRate = Convert.ToInt32(Properties.Settings.Default.bitrate);
                    serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), Properties.Settings.Default.handshaking,
                        true);
                    serialPort1.Open();
                    btOP.Text = "Close Port";// khi cổng com  kết nối thì sẽ hiển thị trên button là Close Port
                    tbxPort.Text = "Đã  kết nối tới cổng COM";
                }
                catch
                {
                    MessageBox.Show("Không thể kết nối cổng" + serialPort1.PortName, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error); // Có những trường hợp không kết nối được với cổng COM thì sẽ xu16t hiện thông báo cảnh cáo lỗi"ko thể kết nối"
                }
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu của thuộc tính Text truyền đi
            serialPort1.Write(txbSend.Text);// "txbSend" là Name của textbox cho nhập dữ liệu cần truyền
        }
    }
}
