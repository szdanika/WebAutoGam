using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class LeaderBoard : MonoBehaviour
{
    #region variables
    public GameObject Nam1;
    public GameObject Nam2;
    public GameObject Nam3;

    public AccountManager accMan;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        WriteOut();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void WriteOut()
    {
        string[] names = GetOrder(GetNamesFromFile());
        setName(Nam1,names[0]);
        setName(Nam2,names[1]);
        setName(Nam3,names[2]);
    }
    void setName(GameObject obj, string towhat)
    {
        obj.GetComponent<TMPro.TextMeshProUGUI>().SetText(towhat);
    }
    string[] GetOrder(string[] names)
    {
        for(int i = 0; i < names.Length; i++)
        {
            for(int x = i; x< names.Length; x++)
            {
                if(accMan.GetCoinNumberFromName(names[i]) < accMan.GetCoinNumberFromName(names[x]))
                {
                    string temp = names[i];
                    names[i] = names[x];
                    names[x] = temp;
                }
            }
        }
        return names;
    }
    
    string[] GetNamesFromFile()
    {
        return File.ReadAllText("Names.txt").Split(';');
    }
}
