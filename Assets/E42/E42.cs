using UnityEngine;

public class E42 : MonoBehaviour
{ 
[SerializeField] private float velocidad = 5f;

private int counter = 0;


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

        transform.position = transform.position + direccion * velocidad * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)

    {
        counter = counter + 1;

        Debug.Log("Has entrado " + counter + " veces en el objeto.");
    }
    //Cada vez que entro a cualquier trigger sumo uno 

}
