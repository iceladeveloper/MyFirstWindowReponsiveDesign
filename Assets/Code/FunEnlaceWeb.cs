using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunEnlaceWeb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnlacesdeBoton(string enlace)
    {
        Application.OpenURL(enlace);
    }
}
