﻿using NexusForever.Game.Abstract.Map.Instance;
using NexusForever.Script.Template;
using NexusForever.Script.Template.Filter;

namespace NexusForever.Script.Main.Example
{
    [ScriptFilterIgnore]
    public class InstancedMapScript : IInstancedMapScript, IOwnedScript<IMapInstance>
    {
    }
}
