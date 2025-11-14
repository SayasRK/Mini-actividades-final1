using UnityEngine;

public class E16 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Esto hace que el objeto se mueva en diagonal hacia abajo a la derecha cada frame.

        transform.position += new Vector3(1f, -1f, 0f) * Time.deltaTime;

    }
}
