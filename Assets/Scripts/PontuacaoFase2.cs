using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PontuacaoFase2 : MonoBehaviour
{
    public int pontos;
    public TextMeshProUGUI textMeshPro;
    public bool jaChameiEsseMetodo;

    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
        MudarTextoScore();
    }

    void Update()
    {
        if(pontos == 15)
        {
            LoadNextScene();
        }
    }

    void MudarTextoScore()
    {
        textMeshPro.text = pontos.ToString();
    }

   void OnTriggerEnter(Collider objetoDeColisao)
    {
        if(objetoDeColisao.gameObject.tag == "addPontos")
        {
            pontos = pontos + 1;
            MudarTextoScore();
            Destroy(objetoDeColisao.gameObject);
        }
    }

    private void LoadNextScene(){
        if (jaChameiEsseMetodo) return;
        jaChameiEsseMetodo = true;
        SceneManager.LoadScene(3);
    }
}
