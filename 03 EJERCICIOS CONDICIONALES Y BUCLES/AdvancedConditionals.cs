using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedConditionals : MonoBehaviour
{
    public float firstNumber;
    public float secondNumber;
    public float thirdNumber;

    float lowestNumber;
    float middleNumber;
    float highestNumber;


    // Start is called before the first frame update
    void Start()
    {
        NumberHierarchy();
        LowestToHighestNumber();
        HighestToLowestNumber();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void NumberHierarchy()
    {
        

        if (firstNumber < secondNumber && firstNumber < thirdNumber) lowestNumber = firstNumber;
        else if (firstNumber > secondNumber && firstNumber > thirdNumber) highestNumber = firstNumber;
        else middleNumber = firstNumber;
      

        if (secondNumber < firstNumber && secondNumber < thirdNumber) lowestNumber = secondNumber;
        else if (secondNumber > firstNumber && secondNumber > thirdNumber) highestNumber = secondNumber;
        else middleNumber = secondNumber;

        if (thirdNumber < firstNumber && thirdNumber < secondNumber) lowestNumber = thirdNumber;
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber) highestNumber = thirdNumber;
        else middleNumber = thirdNumber;

    }

    private void LowestToHighestNumber()
    {
        Debug.Log(lowestNumber);
        Debug.Log(middleNumber);
        Debug.Log(highestNumber);

    }
    private void HighestToLowestNumber()
    {
        Debug.Log(highestNumber);
        Debug.Log(middleNumber);
        Debug.Log(lowestNumber);

    }
}
