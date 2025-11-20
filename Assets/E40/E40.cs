using UnityEngine;
using TMPro;

public class E40 : MonoBehaviour
{
    private int counter = 0;

    [SerializeField] private TMP_Text counterText;

    public void AddPoints()
    {
        counter = counter + 1;
        counterText.text = counter.ToString();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
