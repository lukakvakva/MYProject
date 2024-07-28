using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalBaker : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int BakerValue = 10;
    public static bool turnOffButton = false;
    public GameObject bakerStats;
    public static int numberOffBakers;
    public static int bakePerSec;


    void Update()
    {
        currentCash = GlobalCash.CashCount;
        bakerStats.GetComponent<TextMeshProUGUI>().text = "Bakers:" + numberOffBakers + " @ " + bakePerSec + " Per Second";
        fakeText.GetComponent<TextMeshProUGUI>().text = "Buy Baker - $" + BakerValue;
        realText.GetComponent<TextMeshProUGUI>().text = "Buy Baker - $" + BakerValue;
        if (currentCash >= BakerValue)
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
