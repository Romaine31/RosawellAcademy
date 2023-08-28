using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quizmanger : MonoBehaviour
{
  public List<qanda> QnA; 
  public GameObject[] options;
  public int currentQuestion;
  public Text QuestionTxt;
  [SerializeField] public Image questionImg;        //image for Image Type

  private void Start()
  {
    generateQuestion();
  }
  
  public void correct()
  {
    QnA.RemoveAt(currentQuestion);
    generateQuestion();
  }
  
  void SetAnswer()
  {
    for (int i = 0; i < options.Length; i++)
    {
        options[i].GetComponent<answersscript>().isCorrect = false;
        options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answer[i];
        
        if(QnA[currentQuestion].CorrectAnswer == i+1)
        {
            options[i].GetComponent<answersscript>().isCorrect = true;
        }
    }
  }
  void generateQuestion()
  {
    currentQuestion = Random.Range(0, QnA.Count);
    QuestionTxt.text = QnA[currentQuestion].Question;
    questionImg.sprite = QnA[currentQuestion].questionImage;
    SetAnswer();
    
  }
}

