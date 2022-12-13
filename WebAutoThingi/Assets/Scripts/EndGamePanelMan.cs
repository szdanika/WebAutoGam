using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EndGamePanelMan : MonoBehaviour
{
    #region variables
    public Button ans1;
    public Button ans2;
    public Button ans3;
    public Button ans4;
    #endregion
    public AccountManager accMan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetTheColorButton(bool[] goodorbad)
    {
        //int counter = 0;
        ans1.GetComponent<Image>().color = Color.red;
        ans2.GetComponent<Image>().color = Color.red;
        ans3.GetComponent<Image>().color = Color.red;
        ans4.GetComponent<Image>().color = Color.red;
        if(goodorbad[0])
            ans1.GetComponent<Image>().color = Color.green;
        if(goodorbad[1])
            ans2.GetComponent<Image>().color = Color.green;
        if(goodorbad[2])
            ans3.GetComponent<Image>().color = Color.green;
        if(goodorbad[3])
            ans4.GetComponent<Image>().color = Color.green;

        accMan.GiveCoinsToSession(1);
    }
}
