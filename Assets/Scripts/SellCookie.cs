using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SellCookie : MonoBehaviour
{
    public TextMeshProUGUI textBox;
    public GameObject statusBox;
    public AudioSource cashOne;
    public AudioSource cashTow;
    public int generateTone;
    public AudioSource noCookie;

    public void ClickTheButton()
    {
        generateTone = Random.Range (1, 3);
        if (GlobalCookie.CookieCount == 0)
        {
            noCookie.Play();
            statusBox.GetComponent<TextMeshProUGUI>().text = "Not enough cookies to sell.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            if (generateTone ==  1)
            {
                cashOne.Play();
            }
            if (generateTone == 2)
            {
                cashTow.Play();
            }
            GlobalCookie.CookieCount -= 1;
            GlobalCash.CashCount += 1;
        }
    }
}
