using NexusForever.Game.Abstract.Cinematic;
using NexusForever.Game.Static.Cinematic;
using NexusForever.Network.Session;
using NexusForever.Network.World.Message.Model.Cinematic;

namespace NexusForever.Game.Cinematic
{
    public class Transition : ITransition
    {
        public uint InitialDelay { get; }
        public CameraAddFlags Flags { get; }
        public uint EndTransition { get; }
        public ushort Start { get; }
        public ushort Mid { get; }
        public ushort End { get; }

        public Transition(uint delay, CameraAddFlags flags, uint endTransition, ushort start = 0, ushort mid = 0, ushort end = 0)
        {
            InitialDelay         = delay;
            Flags         = flags;
            EndTransition = endTransition;
            Start         = start;
            Mid           = mid;
            End           = end;
        }

        public void Send(IGameSession session)
        {
            session.EnqueueMessageEncrypted(new ServerCinematicCamera
            {
                Delay             = InitialDelay,
                Flags             = Flags,
                EndTransition     = EndTransition,
                TranDurationStart = Start,
                TranDurationMid   = Mid,
                TranDurationEnd   = End
            });
        }
    }
}
