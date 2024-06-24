using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Rigidbody2D rigidbody;
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
            rigidbody.velocity = new Vector2(0f, 10f)
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rigidbody.velocity = new Vector2(0f, -10f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigidbody.velocity = new Vector2(-10f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigidbody.velocity = new Vector2(10f, 0f);
        }
    }
}
