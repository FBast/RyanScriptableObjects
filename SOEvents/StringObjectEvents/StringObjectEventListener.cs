using System;

namespace Plugins.SOEvents.StringObjectEvents {
    public class StringObjectEventListener : BaseGameEventListener<Tuple<string, object>, StringObjectEvent, UnityStringObjectEvent> {}
}