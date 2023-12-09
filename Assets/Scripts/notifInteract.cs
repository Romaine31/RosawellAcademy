using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notifInteract : MonoBehaviour
{
    public string textContent;
    public Text notifText;
    public GameObject notifPanel;
    // Start is called before the first frame update
    void Start()
    {
        notifPanel.SetActive(false);
    }

    public void notifDisplay(){
        notifText.text = textContent;
        StartCoroutine(notifAnimator());
    }

    IEnumerator notifAnimator(){
        notifPanel.SetActive(true);
        yield return new WaitForSeconds(3);
        notifPanel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
