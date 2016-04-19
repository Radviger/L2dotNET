﻿
namespace L2dotNET.Game.network.l2recv
{
    class RequestTeleportBookMark : GameServerNetworkRequest
    {
        private int id;
        public RequestTeleportBookMark(GameClient client, byte[] data)
        {
            base.makeme(client, data, 6);
        }

        public override void read()
        {
            id = readD();
        }

        public override void run()
        {
            L2Player player = Client.CurrentPlayer;

            if (player.Telbook == null)
            {
                player.sendSystemMessage(2358); //You have no space to save the teleport location.
                player.sendActionFailed();
                return;
            }

            player.Telbook.UseMark(player, (byte)id);
        }
    }
}
