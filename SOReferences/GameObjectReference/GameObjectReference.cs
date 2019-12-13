using System;
using Data.SOReferences;
using UnityEngine;

namespace Plugins.SOReferences.GameObjectReference {
    [Serializable]
    public class GameObjectReference : Reference<GameObject, GameObjectVariable> {
        public GameObjectReference(GameObject Value) : base(Value) { }
        public GameObjectReference() { }
    }
}