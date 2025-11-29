using UnityEngine;
using TMPro;

public class e43 : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f;
    [SerializeField] private TMP_Text contadorText;

    private int contador = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (contadorText != null)
        {
            contadorText.text = contador.ToString();
        }
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

        transform.position = transform.position + direccion * velocidad * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Solo cuenta y destruye si es una "moneda"

        if (other.CompareTag("Coin"))
        {
            contador = contador + 1;

            if (contadorText != null)
            {
                contadorText.text = contador.ToString();
            }

            Destroy(other.gameObject);
        }
    }
}
