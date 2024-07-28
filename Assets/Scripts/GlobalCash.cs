using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GlobalCash : MonoBehaviour
{
    public static int CashCount;
    public TextMeshProUGUI CashDisplay;
    public int InternalCash;

    void Update()
    {
        InternalCash = CashCount;
        CashDisplay.text = "$: " + InternalCash;
    }
}
