using Microsoft.AspNetCore.SignalR;
using SignalrD1.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace SignalrD1.Hubs
{
    public class ChatHub:Hub
    {
        ITIContext db;
        public ChatHub(ITIContext db)
        {
            this.db = db; 
        }
        #region Groub
        public void joingroup (string groupname,string name)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, groupname);

            Clients.OthersInGroup(groupname).SendAsync("newmember", name,groupname);
        }
        public void sendToGroup( string name,string message,string groupname)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, groupname);

            Clients.OthersInGroup(groupname).SendAsync("groupmessage", name, message, groupname);
        }


        #endregion

        #region Events
        public void sendmessage(chatmessage mess)
        {
            //save in DB
            
            db.chatmessages.Add(mess);
            db.SaveChanges();


            //broadcasting to all online clients
            Clients.All.SendAsync("newmessage", mess);
        }
       


        #endregion
    }
}
