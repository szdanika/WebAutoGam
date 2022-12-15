using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Questions : MonoBehaviour
{

    private string[] pictureNames = new string[5]{"test1","test2","test3","test4","test5"};
    private int[] CorrectAnswer = new int[5]{2,2,1,2,2};
    //possible answers with ; (Need to split it )
    private string[] possibleAnswers = new string[5]{"Brake-Clutch-gas;Clutch-brake-gas;Gas-Clutch-Brake;Brake-Gas-Clutch","Both;Only right;Only left;I dont use feet","Yes;No;Maybe;some times","You always have to use lights;In less populated ares you can also drive with day lights;In less populated ares you can use fog lights;Its your car you can use it how you want it","1;2;3;4"};
    private string[] questionString = new string[5]{"The car with a manual gearbox has three pedals. What is their order from left to right?","Which foot do you use on the brake pedal","Can you apply brakes even if the clutch isn't depressed?","There'ss a light switch in the car. What do you know about the rules of using lights?","1.Good"};
    
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
