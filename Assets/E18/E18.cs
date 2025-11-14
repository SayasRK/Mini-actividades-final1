using UnityEngine;

public class E18 : MonoBehaviour
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
        //Muevo el objeto hacia arriba a la izquierda con la velocidad ajustable.
        //Y lo multiplico por deltaTime para que funcione igual en cualquier PC. 

        transform.position += new Vector3(-1f, 1f, 0f) * velocidad * Time.deltaTime;
    }
}
