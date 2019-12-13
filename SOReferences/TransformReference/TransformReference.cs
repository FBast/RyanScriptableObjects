﻿using System;
using Data.SOReferences;
using UnityEngine;

namespace Plugins.SOReferences.TransformReference {
    [Serializable]
    public class TransformReference : Reference<Transform, TransformVariable> {
        public TransformReference(Transform Value) : base(Value) { }
        public TransformReference() { }
    }

}
