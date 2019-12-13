using System;
using UnityEngine;
using UnityEngine.Events;

namespace Plugins.SOEvents.GameObjectEvents {
    [Serializable] public class UnityGameObjectEvent : UnityEvent<GameObject> {}
}