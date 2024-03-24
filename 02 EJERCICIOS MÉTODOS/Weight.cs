using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Weight : MonoBehaviour
{
   
    public float grams;
    
    
    void Start()
    {
        GetPounds();
        GetOunce();
        GetKilograms();
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    private void GetPounds()
    {

        float resultP;
        //La masa m en libras (lb) es igual a la masa m en gramos (g) dividida por 453.59237
        //m (libras) = m (g) / 453.59237
        resultP = grams / 453.59237f; 
        Debug.Log(grams + " gramos equivalen a " + resultP + " libras.");
    }

    private void GetOunce()
    {

        float resultO;
        //La masa m en onzas (oz) es igual a la masa m en gramos (g) dividida por 28,34952:
        //m(oz) = m(g) / 28,34952
        resultO = grams / 28.34952f;
        Debug.Log(grams + " gramos equivalen a " + resultO + " onzas.");
    }

    private void GetKilograms()
    {

        float resultK;
        //La masa m en kilogramos (kg) es igual a la masa m en gramos (g) dividida por 1000:
        //m(kg) = m(g) / 1000
        resultK = grams / 1000f;
        Debug.Log(grams + " gramos equivalen a " + resultK + " kilogramos.");
    }


}
