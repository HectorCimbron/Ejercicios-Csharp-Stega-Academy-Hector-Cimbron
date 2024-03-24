using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilinder : MonoBehaviour
{

    public float radius;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        GetArea();
        GetVolume();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GetArea()
    {
        // Área = 2 * π * Radio * (radio + Altura) 
        float resultA;
        resultA = 2.0f * Mathf.PI * radius * (radius + height);
        Debug.Log("el Área de un cilindro de radio " + radius + " y altura " + height + "es " + resultA);
    }
    private void GetVolume()
    {
        // Volumen = π * Radio² * Altura 
        float resultV;
        resultV =  Mathf.PI * Mathf.Pow (radius, 2f) * height;
        Debug.Log("el Volumen de un cilindro de radio " + radius + " y altura " + height + "es " + resultV);
    }
}
