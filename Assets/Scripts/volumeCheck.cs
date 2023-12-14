using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumeCheck : MonoBehaviour
{
    public floatValue thisVolume;
    public AudioSource selectedAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selectedAudioSource.volume = thisVolume.initialValue;
    }
}
