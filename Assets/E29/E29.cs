using UnityEngine;

public class E29 : MonoBehaviour
{
    public GameObject cajaPrincipal;
    public float limiteIzquierdo = -8f;
    public float limiteDerecho = 8f;
    public float altura = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float posicionX = Random.Range(limiteIzquierdo, limiteDerecho);

        Vector3 posicion = new Vector3(posicionX, altura, 0);

        Instantiate(cajaPrincipal, posicion, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//el script esta puesto en un objeto vacio (spawn)
//Cuando se le da al play se crea una caja arriba en una posicion aleatoria
//y la caja al tener Rigidbody cae sola por la gravedad

