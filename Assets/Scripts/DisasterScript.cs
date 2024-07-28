using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class DisasterScript : MonoBehaviour
{
    public GameObject StatusBox;
    public float cookieCheck;
    public int genChance;
    public bool disasterActive = false;
    public int cookieLoss;
    void Update()
    {
        cookieCheck = GlobalCookie.CookieCount / 10;
        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }

    IEnumerator StartDisaster()
    {
    disasterActive = true;
    genChance = Random.Range(1, 20); 
        if (cookieCheck >= genChance)
        {
            cookieLoss = Mathf.RoundToInt(GlobalCookie.CookieCount * 0.25f);
            StatusBox.GetComponent<TextMeshProUGUI>().text = "You lost " + cookieLoss + "cookie in factory fier";
            GlobalCookie.CookieCount -= cookieLoss;
            yield return new WaitForSeconds(3);
            StatusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            StatusBox.SetActive(false);
            StatusBox.SetActive(true);
        } 
    yield return new WaitForSeconds(10);
    disasterActive = false;
    }
} 
