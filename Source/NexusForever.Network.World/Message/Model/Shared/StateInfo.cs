﻿using NexusForever.Network.Message;

namespace NexusForever.Network.World.Message.Model.Shared
{
    public class StateInfo : IWritable
    {
        public uint State { get; set; }
        public uint TimeElapsed { get; set; }

        public void Write(GamePacketWriter writer)
        {
            writer.Write(State, 3u);
            writer.Write(TimeElapsed);
        }
    }
}
