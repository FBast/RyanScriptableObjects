﻿using System;
using System.Collections.Generic;
using Data.SOReferences;

namespace Plugins.SOReferences.DictionaryStringObjectReference {
    [Serializable]
    public class DictionaryStringObjectReference : Reference<Dictionary<string, object>, DictionaryStringObjectVariable> {
        public DictionaryStringObjectReference(Dictionary<string, object> Value) : base(Value) { }
        public DictionaryStringObjectReference() { }
        
        public object GetParam(string paramKey) {
            if (Value == null) return null;
            return Value.ContainsKey(paramKey) ? Value[paramKey] : null;
        }

        public void SetParam(Tuple<string, object> tuple) {
            SetParam(tuple.Item1, tuple.Item2);
        }
		
        public void SetParam(string paramKey, object paramValue) {
            if (Value == null)
                Value = new Dictionary<string, object>();
            RemoveParam(paramKey);
            Value.Add(paramKey, paramValue);
        }

        public void RemoveParam(string paramKey) {
            if (Value.ContainsKey(paramKey))
                Value.Remove(paramKey);
        }
    }
}