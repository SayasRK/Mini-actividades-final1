using UnityEngine;

public class E51 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        if (Input.GetMouseButtonDown(1))
        {
            spriteRenderer.flipY = !spriteRenderer.flipY;
        }

        //Con este script gira el sprite horizontalmente al presionar el espacio 
        //Y verticalmente al presionar el click derecho del raton

    }
}
