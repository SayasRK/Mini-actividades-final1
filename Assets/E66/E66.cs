using UnityEngine;
using UnityEngine.SceneManagement;

public class E66 : MonoBehaviour
{
    private float timer = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("E66_rojo");
        }

        if (timer >= 10f)
        {
            SceneManager.LoadScene("E66_verde");
        }
    }

    public void LoadBlue()
    {
        SceneManager.LoadScene("E66_azul");
    }
}
