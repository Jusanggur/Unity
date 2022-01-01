using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{
    public float velocidade = 3.0f;
    public float gravidade = 9.8f;
    private CharacterController meuControle;

    // Start is called before the first frame update
    void Start()
    {
        meuControle = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimento em Z

        Vector3 movimentoZ = Input.GetAxis("Vertical") * Vector3.forward * velocidade * Time.deltaTime;

        //Movimento em X

        Vector3 MovimentoX = Input.GetAxis("Horizontal") * Vector3.right * velocidade * Time.deltaTime;

        //Movimento

        Vector3 movimento = transform.TransformDirection(movimentoZ + MovimentoX);

        //Movimento em Y

        movimento.y -= gravidade * Time.deltaTime;

        //Controle

        meuControle.Move(movimento);
    }
}
