using UnityEngine;

public class Capas : MonoBehaviour
{
    [SerializeField] private Transform camara;
    [SerializeField] private float factor = 0.5f;

    private Vector3 startPos;
    private Vector3 camStartPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        camStartPos = camara.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (camara == null) return;

        Vector3 camDelta = camara.position - camStartPos;

        transform.position = new Vector3(
            startPos.x + camDelta.x * factor,
            startPos.y + camDelta.y * factor,
            transform.position.z
            );
    }
}
