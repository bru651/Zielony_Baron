using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Opcje;
    public GameObject Zapisy;
    // Start is called before the first frame update
    void Start()
    {
        //kopcje();
        Menu.SetActive(true);
        Opcje.SetActive(false);
        Zapisy.SetActive(false);
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
    public void GRAJ()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        UnityEngine.SceneManagement.SceneManager.LoadScene("main");
    }
    public void popcje()
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
    }
    public void wyjdz()
    {
        // Quit Game
        Application.Quit();
    }
}
