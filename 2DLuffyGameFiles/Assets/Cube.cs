using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{   
    string TheNameOfPlayer = "wassim";
    int AgeOfPlayer=25;
    float TallOfPlayer=1.74f; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello everyone the player Name is "+TheNameOfPlayer);
        Debug.LogWarning("Hello everyone the player Age is "+AgeOfPlayer);
        Debug.LogError("Hello everyone the player tall is "+TallOfPlayer);
    }

    // Update is called once per frame
 void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("UpArrow key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("DownArrow key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("LeftArrow key was pressed");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("RightArrow key was pressed");
        }
    }
}
