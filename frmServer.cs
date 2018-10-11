using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Threading;
using System.IO;
using Newtonsoft.Json;

namespace SocketDemo
{
    public partial class frmServer : Form
    {
        private Socket sock, acc;

        public frmServer()
        {
            InitializeComponent();
        }

        Socket socket()
        {
            return  new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = true;
            lstRecived.Items.Add("Server Start..");
            sock = socket();
            sock.Bind(new IPEndPoint(0,3));
            sock.Listen(0);
            new Thread(delegate()
            {
                acc = sock.Accept();
                MessageBox.Show("CONNECTED ACCEPTED!");
                sock.Close();

                while (true)
                {
                    try
                    {
                        byte[] buffer = new byte[255];
                        int rec = acc.Receive(buffer, 0, buffer.Length, 0);

                        if (rec <= 0)
                        {
                            throw new SocketException();
                        }

                        Array.Resize(ref buffer, rec);
                        Invoke((MethodInvoker) delegate { lstRecived.Items.Add(Encoding.Default.GetString(buffer)); });
                    }
                    catch
                    {
                        MessageBox.Show("Disconnection!");
                        //Application.Exit();
                        break;
                    }
                      
                }
            }).Start();
        }

        private void sendMsg(string msg)
        {
            byte[] data = Encoding.Default.GetBytes("Server: " + msg);
            acc.Send(data, 0, data.Length, 0);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendMsg(txtMsg.Text);
        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendMsg(txtMsg.Text);
                txtMsg.Text = "";
            }
        }

        private void frmServer_DoubleClick(object sender, EventArgs e)
        {
            int R, G, B, A;
            string H;
            

            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                this.BackColor = colorDialog1.Color;
                R = colorDialog1.Color.R;
                G = colorDialog1.Color.G;
                B = colorDialog1.Color.B;
                A = colorDialog1.Color.A;
                Color clr= Color.FromArgb(R, G, B);
                H = "#" + clr.B.ToString("X2") + clr.R.ToString("X2") + clr.G.ToString("X2");

                ColorCode clrCode = new ColorCode(R,B,G,A,H);

                string strResultJson = JsonConvert.SerializeObject(clrCode);

                //writ to text file in Json Format
                File.WriteAllText(@"selectedcolor.json", strResultJson);

                Console.WriteLine(strResultJson);

            }
        }

        private void frmServer_Load(object sender, EventArgs e)
        {

        }
    }
}
