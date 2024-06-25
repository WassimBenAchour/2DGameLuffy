using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Cube : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    string TheNameOfPlayer = "wassim";
    int AgeOfPlayer=25;
    float TallOfPlayer=1.74f; 
    void Start()
    {
        PrintingToOurConsol();
    }

    void Update()
    {
        OutOfBoundsPrinter();
        MovingOurCube();
    }
    public void PrintingFromOutside()
    {
        Debug.Log(" Hello From the Other side!! ");
    }

    private void MovingOurCube()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigidbody.velocity = new Vector2(0f, 10f);
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

    private void OutOfBoundsPrinter()
    {
        if (transform.position.x > 9.4f)
        {
            Debug.Log("our cube is out of bounds to the Right side!");
            Debug.Log(PositionCube(transform.position.x, "Right"));
        }
        if (transform.position.x < -9.4f)
        {
            Debug.Log("our cube is out of bounds to the Left side!");
            Debug.Log(PositionCube(transform.position.x, "Left"));
        }
        if (transform.position.y > 5.6f)
        {
            Debug.Log("our cube is out of bounds to the Top side!");
            Debug.Log(PositionCube(transform.position.y, "Top"));
        }
    }
    public string PositionCube(float X,string Pos)
    {
        return ("Your position in "+Pos+" is "+ X);
    }

    private void PrintingToOurConsol()
    {
        Debug.Log("Hello everyone the player Name is " + TheNameOfPlayer);
        Debug.LogWarning("Hello everyone the player Age is " + AgeOfPlayer);
        Debug.LogError("Hello everyone the player tall is " + TallOfPlayer);
    }
}
