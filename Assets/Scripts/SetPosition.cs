using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{
    public Vector3[] housePositions;
    public Vector3[] houseRotations;
    public GameObject hauntedHouse;
    private int actualPosition = 0;

    /// <summary>
    /// Se encarga de modificar el transform de la casa embrujada en base al contenido de housePositions y houseRotations
    /// </summary>
    /// <param name="increment"></param>
    public void ChangeTransform(int increment)
    {
        //Se aumenta el valor de actualPosition en base al incremento
        actualPosition += increment;
    } //Fin de ChangeTransform()
} //Fin de ChangeTransform