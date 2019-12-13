﻿using System;
using Data.SOReferences;

namespace Plugins.SOReferences.FloatReference {
    [Serializable]
    public class FloatReference : Reference<float, FloatVariable> {
        public FloatReference(float Value) : base(Value) { }
        public FloatReference() { }
    }
}
