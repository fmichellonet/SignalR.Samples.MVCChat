using System.Net;

namespace SignalR.Samples.MVCChat.Hubs.Chat.ContentProviders {
    public interface IContentProvider {
        string GetContent(HttpWebResponse response);
    }
}