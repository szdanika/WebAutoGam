using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Questions : MonoBehaviour
{

    private string[] pictureNames = new string[5]{"test1","test2","test3","test4","test5"};
    private int[] CorrectAnswer = new int[5]{1,1,1,1,1};
    //possible answers with ; (Need to split it )
    private string[] possibleAnswers = new string[5]{"1;2;3;4","1;2;3;4","1;2;3;4","1;2;3;4","1;2;3;4"};
    private string[] questionString = new string[5]{"First","First1","First2","First3","First4"};
    
    public string GiveMeThisQuestion(int question)
    {
        return questionString[question];
    }
    public string GiveMeThisPicture(int question)
    {
        return pictureNames[question];
    }
    public string GiveMeThisAnswers(int question)
    {
        return possibleAnswers[question];
    }
    public int GiveMeThisCorrectAnswer(int question)
    {
        return CorrectAnswer[question];
    }
}