using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GlobalCookie : MonoBehaviour
{
    public static int CookieCount;
    public TextMeshProUGUI CookieDisplay;
    public int InternalCookie;

    void Update()
    {
        InternalCookie = CookieCount;
        CookieDisplay.text = "Cookie: " + InternalCookie;
    }
}
