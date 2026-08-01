using NexusForever.Game.Abstract.Cinematic;
using NexusForever.Network.Session;
using NexusForever.Network.World.Message.Model.Cinematic;

namespace NexusForever.Game.Cinematic
{
    public class Scene : IScene
    {
        public uint InitialDelay { get; }
        public uint SceneId { get; }

        public Scene(uint delay, uint sceneId)
        {
            InitialDelay = delay;
            SceneId = sceneId;
        }

        public void Send(IGameSession session)
        {
            session.EnqueueMessageEncrypted(new ServerCinematicScene
            {
                Delay = InitialDelay,
                SceneId = SceneId
            });
        }
    }
}