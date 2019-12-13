using UnityEngine;

namespace Plugins.SOEvents.GameObjectEvents {
    [CreateAssetMenu(fileName = "GameObject_OnEvent", menuName = "SOEvent/GameObject")]
    public class GameObjectEvent : BaseGameEvent<GameObject> { }
}