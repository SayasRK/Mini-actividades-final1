using UnityEngine;

public class E55 : MonoBehaviour
{
    private Animator animator;
    private bool running = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
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
            running = !running;
            animator.SetBool("running", running);
        }
    }
}
