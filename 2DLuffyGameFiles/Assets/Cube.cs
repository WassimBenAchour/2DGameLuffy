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
        
    }
}
