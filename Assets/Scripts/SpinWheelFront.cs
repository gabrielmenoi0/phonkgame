using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinWheelFront : MonoBehaviour
{

    public float _velocidadeVirar;
    public float _velocidadeVirarLateral;

    // Start is called before the first frame update
    void Start()
    {
        _velocidadeVirar = 250;
        _velocidadeVirarLateral = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey ("w")){
            transform.Rotate((_velocidadeVirar * Time.deltaTime), 0, 0, Space.Self);
            
        }

        if(Input.GetKey ("s")){
            transform.Rotate((-_velocidadeVirar * Time.deltaTime), 0, 0, Space.Self);
            
        }
        if(Input.GetKey ("a")){          
            if(transform.localRotation.eulerAngles.y >= 325 || transform.localRotation.eulerAngles.y <= 36){
                transform.Rotate(0, (-_velocidadeVirarLateral * Time.deltaTime),0, Space.Self);
            }
        }

        if(Input.GetKey ("d")){
            if(transform.localRotation.eulerAngles.y >= 324 || transform.localRotation.eulerAngles.y <= 35){
                transform.Rotate(0, (_velocidadeVirarLateral * Time.deltaTime), 0, Space.Self);
            }
        }
    }
}
