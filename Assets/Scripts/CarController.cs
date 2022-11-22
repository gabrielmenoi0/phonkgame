using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float _velocidadeAndarFrente;
    public float _velocidadeAndarRe;
    public float _velocidadeVirar;


    // Start is called before the first frame update
    void Start () {
        _velocidadeAndarFrente = 20;
        _velocidadeAndarRe = 20;
        _velocidadeVirar = 150;
    }

    // Update is called once per frame
    void Update () {
        if(Input.GetKey ("w")){
            transform.Translate(0, 0, (_velocidadeAndarFrente * Time.deltaTime));
        }

        if(Input.GetKey ("s")){
            transform.Translate(0, 0, (-_velocidadeAndarRe * Time.deltaTime));
        }

        if(Input.GetKey ("a")){
            transform.Rotate(0,(-_velocidadeVirar * Time.deltaTime), 0);
        }

        if(Input.GetKey ("d")){
            transform.Rotate(0, (_velocidadeVirar * Time.deltaTime), 0);
        }
        
        if(Input.GetKey ("space")){
            transform.Translate(0, 0, (_velocidadeAndarFrente * 2 * Time.deltaTime));
        }

    }
}
