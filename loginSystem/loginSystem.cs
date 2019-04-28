using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfinityScript;

namespace loginSystem
{
    public class loginSystem : BaseScript
    {
        private static Dictionary<string, string> logins = new Dictionary<string, string>();
        public loginSystem()
        {
            logins.Add("Slvr99", "TestPassword");
            logins.Add("LA|Bubbles", "Bububalo");
        }

        public override string OnPlayerRequestConnection(string playerName, string playerHWID, string playerXUID, string playerIP, string playerSteamID, string playerXNAddress)
        {
            if (!logins.Keys.Contains(playerName))
                return "You have not registered for this server. Please register at www.lemonparty.com";

            GSCFunctions.SetDvar("g_password", logins[playerName]);
            return null;
        }
    }
}
