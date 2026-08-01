using NexusForever.Game.Abstract.Cinematic;
using NexusForever.Network.Session;
using NexusForever.Network.World.Message.Model.Cinematic;

namespace NexusForever.Game.Cinematic
{
    public class CameraAttach : ICameraAttach
    {
        public uint AttachType { get; set; }
        public uint AttachId { get; set; }
        public uint InitialDelay { get; set; }
        public uint ParentUnitId { get; set; }
        public bool UseRotation { get; set; }

        public CameraAttach(uint delay, uint attachId, ICamera parentUnit, uint attachType = 0, bool useRotation = true)
        {
            InitialDelay        = delay;
            AttachId     = attachId;
            ParentUnitId = parentUnit.CameraActor.UnitId;
            AttachType   = attachType;
            UseRotation  = useRotation;
        }

        public void Send(IGameSession session)
        {
            session.EnqueueMessageEncrypted(new ServerCinematicCameraAttach
            {
                AttachType   = AttachType,
                AttachId     = AttachId,
                Delay        = InitialDelay,
                ParentUnitId = ParentUnitId,
                UseRotation  = UseRotation
            });
        }
    }
}
