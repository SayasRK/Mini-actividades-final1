using UnityEngine;

public class E20 : MonoBehaviour
{
    [SerializeField]
    private float velocidad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            direccion.y = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direccion.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direccion.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direccion.x = 1;
        }

        //En lugar de usar transform.position usamos trnsform.Translate, es la diferencia que hay con el ej anterior. 
        transform.Translate(direccion * velocidad * Time.deltaTime);


    }
}
