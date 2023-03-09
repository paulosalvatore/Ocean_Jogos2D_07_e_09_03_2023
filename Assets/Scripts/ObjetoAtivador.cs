using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoAtivador : MonoBehaviour
{
    /*
    Esse é um comentário que não será lido pelo código

    O que vamos implementar:
    - Detectar que o objeto (o objeto ativador) está em contato com algum trigger
    - Pegar um objeto específico (qualquer outro objeto, definido na cena) e desativá-lo
    - Pegar outro objeto específico (qualquer outro objeto, definido na cena) e ativá-lo
    */

    // MODIFICADOR_ACESSO (public = Unity visualiza essa informação, private = somente interno nesse script)
    //    (essa info é opcional e é sempre private por padrão)
    // TIPO_INFORMACAO (o que define aquele dado, desde números (int, double, float) e textos (string, char)
    //    até infos mais complexas como GameObject, Transform, Collider2D, etc)
    // NOME_INFORMACAO (qualquer nome, desde que não tenha espaços e acentos)

    public GameObject objetoParaDesativar;

    public GameObject objetoParaAtivar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // print("Trigger ativado!");

        objetoParaDesativar.SetActive(false);

        objetoParaAtivar.SetActive(true);
    }
}
