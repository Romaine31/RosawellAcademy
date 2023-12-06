using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class problemManager : MonoBehaviour
{
    public List<chemicalSet> chemAns;
    public GameObject chemPrefab;
    public Vector2[] spawnLocations;
    public List<GameObject> cloneList = new List<GameObject>();
    public List<Text> textObjects;
    public GameObject q1;
    public GameObject q2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cloneList.Count < 3){
            spawnChems();
            setChemProblem();
        }
    }

    void spawnChems(){
        for (int i = 0; i < spawnLocations.Length; i++){
            // if (GameObject.FindGameObjectsWithTag("chemical").Length == 1){
            //     clone = Instantiate(chemPrefab, i,Quaternion.identity);
            //     clone.tag = "notChemical";
            //  } else {
            //     int tagPicker = Random.Range(1,2);
            //     clone = Instantiate(chemPrefab, i, Quaternion.identity);
            //     if (tagPicker == 1){
            //         clone.tag = "chemical";
            //     } else {
            //         clone.tag = "notChemical";
            //     }
            // } THIS PREVIOUS CODE WAS TO RANDOMIZE CHEMICAL ASSIGNMENT, I'LL KEEP THIS HERE BUT THIS IS REPLACED BY SEPERATING THE TASK TO DIFFERENT FUNCTIONS TO ADD VERSATILITY -ROMAINE
            GameObject clone = Instantiate(chemPrefab, spawnLocations[i], Quaternion.identity);
            cloneList.Add(clone);
        }
    }

    void setChemProblem(){
        int questionPicker = Random.Range(0, chemAns.Count-1);
        for (int i = 0; i < cloneList.Count; i++){
            if (chemAns[questionPicker].correctAns[i] == 1){
                cloneList[i].tag = "chemicalGoal";
                cloneList[i].GetComponent<Renderer>().material.color = chemAns[questionPicker].colour1;
            } else if (chemAns[questionPicker].correctAns[i] == 2){
                cloneList[i].tag = "chemical";
                cloneList[i].GetComponent<Renderer>().material.color = chemAns[questionPicker].colour2;
            } else {cloneList[i].tag = "notChemical"; cloneList[i].GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 0.5f, 1f, 1f); }
        }
        setQuestion(questionPicker);
        q1.GetComponent<Renderer>().material.color = chemAns[questionPicker].colour1;
        q2.GetComponent<Renderer>().material.color = chemAns[questionPicker].colour2;
    }

    void setQuestion(int qPicker)
    {
        for (int x = 0; x != textObjects.Count; x++)
        {
            textObjects[x].text = chemAns[qPicker].questionAnswer[x];
        }

    }
}
[System.Serializable]
public class chemicalSet{
    public int[] correctAns;
    public string[] questionAnswer;
    public Color colour1;
    public Color colour2;
}
