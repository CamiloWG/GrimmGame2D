using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Actividad_1 : MonoBehaviour
{
    public double a;
    public double b;
    private double _result;

    public GameObject square;
    private float positionX;
    private float positionY;

    // Start is called before the first frame update
    void Start()
    {
        Hipotenusa();
        Getposition();
    }

    public void Hipotenusa()
    {
        _result = Math.Sqrt((Math.Pow(a, 2)) + (Math.Pow(b, 2)));
        Debug.Log(string.Format("La hipotenusa de un traingulo de catetos {0} y {1} es: {2}", a, b, _result));
    }
    public void Getposition()
    {
        positionX = square.transform.position.x;
        positionY = square.transform.position.y;
        Debug.Log(string.Format("La posición del cuadrado es en el eje x: {0} y en en el eje y: {1}", positionX, positionY));

    }
}
