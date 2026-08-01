using NexusForever.Game.Abstract.Cinematic;
using NexusForever.Network.Session;
using NexusForever.Network.World.Message.Model.Cinematic;

namespace NexusForever.Game.Cinematic
{
    public class ActorVisibility : IActorVisibility
    {
        public uint InitialDelay { get; }
        public IActor Actor { get; }
        public bool Hide { get; }
        public bool AffectOnlyPlayers { get; }

        public ActorVisibility(uint delay, IActor actor, bool hide = false)
        {
            InitialDelay = delay;
            Actor = actor;
            Hide  = hide;
        }

        public void Send(IGameSession session)
        {
            session.EnqueueMessageEncrypted(new ServerCinematicActorVisibility
            {
                Delay             = InitialDelay,
                UnitId            = Actor.UnitId,
                Hide              = Hide,
                AffectOnlyPlayers = AffectOnlyPlayers
            });
        }
    }
}
