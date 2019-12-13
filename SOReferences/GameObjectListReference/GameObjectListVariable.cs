using System.Collections.Generic;
using UnityEngine;

namespace Plugins.SOReferences.GameObjectListReference {

    [CreateAssetMenu(fileName = "GameObjectList_Variable", menuName = "SOVariable/GameObjectList")]
    public class GameObjectListVariable : Variable<List<GameObject>> { }
}