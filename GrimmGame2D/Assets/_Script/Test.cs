using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int a;
    public int b;
    private int _result;

    // Start is called before the first frame update
    void Start()
    {
        Suma();
    }
    // Metodo de suma
    public void Suma()
    {
        _result = a + b;
        Debug.Log(string.Format("El resultado es: {0}", _result));
    }

}
