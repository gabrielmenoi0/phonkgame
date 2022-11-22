using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWheelBack : MonoBehaviour
{

    public float _velocidadeRotacao;

    // Start is called before the first frame update
    void Start()
    {
        _velocidadeRotacao = 500;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey ("w")){
            transform.Rotate((_velocidadeRotacao * Time.deltaTime), 0, 0);
            
        }

        if(Input.GetKey ("s")){
            transform.Rotate((-_velocidadeRotacao * Time.deltaTime), 0, 0);
            
        }
    }
}
