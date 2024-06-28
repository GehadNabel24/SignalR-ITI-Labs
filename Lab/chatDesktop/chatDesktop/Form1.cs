using System.Drawing;
using System.Xml.Linq;
using Microsoft.AspNetCore.SignalR.Client;
namespace chatDesktop
{
    public partial class Form1 : Form
    {
        HubConnection con;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new HubConnectionBuilder().WithUrl("https://localhost:7203/chat").Build();

            con.StartAsync();

            con.On<string, string>("newmember", (n, g) =>
            {
                ChatList.Invoke(new Action(() => ChatList.Items.Add(n + " Joined in group " + g)));
            });


            con.On<string, string>("messagetoall", (n, m) =>
            {
                ChatList.Invoke(new Action(() => ChatList.Items.Add("(" + n + ") " + m)));
            });


            con.On<string, string, string>("groupmessage", (g, n, m) =>
            {
                ChatList.Invoke(new Action (()=> ChatList.Items.Add(n + "(" + g + ") " + m)));
            });

        }

        private void sendToAll_Click(object sender, EventArgs e)
        {
            con.InvokeAsync("sendtoall", txt_name.Text, txt_mess.Text);
        }

        private void Join_Click(object sender, EventArgs e)
        {
            con.InvokeAsync("joingroup", txt_group.Text, txt_name.Text);
        }

        private void groupMess_Click(object sender, EventArgs e)
        {
            con.InvokeAsync("sendtogroup", txt_group.Text, txt_name.Text, txt_mess.Text);
        }
    }
}
