using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer re;

    public GameObject tr;

    // Start is called before the first frame update
    void Start()
    {
        re = GetComponent<SpriteRenderer>();
        ColorC();
    }

    // Metodo para cambiar color
    public void ColorC()
    {
        re.color = Color.blue;
        transform.position = tr.transform.position;
    }
}
