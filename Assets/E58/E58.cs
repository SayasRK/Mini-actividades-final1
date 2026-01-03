using UnityEngine;

public class E58 : MonoBehaviour
{
    [SerializeField] private float gravedad = 9.81f;

    private bool gravedadInvertida = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Physics2D.gravity = new Vector2(0f, -gravedad);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravedadInvertida = !gravedadInvertida;

            float signo = gravedadInvertida ? 1f : -1f;
            Physics2D.gravity = new Vector2(0f, signo * gravedad);
        }
    }
}

//el script esta puesto en "controlador de gravedad" lo que hace es afectar a todos los objetos que tienen riginbody
