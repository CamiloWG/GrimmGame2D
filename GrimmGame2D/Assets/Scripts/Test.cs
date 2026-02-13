using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int a, b, c, d; 
    public double catetoA, catetoB;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(string.Format("La posición del objeto es: {0}", transform.position));

        //Debug.Log(string.Format("La hipotenusa de los catetos A ({0}) y B ({1}) es = {2}", catetoA, catetoB, Hipotenusa(catetoA, catetoB)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private int Multiplicacion(int a, int b)
    {
        return a * b;
    }

    private float Formula(int a, int b, int c, int d)
    {
        return ((a + b) * (b - c)) / d;
    }

    private double Hipotenusa(double a, double b)
    {
        return Math.Sqrt((Math.Pow(a, 2)) + (Math.Pow(b, 2)));
    }


}
