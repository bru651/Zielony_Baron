using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class gamemenu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject HUD;
    public GameObject buildmenu;
    public GameObject buildciv;
    public GameObject buildind;
    public GameObject buildserv;
    public TMP_Dropdown buildselect;
    // Start is called before the first frame update
    void Start()
    {
        //kopcje();
        Menu.SetActive(false);
        HUD.SetActive(true);
        buildmenu.SetActive(false);
        buildciv.SetActive(false);
        buildind.SetActive(false);
        buildserv.SetActive(false);
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
    public void GRAJ()
    {
        // Play Now Button 
        Menu.SetActive(false);
        HUD.SetActive(true);
        //buildmenu.SetActive
    }
    public void menubutton()
    {
        // Show Menu
        Menu.SetActive(true);
        HUD.SetActive(false);
    }
    public void buildbutton()
    {
        // Show buildMenu
        if(buildmenu.activeSelf)
        {
            buildmenu.SetActive(false);
        }
        else
        {
            buildmenu.SetActive(true);
        }
    }
    public void opcjebudowy()
    {
        // wybiera zakładkę budynków
        int val=buildselect.value;
        if(val==0)
        {
            buildciv.SetActive(true);
            buildind.SetActive(false);
            buildserv.SetActive(false);
        }
        if(val==1)
        {
            buildciv.SetActive(false);
            buildind.SetActive(true);
            buildserv.SetActive(false);
        }
        if(val==2)
        {
            buildciv.SetActive(false);
            buildind.SetActive(false);
            buildserv.SetActive(true);
        }
    }
    /*public void kzapisy()
    {
        // Show Menu
        Menu.SetActive(true);
        Zapisy.SetActive(false);
    }*/
    public void wyjdzdm()
    {
        // Quit Game
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
}
