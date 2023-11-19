using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class npcDetail : ScriptableObject
{
    [SerializeField]
    public npcDetails[] npcValues;

    [System.Serializable]
    public class npcDetails{
        public string name;
        //hi, minor issue, depending on how the sprites are implemented this has to change
        public Sprite npcImagePlaceholder;
        public float multiplier;
        public float admiration;
    }
}
