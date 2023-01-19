using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using MetroFramework;
namespace BunyV2
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }
        static MqttClient client;
        private void btnExit_Click(object sender, EventArgs e)
        {
       
            Environment.Exit(0);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new MqttClient(txtBroker.Text, int.Parse(txtPort.Text), false, MqttSslProtocols.None, null, null);
                client.ProtocolVersion = MqttProtocolVersion.Version_3_1;
                byte code = client.Connect(Guid.NewGuid().ToString(), txtUser.Text, txtPass.Text);
                if (code == 0)
                {
                    MetroMessageBox.Show(this, "Connect Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    checkStatus.Checked = true;
                    //Subcribe Topic
                    client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                    client.Subscribe(new string[] { "Pi/LEDStatus","Pi/Sensor/T", "Pi/Sensor/H" }, new byte[] { 0,0,0});
                    //READ LED STATUS
                    client.Publish("Pi/LEDControl", Encoding.UTF8.GetBytes("@" + 0));
                }

                else MetroMessageBox.Show(this, "Connect Fail", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            catch (Exception)
            {
                MetroMessageBox.Show(this, "Wrong Format", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            txtBroker.Text = "m13.cloudmqtt.com";
            txtPort.Text = "19990";
            txtUser.Text = "";
            txtPass.Text = "";
            checkStatus.Checked = false;
            LEDControl(0);
            pnlLED.Visible = false;
            pnlSensor.Visible = false;

        }



        Action<string, string> ReceiveAction;
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            ReceiveAction = Receive;
            try
            {
                this.BeginInvoke(ReceiveAction, Encoding.UTF8.GetString(e.Message), e.Topic);
            }
            catch { };
        }

        void Receive(string message, string topic)
        {
         
            if (topic=="Pi/LEDStatus")
            {
                byte status = byte.Parse(message);
                LEDControl(status);
                return;
            }
            if (topic == "Pi/Sensor/T")
            {
                lblTemp.Text = message;
                temperature.Value = byte.Parse(message);
            }
            if (topic == "Pi/Sensor/H")
            {
                lblHumi.Text = message;
                humidity.Value = byte.Parse(message);
            }


        }

        void LEDControl(byte status)
        {
            byte[] led=new byte[4];
            for (byte i=0;i<4;i++)
            {
                led[i] = (byte)((status >> i) & 0x01);
            }
            if (led[0] == 1) LED1.Image = Properties.Resources.Light_On_48px;
            else LED1.Image = Properties.Resources.Light_Off_48px;
            if (led[1] == 1) LED2.Image = Properties.Resources.Light_On_48px;
            else LED2.Image = Properties.Resources.Light_Off_48px;
            if (led[2] == 1) LED3.Image = Properties.Resources.Light_On_48px;
            else LED3.Image = Properties.Resources.Light_Off_48px;
            if (led[3] == 1) LED4.Image = Properties.Resources.Light_On_48px;
            else LED4.Image = Properties.Resources.Light_Off_48px;

        }



        private void btnLed1_Click(object sender, EventArgs e)

        {
            Bunifu.Framework.UI.BunifuImageButton but = (Bunifu.Framework.UI.BunifuImageButton)sender;
            char data = but.Name.ToCharArray()[6];
            client.Publish("Pi/LEDControl", Encoding.UTF8.GetBytes("@" + data));

        }

        private void btnLED_Click(object sender, EventArgs e)
        {
            if (pnlLED.Visible == false)
            {
               
                aniLED.ShowSync(pnlLED);
                pnlIntro.Visible = false;
                pnlSensor.Visible = false;
            }
            else
            {
                aniLED.HideSync(pnlLED);
                pnlIntro.Visible = true;
                pnlSensor.Visible = false;
                
            }


        }

        private void btnSensor_Click(object sender, EventArgs e)
        {
            if (pnlSensor.Visible == false)
            {
               
                aniLED.ShowSync(pnlSensor);
                pnlIntro.Visible = false;
                pnlLED.Visible = false;
              
            }
            else
            {
                aniLED.HideSync(pnlSensor);
                pnlIntro.Visible = true;
                pnlLED.Visible = false;

            }
        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
