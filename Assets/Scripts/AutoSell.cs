using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    static bool SellingCookie = false;
    public static int CashIncrease = 1;
    public int InternalIncrease;


    // Update is called once per frame
    void Update()
    {
        CashIncrease = GlobalShop.shopPerSec;
        InternalIncrease = CashIncrease;
        if (SellingCookie == false)
        {
            SellingCookie = true;
            StartCoroutine(SellTheCookie());
        }
    }
    IEnumerator SellTheCookie ()
    {
        if (GlobalCookie.CookieCount == 0)
        {
            // cent do nathing
        }
        else
        {
        GlobalCash.CashCount += InternalIncrease;
        GlobalCookie.CookieCount -= 1;
        yield return new WaitForSeconds(1);
        SellingCookie = false;
        }

    }
}
