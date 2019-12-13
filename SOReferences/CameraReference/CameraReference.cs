using System;
using Data.SOReferences;
using UnityEngine;

namespace Plugins.SOReferences.CameraReference {
    [Serializable]
    public class CameraReference : Reference<Camera, CameraVariable> {
        public CameraReference(Camera Value) : base(Value) { }
        public CameraReference() { }
    }
}