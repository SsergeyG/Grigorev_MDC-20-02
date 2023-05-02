using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour
{
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonClick()
    {
        Cube.GetComponent<Renderer>().material.color = Color.blue;

    }
}
