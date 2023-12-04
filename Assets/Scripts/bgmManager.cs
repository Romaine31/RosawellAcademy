using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bgmManager : MonoBehaviour
{
    public List<AudioClip> backgroundMusic;
    public string sceneName;

    void OnEnable() {
        
    }
    void Update(){
        sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "SampleScene"){
            GetComponent<AudioSource>().clip = backgroundMusic[0];
            if (!GetComponent<AudioSource>().isPlaying){
            GetComponent<AudioSource>().Play();
            }
        } else {
            GetComponent<AudioSource>().clip = backgroundMusic[1];
            if (!GetComponent<AudioSource>().isPlaying){
            GetComponent<AudioSource>().Play();
            }
        }
    }
}
