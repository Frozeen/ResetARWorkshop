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
        //Si el resultado es menor a cero se corrige
        if (actualPosition < 0)
        {
            actualPosition = 0;
        }
        //Si el resultado es menor al contenido del arreglo se corrige
        else if (actualPosition > housePositions.Length - 1)
        {
            actualPosition = housePositions.Length - 1;
        }
        //Si esta dentro del rango se manda actualizarel transform
        else
        {
            //Se actualiza la posicion del cuarto
            hauntedHouse.transform.localPosition = new Vector3(housePositions[actualPosition].x, housePositions[actualPosition].y, housePositions[actualPosition].z);
            //Se actualiza la rotacion del cuarto
            hauntedHouse.transform.localEulerAngles = new Vector3(houseRotations[actualPosition].x, houseRotations[actualPosition].y, houseRotations[actualPosition].z);
        } //Fin de if- else if - else
    } //Fin de ChangeTransform()
} //Fin de ChangeTransform