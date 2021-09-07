using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verificador : MonoBehaviour
{

    RandColorCS rd;
    // Start is called before the first frame update
    private void Awake()
    {
        // Dentro da awake eu estou primeiramente usando o método FindGameObjectWithTag, que procura dentro da sua cena um objeto com uma determinada tag
        // por exemplo, o meu objeto pontuador tem a Tag PointScript
        // Após isso, eu estou pegando o componente PointsScript dele, que é exatamente o script pontuador
        rd = GameObject.FindGameObjectWithTag("Player").GetComponent<RandColorCS>();
    }
    void Start()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        rd.taNoChao();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
