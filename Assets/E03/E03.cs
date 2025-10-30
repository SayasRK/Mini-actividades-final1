using UnityEngine;

public class E03 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    //Tiempo (en segundos) que tardó en completarse el último frame.
    // Update is called once per frame
    void Update()
    {
        Debug.Log("delta time:" + Time.deltaTime);
    }
}
