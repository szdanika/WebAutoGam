using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeNameAndCoin : MonoBehaviour
{
    #region menuvariables
    public GameObject MenuName;
    public GameObject MenuCoin;
    public GameObject ShopName;
    public GameObject ShopCoin;
    public GameObject PlayName;
    public GameObject PlayCoin;
    public GameObject ProfileName;
    public GameObject ProfilCoin;
    public GameObject ProfBoxName;
    public GameObject LeaderName;
    public GameObject LeaderCoin;
    #endregion
    #region gamevariables
    public GameObject QuizName;
    public GameObject QuizCoin;
    public GameObject EndName;
    public GameObject EndCoin;
    #endregion
    public AccountManager accMan;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void SetName(GameObject name)
    {
        name.GetComponent<TMPro.TextMeshProUGUI>().SetText(accMan.GetName());
    }
    void SetCoin(GameObject name)
    {
        name.GetComponent<TMPro.TextMeshProUGUI>().SetText(accMan.GetCoinNumber().ToString());
    }
    // Update is called once per frame
    void Update()
    { 
        if(accMan.GetName() != null)
        {
            if(MenuName != null)
        {//we are at the menu part
            SetName(MenuName);
            SetName(ShopName);
            SetName(PlayName);
            SetName(ProfileName);
            //SetName(ProfBoxName);
            SetName(LeaderName);

            SetCoin(MenuCoin);
            SetCoin(ShopCoin);
            SetCoin(PlayCoin);
            SetCoin(ProfilCoin);
            SetCoin(LeaderCoin);
        }
        else
        {//we are at the game part
            SetName(QuizName);
            SetName(EndName);
            SetCoin(QuizCoin);
            SetCoin(EndCoin);
        }
        }
        
    }
}
