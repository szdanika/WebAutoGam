using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    //This script opens and closes the panels in the Menu Script
    //Later this script will manage the animations
    #region variables
    public GameObject MenuPanel;
    public GameObject LeaderBoardPanel;
    public GameObject ShopPanel;
    public GameObject ProfilPanel;
    public GameObject PlayMenu;
    public GameObject NameMenu;
    #endregion
    public AccountManager AccMan;
    void Start()
    {
        if(AccMan.GetName() != "")
        {
            CloseName();
            OpenTheMenu();
        }
    }
    public void CloseShopPanel()
    {
        ShopPanel.SetActive(false);
    }
    public void OpenShopPanel()
    {
        ShopPanel.SetActive(true);
    }
    public void CloseLeaderBoard()
    {
        LeaderBoardPanel.SetActive(false);
    }
    public void OpenLeaderBoard()
    {
        LeaderBoardPanel.SetActive(true);
    }
    public void OpenTheMenu()
    {
        MenuPanel.SetActive(true);
        //MenuPanel.GetComponent<Animator>().play;
    }
    public void CloseTheMenu()
    {
        MenuPanel.SetActive(false);
    }
    public void OpenProfil()
    {
        ProfilPanel.SetActive(true);
    }
    public void CloseProfil()
    {
        ProfilPanel.SetActive(false);
    }
    public void OpenPlay()
    {
        PlayMenu.SetActive(true);
    }
    public void ClosePlay()
    {
        PlayMenu.SetActive(false);
    }
    public void OpenName()
    {
        NameMenu.SetActive(true);
    }
    public void CloseName()
    {
        NameMenu.SetActive(false);
    }
}
