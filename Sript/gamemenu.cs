using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemenu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject HUD;
    // Start is called before the first frame update
    void Start()
    {
        //kopcje();
        Menu.SetActive(true);
        HUD.SetActive(true);
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
    public void GRAJ()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        Menu.SetActive(false);
    }
    /*public void popcje()
    {
        // Show Credits Menu
        Menu.SetActive(false);
        Opcje.SetActive(true);
    }
    public void kopcje()
    {
        // Show Menu
        Menu.SetActive(true);
        Opcje.SetActive(false);
    }
    public void pzapisy()
    {
        // Show Credits Menu
        Menu.SetActive(false);
        Zapisy.SetActive(true);
    }
    public void kzapisy()
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
