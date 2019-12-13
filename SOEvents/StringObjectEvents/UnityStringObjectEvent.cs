using System;
using UnityEngine.Events;

namespace Plugins.SOEvents.StringObjectEvents {
    [Serializable] public class UnityStringObjectEvent : UnityEvent<Tuple<string, object>> {}
}