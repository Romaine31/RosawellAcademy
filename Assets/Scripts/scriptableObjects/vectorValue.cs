using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// this function stores values when the player changes scenes
[CreateAssetMenu]
[System.Serializable]
public class vectorValue : ScriptableObject
{
    public Vector2 initialValue;
    public Vector2 defaultValue;

}
