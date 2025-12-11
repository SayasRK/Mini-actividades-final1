using UnityEngine;

public class Seguidor : MonoBehaviour
{
    [SerializeField] private Transform objetivo;  
    [SerializeField] private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objetivo == null) return;

        transform.position = objetivo.position + offset;
    }
}
