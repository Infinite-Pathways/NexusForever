using NexusForever.Game.Abstract.Cinematic;
using NexusForever.Network.Session;
using NexusForever.Network.World.Message.Model.Cinematic;

namespace NexusForever.Game.Cinematic
{
    public class FlagsKeyframe : IFlagsKeyframe
    {
        public uint InitialDelay { get; }
        public uint Flags { get; }

        public FlagsKeyframe(uint delay, uint flags)
        {
            InitialDelay = delay;
            Flags = flags;
        }

        public void Send(IGameSession session)
        {
            session.EnqueueMessageEncrypted(new ServerCinematicScene
            {
                Delay = InitialDelay,
                SceneId = Flags
            });
        }
    }
}
