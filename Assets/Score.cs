using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Android;

public class Score : MonoBehaviour
{
    public TextMeshPro score;
    private int scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        scoreCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        scoreCounter++;
        score.text = scoreCounter.ToString();
    }
}
