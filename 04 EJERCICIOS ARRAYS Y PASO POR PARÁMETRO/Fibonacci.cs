using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fibonacci : MonoBehaviour
{
    //Mismo script de Vayo

    public int position;
    // Start is called before the first frame update
    void Start()
    {
        PosError();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PosError()
    {

        if (FibonacciSeq(position) == -1)
        {
            Debug.Log("Introduce un número positivo");
        }
        else
        {
            Debug.Log("La posición " + position  + " en la sucesión de Fibonacci corresponde a: " + FibonacciSeq(position));
        }
    }
    private int FibonacciSeq(int pos)
    {
        int num1 = 0,
            num2 = 1,
            sum = 0;

        if (pos > 0)
        {
            for (int i = 1; i < pos; i++)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
            }

            return sum;

        }

        return -1;

    }
}
