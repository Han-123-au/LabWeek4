using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i = 3;
    private int randomBlueValue;

    void Start()
    {
        randomBlueValue = Random.Range(150, 251); 
    }

    void Update()
    {
        i++;
        Debug.Log(transform.name + ":" + i);

        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.tag == "Blue" && i == randomBlueValue)
        {
            rend.enabled = false;
        }
    }
}