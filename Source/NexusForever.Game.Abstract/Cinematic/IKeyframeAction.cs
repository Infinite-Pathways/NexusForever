using NexusForever.Network.Session;

namespace NexusForever.Game.Abstract.Cinematic
{
    public interface IKeyframeAction
    {
        uint InitialDelay { get; }

        void Send(IGameSession session);
    }
}
