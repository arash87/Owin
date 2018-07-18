
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;


namespace Web
{
	[HubName("bugs")]
	public class BugHub : Hub
	{
		public void Send(string text)
		{
			Clients.All.sayHi("whores");
		}
	}
}