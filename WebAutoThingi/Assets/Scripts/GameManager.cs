using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    #region variables
    public GameObject question;
    public Image questionPicture;
    public GameObject ans1; // button's 1 texts
    public GameObject ans2;
    public GameObject ans3;
    public GameObject ans4;
    public Button but1;
    public Button but2;
    public Button but3;
    public Button but4;
    public GameObject gamePanel;
    public GameObject AfterGamePanel;
    public GameObject NextQuestionButt;
    public Questions Questions; // question script
    public GameObject Endgampanman;
    #endregion

    int correntQuestionNumber = 0;
    bool[] correctAnswers = new bool[4];
    void Start()
    {
        MakeTheNextQuestion();
    }

    void MakeTheNextQuestion()
    {
        
        //sets the question text to the next question
        TMPro.TextMeshProUGUI text = question.GetComponent<TMPro.TextMeshProUGUI>();
        text.SetText(Questions.GiveMeThisQuestion(correntQuestionNumber)) ;
        //Sets the button texts to the next answers
        string[] Answers = Questions.GiveMeThisAnswers(correntQuestionNumber).Split(';');
        text = ans1.GetComponent<TMPro.TextMeshProUGUI>();
        text.SetText(Answers[0]) ;
        text = ans2.GetComponent<TMPro.TextMeshProUGUI>();
        text.SetText(Answers[1]) ;
        text = ans3.GetComponent<TMPro.TextMeshProUGUI>();
        text.SetText(Answers[2]) ;
        text = ans4.GetComponent<TMPro.TextMeshProUGUI>();
        text.SetText(Answers[3]) ;

    }

    public void Button1Pushed()
    {
        CheckIfTheButtonCorrect(1);
    }
    public void Button2Pushed()
    {
        CheckIfTheButtonCorrect(2);
    }
    public void Button3Pushed()
    {
        CheckIfTheButtonCorrect(3);
    }
    public void Button4Pushed()
    {
        CheckIfTheButtonCorrect(4);
    }
    void CheckIfTheButtonCorrect(int answer)
    {
        int correctans = Questions.GiveMeThisCorrectAnswer(correntQuestionNumber);
        correctAnswers[correntQuestionNumber] = correctans == answer;
        ColorTheButtons(correctans);
        NextQuestionButt.SetActive(true);
    }
    void ColorTheButtons(int correct)
    {
        MakeTheButtonsRed();
        MakeTheGoodButtonGreen(correct);
    }
    void MakeTheGoodButtonGreen(int correct)
    {
        switch(correct)
        {
            case 1: but1.GetComponent<Image>().color = Color.green; break;
            case 2: but2.GetComponent<Image>().color = Color.green; break;
            case 3: but3.GetComponent<Image>().color = Color.green; break;
            case 4: but4.GetComponent<Image>().color = Color.green; break;
        }
    }
    void MakeTheButtonsRed()
    {
        but1.GetComponent<Image>().color = Color.red;
        but2.GetComponent<Image>().color = Color.red;
        but3.GetComponent<Image>().color = Color.red;
        but4.GetComponent<Image>().color = Color.red;
    }
    void NextQuestion()
    {
        but1.GetComponent<Image>().color = Color.white;
        but2.GetComponent<Image>().color = Color.white;
        but3.GetComponent<Image>().color = Color.white;
        but4.GetComponent<Image>().color = Color.white;

        correntQuestionNumber++;
        MakeTheNextQuestion();
        NextQuestionButt.SetActive(false);
    }
    public void CheckIfItIsTheEnd()
    {
        if(correntQuestionNumber == 3)
        {//end of the game
            GoToEndPanel();
        }
        else
        {
            NextQuestion();
            
        }
    }
    public void GoToEndPanel()
    {
        gamePanel.SetActive(false);
        EndGamePanelMan sc = Endgampanman.GetComponent<EndGamePanelMan>();
        sc.SetTheColorButton(correctAnswers);
        AfterGamePanel.SetActive(true);
    }

}
