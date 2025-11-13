using UnityEngine;

public class E05 : MonoBehaviour
{

    [SerializeField]
    private float numeroA;

    [SerializeField]
    private float numeroB;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float resultado = numeroA + numeroB;
        Debug.Log("Suma: " + resultado);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
