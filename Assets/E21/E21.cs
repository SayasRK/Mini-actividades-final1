using UnityEngine;

public class E21 : MonoBehaviour
{
    public GameObject objetivo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Para que el objeto copie la posicion del otro objeto cada frame

        transform.position = objetivo.transform.position;
    }
}
