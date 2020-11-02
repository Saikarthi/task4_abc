using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manger : MonoBehaviour
{
    public GameObject panel;
    public GameObject outpanel;
    public GameObject correct;
    public Text time;
    public Text score;
    private float point =6f;
    float timeLeft= 0f;

    void Start()
    {
       
    }



    void Update()
    {
        timeLeft -= Time.deltaTime;
        time.text = (timeLeft).ToString("0");
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            timeLeft = 60f;
            panel.SetActive(true);
            Invoke("off", 60f);
        }
    }
    public void off()
    {
       
        panel.SetActive(false);
        outpanel.SetActive(true);


    }

    public void tiger()
    {
        if (timeLeft < 60 && timeLeft > 50)
        {
            point = 6f;
        }
        else if (timeLeft < 50 && timeLeft > 40)
        {

            point = 4f;

        }
        else if (timeLeft < 40 && timeLeft > 0)
        {

            point = 2f;

        }
        score.text = point.ToString(); 
        panel.SetActive(false);
        correct.SetActive(true);


    }
}
