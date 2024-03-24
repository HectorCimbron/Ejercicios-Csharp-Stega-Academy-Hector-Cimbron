using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{

    public float farenheit;
    public float celsius;
    

    // Start is called before the first frame update
    void Start()
    {

        CelsiusToFarenheit();
        FarenheitToCelsius();

    }

    // Update is called once per frame
    void Update()
    {

}
    private void CelsiusToFarenheit()
    {
        float resultF;
        resultF = 1.8f * celsius + 32;
        Debug.Log(celsius + " grados Celsius equivalen a " + resultF + " grados Farenheit");

    }
    private void FarenheitToCelsius()
    {
        float resultC;
        resultC = (farenheit - 32) / 1.8f;
        Debug.Log(farenheit + " grados Farenheit equivalen a " + resultC + " grados Celsius");
    }
}
