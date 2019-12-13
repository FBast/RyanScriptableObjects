using System;
using Data.SOReferences;
using UnityEngine;

namespace Plugins.SOReferences.RendererReference {
    [Serializable]
    public class RendererReference : Reference<Renderer, RendererVariable> {
        public RendererReference(Renderer Value) : base(Value) { }
        public RendererReference() { }
    }

}
