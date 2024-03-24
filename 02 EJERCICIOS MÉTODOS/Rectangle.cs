using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Rectangle : MonoBehaviour
{
   
    public float alto;
    public float ancho;
    // Start is called before the first frame update
    void Start()
    {
        GetArea();
        GetPerimeter();
        GetDiagonal();
        
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void GetArea()
    {
        //�rea = base * altura
        float resultA;
        resultA = ancho * alto;
        Debug.Log("el �rea de un rect�ngulo de base " + ancho + " y altura " + alto + "es" + resultA);
}

    private void GetPerimeter()
    {
        // Per�metro = 2 * (base + altura)
        float resultP;
        resultP = 2 * (ancho + alto);
        Debug.Log("el Per�metro de un rect�ngulo de base " + ancho + " y altura " + alto + "es" + resultP);
    }

    private void GetDiagonal()
    {
        // Diagonal = Ra�z cuadrada de (base� + altura�)
        float resultD;
        resultD = MathF.Sqrt (Mathf.Pow(ancho, 2f) + Mathf.Pow(alto, 2f));
        Debug.Log ("la Diagonal de un rect�ngulo de base " + ancho + " y altura " + alto + "es" + resultD);
    }

}

