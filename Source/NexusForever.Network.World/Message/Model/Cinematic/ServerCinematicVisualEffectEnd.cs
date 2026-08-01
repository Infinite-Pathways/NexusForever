using NexusForever.Network.Message;

namespace NexusForever.Network.World.Message.Model.Cinematic
{
    [Message(GameMessageOpcode.ServerCinematicVisualEffectEnd)]
    public class ServerCinematicVisualEffectEnd : IWritable
    {
        public uint InitialDelay { get; set; }
        public uint VisualEffectUniqueId { get; set; }

        public void Write(GamePacketWriter writer)
        {
            writer.Write(InitialDelay);
            writer.Write(VisualEffectUniqueId);
        }
    }
}
