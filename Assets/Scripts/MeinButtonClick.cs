using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeinButtonClick : MonoBehaviour
{
    public GameObject textBox;
    public AudioSource CookieSound;
    public void ClickTheButtom (){
        CookieSound.Play();
        GlobalCookie.CookieCount += 1;
    }

}
