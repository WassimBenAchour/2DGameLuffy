using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platfrom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<Cube>().PrintingFromOutside();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
