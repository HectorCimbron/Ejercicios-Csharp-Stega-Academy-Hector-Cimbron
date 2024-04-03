using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AdvancedArrays : MonoBehaviour
{
    public int dim; // tupla de los vectores, común a ambos, a introducir por le usuarie
    private float[] firstVector;
    private float[] secondVector;
    public float scalar;


    // Start is called before the first frame update
    void Start()
    {
        firstVector = FillRandomVector();
        secondVector = FillRandomVector();
        //PrintVectorOp (VectorScalarProduct(firstVector, scalar));  //Producto de un vector por un escalar
        //PrintTwoVectorsScalar (TwoVectorsScalarProduct(firstVector, secondVector)); //Producto escalar de dos vectores
        //PrintVectorModule(SumVectorModule(VectorModulePow(firstVector)));  // Módulo o norma de un vector
        //PrintTwoVectorsDistance(SumVectorModule(VectorModulePow(VectorSub(firstVector, secondVector)))); // Distancia entre 2 vectores
        VectorAngleDregrees(VectorAngleRadians(ResultTwoVectorsScalar(TwoVectorsScalarProduct(firstVector, secondVector)) / ResultTwoModuleProduct (ResultVectorModule(SumVectorModule(VectorModulePow(firstVector))),
                ResultVectorModule(SumVectorModule(VectorModulePow(secondVector)))))); //Ángulo entre dos vectores

    }

    // Update is called once per frame
    void Update()
    {

    }

    float[] FillRandomVector()
    {

        float[] arrayRandomVector = new float[dim];
        for (int i = 0; i < arrayRandomVector.Length; i++)
        {
            arrayRandomVector[i] = Random.Range(0.0f, 100.0f);
            Debug.Log(arrayRandomVector[i]); // muestra por consola datos de componentes vector
        }

        return arrayRandomVector;
    }

    float[] VectorScalarProduct(float[] firstVector, float scalar)
    {
        float[] resultProduct = new float [firstVector.Length];


        for (int i = 0; i < firstVector.Length; i++)
        {
            resultProduct[i] = firstVector[i] * scalar;

        }

        return resultProduct;
    }

    float[] TwoVectorsScalarProduct(float[] firstVector, float[] secondVector)
    {

        float[] resultProduct = new float [firstVector.Length];


        for (int i = 0; i < firstVector.Length; i++)
        {
            resultProduct[i] = firstVector[i] * secondVector[i];

        }

        return resultProduct;

    }

    private void PrintVectorOp(float[] number)
    {

        string arrayString = " ";
        for (int i = 0; i < number.Length; i++)
        {
            arrayString += number[i] + " ";

        }

        Debug.Log(arrayString);
    }

    private void PrintTwoVectorsScalar(float[] number)
    {
        //el float necesita partir de 0 e ir sumando los resultados
        float resultTwoVectorsScalar = 0f;
        for (int i = 0; i < number.Length; i++)
        {
            resultTwoVectorsScalar += number[i];

        }

        Debug.Log("El resultado del producto escalar de los dos vectores es: " + resultTwoVectorsScalar);

    }

    float[] VectorModulePow(float[] firstVector) //método que eleva al cuadrado los números del vector
    {

        float[] resultModulePow = new float [firstVector.Length];
        for (int i = 0; i < firstVector.Length; i++)
        {
            resultModulePow[i] = Mathf.Pow(firstVector[i], 2f);
            Debug.Log(Mathf.Pow(firstVector[i], 2f));

        }

        return resultModulePow;

    }

    float SumVectorModule(float[] resultModulePow)
    {


        float sumModule = 0f;
        for (int i = 0; i < resultModulePow.Length; i++)
        {
            sumModule += resultModulePow[i];

        }

        Debug.Log("La suma de los componentes del vector elevados al cuadrado es " + sumModule);
        return sumModule;

    }

    private void PrintVectorModule(float sumModule)
    {
        Debug.Log("El módulo del vector es " + Mathf.Sqrt(sumModule));

    }

    float[] VectorSub(float[] firstVector, float[] secondVector)
    {
        float[] resultSub = new float [firstVector.Length];


        for (int i = 0; i < firstVector.Length; i++)
        {
            resultSub[i] = firstVector[i] - secondVector[i];


        }

        return resultSub;

    }

    private void PrintTwoVectorsDistance(float sumModule)
    {
        Debug.Log("La distancia entre los dos vectores es " + Mathf.Sqrt(sumModule));

    }

    float ResultTwoVectorsScalar(float[] resultProduct)
    {
        //el float necesita partir de 0 e ir sumando los resultados
        float resultTwoVectorsScalar = 0f;
        for (int i = 0; i < resultProduct.Length; i++)
        {
            resultTwoVectorsScalar += resultProduct[i];

        }

        Debug.Log("El resultado del producto escalar de los dos vectores es: " + resultTwoVectorsScalar);
        return resultTwoVectorsScalar;

    }

    float ResultVectorModule(float sumModule)
    {
        float resultVectorModule;
        {
            resultVectorModule = Mathf.Sqrt(sumModule);
        }
        Debug.Log("El modulo del vector es " + resultVectorModule);
        return resultVectorModule;
    }

    float ResultTwoModuleProduct (float firstVectorModule, float secondVectorModule)
    {

        float resultTwoModuleProduct;
        {
            resultTwoModuleProduct = firstVectorModule * secondVectorModule;
        }
        Debug.Log("El resultado del producto de los dos modulos es " + resultTwoModuleProduct); 
        return resultTwoModuleProduct;

    }

float VectorAngleRadians(float divisionResult)
{
    float resultRadians;
        {
            Debug.Log("El resultado de la división es " + divisionResult);
            resultRadians = Mathf.Acos(divisionResult);
            Debug.Log("el ángulo entre los dos vectores es " + Mathf.Acos(divisionResult) + " radianes");
        }
        return resultRadians;

}


private void  VectorAngleDregrees(float resultRadians)
{
    float resultDegree;
    resultDegree = resultRadians * 180 / Mathf.PI;
    Debug.Log("el ángulo entre los dos vectores es de " + resultDegree + " grados");
    
}

}
