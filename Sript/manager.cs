using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class manager : MonoBehaviour
{
    public int wood;
    public int food;
    public int pops;
    public int popcap;
    public int health;
    public int happy;
    public int security;
    public TMP_Text woodDisplay;
    public TMP_Text foodDisplay;
    public TMP_Text popsDisplay;
    public TMP_Text popcapDisplay;
    public TMP_Text healthDisplay;
    public TMP_Text happyDisplay;
    public TMP_Text securityDisplay;
    private float clock;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        woodDisplay.text = wood.ToString();
        foodDisplay.text = food.ToString();
        popsDisplay.text = pops.ToString();
        popcapDisplay.text = popcap.ToString();
        healthDisplay.text = health.ToString();
        happyDisplay.text = happy.ToString();
        securityDisplay.text = security.ToString();
        clock=clock+Time.deltaTime;
        if(clock>15)
        {
            day();
            clock=0;
        }
        
    }
    public void consume()
    {
        food=food-pops;
        if(food<0)
        {
            pops=pops+food;
            food=0;
            if(pops<0)
            {
                pops=0;
            }
        }
    }
    public void day()
    {
        consume();
    }
}
