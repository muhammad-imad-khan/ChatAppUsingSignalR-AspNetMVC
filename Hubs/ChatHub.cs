﻿using Microsoft.AspNetCore.SignalR;

namespace ChatAppUsingSignalR_AspNetMVC.Hubs
{
    public class ChatHub : Hub
    {
        //General Messaging
        public async Task SendMessage(string username, string message)
        {
            await Clients.All.SendAsync("RecieveMessage", username,message);
        }
        //Private Messaging
        //public async Task SendPrivateMessage(string user, string pvtMsg)
        //{
        //    await Clients.User(user).SendAsync("ReceivePrivateMessage", user, pvtMsg);
        //}
        //Grouping Messages Adding
        //public async Task AddToGroup(string grpName)
        //{
        //    await Groups.AddToGroupAsync(Context.ConnectionId, grpName);
        //    await Clients.Group(grpName).SendAsync("Send", $"{Context.ConnectionId} has joined the group{grpName}.");
        //}
        ////Grouping Messages Removing
        //public async Task RemoveToGroup(string grpName)
        //{
        //    await Groups.RemoveFromGroupAsync(Context.ConnectionId, grpName);
        //    await Clients.Group(grpName).SendAsync("Send", $"{Context.ConnectionId} has left the group{grpName}.");
        //}
        //typing indicator
        public async Task userTypingSend(string username, string typing)
        {
            await Clients.Others.SendAsync("userTypingReceive", username, typing);
        }
        ////delivered indicator
        //public async Task msgDeliveredsend(string username, string delivered)
        //{
        //    Clients.Others.SendAsync("msgDeliveredReceive", username, delivered);
        //}
        //seen indicator
        public async Task msgSeenSend(string username, string seen)
        {
            await Clients.Others.SendAsync("msgSeenReceive", username, seen);
        }
        //lastSeen indicator
        public async Task msgLastSeenSend(string username, string lastseen)
        {
            await Clients.Others.SendAsync("msgLastSeenReceive", username, lastseen);
        }
    }
}
