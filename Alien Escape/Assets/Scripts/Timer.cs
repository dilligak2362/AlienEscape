using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Stars")]
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    public float ThreeStars;
    public float TwoStars;
    public float OneStar;

    [Header("Component")]
    public TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public float currentTime;
    public bool countDown;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        timerText.text = currentTime.ToString();

     

        if(currentTime >= TwoStars)
        {
            Star3.SetActive(false);
        }

        if (currentTime >= OneStar)
        {

            Star2.SetActive(false);
            Star3.SetActive(false);
        }
    }
}
