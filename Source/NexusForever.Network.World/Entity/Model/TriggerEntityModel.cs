using NexusForever.Network.Message;

namespace NexusForever.Network.World.Entity.Model
{
    public class TriggerEntityModel : IEntityModel
    {
        public class Bound : IWritable
        {
            public byte Type { get; set; }
            public Position Min { get; set; }
            public Position Lim { get; set; }
            public float Radius { get; set; }

            public void Write(GamePacketWriter writer)
            {
                writer.Write(Type, 2);
                Min.Write(writer);
                Lim.Write(writer);
                writer.Write(Radius);
            }
        }

        public string Name { get; set; }
        public List<Bound> Bounds { get; } = new();

        public void Write(GamePacketWriter writer)
        {
            writer.WriteStringWide(Name);
            writer.Write((byte)Bounds.Count, 8);
            Bounds.ForEach(s => s.Write(writer));
        }
    }
}
