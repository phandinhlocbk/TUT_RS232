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
    public partial class Portsetting : Form
    {
        public Portsetting()
        {
            InitializeComponent();
        }

        private void Portsetting_Load(object sender, EventArgs e)
        {
            //CÀI ĐẶT PORT
            string[] ComList = SerialPort.GetPortNames();   // lấy các cổng COM có trong máy tính
            // Chưa sắp xếp các cổng COM theo thứ tự - tự bổ sung thêm thuật toán. 
            Array.Sort(ComList);
            cbxPort.Items.AddRange(ComList);
            //CÀI ĐẶT BAUDRATE
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            Array.Sort(BaudRate);
            cbxBitrate.Items.AddRange(BaudRate);
            //CÀI ĐẶT CHẾ ĐỘ HANDSHAKE
            String[] HandShake = { "None", " XOnXOff ", "RequestToSend", "RequestToSendXOnXOff" };
            Array.Sort(HandShake);
            cbxHandshaking.Items.AddRange(HandShake);
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            // port,bitrate,handshaking trong bảng setting
            Properties.Settings.Default.port = cbxPort.Text;//cbxPort.Text là lấy thuộc tính text của comboBox PORT có NAME là cbxPort 
            Properties.Settings.Default.bitrate = cbxBitrate.Text;//cbxBitrate.Text là lấy thuộc tính text của comboBox BitRate có NAME cbxBitrate
            Properties.Settings.Default.handshaking = cbxHandshaking.Text;//tương tự 
            Properties.Settings.Default.Save(); // lưu lại các thuộc tính port,bitrate,handshaking để dùng cho việc lập trình tiếp theo
            this.Close();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close(); // khi nhấn nút Cancel thì cửa sổ Port setting đóng lại.
        }
    }
}
