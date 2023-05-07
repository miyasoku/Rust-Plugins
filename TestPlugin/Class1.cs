using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oxide.Plugins
{
    [Info("Test Plugin", "miyasoku", 1.0)]
    [Description("The simple oxide plugins.")]

    public class Main : RustPlugin
    {
        [ChatCommand("hello")]
        void HelloCommand(BasePlayer player)
        {
            SendMessage(player, "Hello world!" + player.displayName);
        }
        void SendMessage(BasePlayer player, string msg, params object[] args)
        {
            PrintToChat(player, msg, args);
        }
        void Broadcast(string msg, params object[] args)
        {
            PrintToChat(msg);
        }
        void Loaded()
        {
            Broadcast("The test plugins has been reloaded!");
        }
    }
}
