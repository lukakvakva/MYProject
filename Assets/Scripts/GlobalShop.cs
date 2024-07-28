using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalShop : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int shopValue = 10;
    public static bool turnOffButton = false;
    public GameObject shopStats;
    public static int numberOffshop;
    public static int shopPerSec;


    void Update()
    {
        currentCash = GlobalCash.CashCount;
        shopStats.GetComponent<TextMeshProUGUI>().text = "shop:" + numberOffshop + " @ " + shopPerSec + " Per Second";
        fakeText.GetComponent<TextMeshProUGUI>().text = "Buy shop - $" + shopValue;
        realText.GetComponent<TextMeshProUGUI>().text = "Buy shop - $" + shopValue;
        if (currentCash >= shopValue)
        
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        else
        {
        turnOffButton = true;
        }
        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
