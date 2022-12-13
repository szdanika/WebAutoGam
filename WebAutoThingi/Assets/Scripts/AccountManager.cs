using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccountManager : MonoBehaviour
{
    #region variables
    public Text GivName;
    #endregion
    public SceneChanger scChan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveOrUseName()
    {//this happens when the user gives in a username
        if(GivName.text != null)
        {// if its not a blank text
            CheckIfItUsed();
        }
    }
    void CheckIfItUsed()
    {//checks if the name is used if yes then use it in corrent session
        string GivNam = GivName.text;
        if(PlayerPrefs.GetInt(GivNam) != 0)
        {//its used. Sets the corrent session
            SetCorrentProf(GivNam, PlayerPrefs.GetInt(GivName.text));
        }
        else
        {//Creates a new profile
            SetCorrentProf(GivNam, 0);
        }
    }

    void SetCorrentProf(string Name, int coins)
    {
        PlayerPrefs.SetString("correntName",Name);
        PlayerPrefs.SetInt("correntCoins",coins);
    }

    void SaveFromCorrent()
    {//Saves the coins from the corrent session
        PlayerPrefs.SetInt(GetName(),GetCoinNumber());
    }
    public string GetName()
    {
        return PlayerPrefs.GetString("correntName");
    }
    public int GetCoinNumber()
    {
        return PlayerPrefs.GetInt("correntCoins");
    }
    public void GiveCoinsToSession(int coins)
    {
        PlayerPrefs.SetInt("correntCoins",GetCoinNumber() + coins);
        SaveFromCorrent();
    }
    public void GetCoinsFromSession(int coins)
    {
        PlayerPrefs.SetInt("correntCoins",GetCoinNumber() - coins);
        SaveFromCorrent();
    }
    public void LogOut()
    {
        PlayerPrefs.SetString("correntName","");
        PlayerPrefs.SetInt("correntCoins",0);
        scChan.ToMenu();
    }

}
