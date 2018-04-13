﻿using System.Linq;
using L2dotNET.Models.Player;
using L2dotNET.Network.serverpackets;
using L2dotNET.Tables;

namespace L2dotNET.Network.clientpackets.RecipeAPI
{
    class RequestRecipeBookDestroy : PacketBase
    {
        private readonly GameClient _client;
        private readonly int _id;

        public RequestRecipeBookDestroy(Packet packet, GameClient client)
        {
            _client = client;
            _id = packet.ReadInt();
        }

        public override void RunImpl()
        {
            L2Player player = _client.CurrentPlayer;
        }
    }
}