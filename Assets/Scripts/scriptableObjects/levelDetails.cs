using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class levelDetails : ScriptableObject
{
    public List<levelsInformation> levelInfo;
    [System.Serializable]
    public class levelsInformation
    {
        public string sceneName;
        public Vector2 playerSpawnPosition;
        public Vector2 minBoundary;
        public Vector2 maxBoundary;

    }
}
