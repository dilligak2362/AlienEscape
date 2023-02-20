using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinZone : MonoBehaviour
{

    public GameObject winText; 

    void Start()
    {
        winText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        winText.gameObject.SetActive(true);
    }
}