using UnityEngine;

public class E25 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);

        //GetComponent<Rigidbody2D>() = Accede al componente fisico 
        //Add fordce = Aplica la fuerza al Rigidbody
        //Vector2.up * 10 = Es la direccion y la fuerza de impulso (yo le he asignado 10 como ejemplo y para que se vea en pantalla) 
        //ForceMode2D.Impulse = Hace que la fuerza se aplique al momento, para que al darle al play se umpuje hacia arriba
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
