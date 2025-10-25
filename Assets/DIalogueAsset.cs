using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class DIalogueAsset
{
    [field: SerializeField]
    public List<TimedText> Texts { get; private set; }

    [System.Serializable]
    public class TimedText
    {
        [field: SerializeField]
        public string Text { get; private set; }
        [field: SerializeField]
        public string OwnerName { get; private set; }
        [field: SerializeField]
        public float DisplayTime { get; private set; }
        [field: SerializeField]
        public UnityEvent EventToPlay { get; private set; }
    }
}
