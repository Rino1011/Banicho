using UnityEngine;

public class kenti : MonoBehaviour
{
    public static bool Kenti;
    float time = 5f;
    bool on;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("kentisita?  = " + Kenti);
        if(on == true)
        {
            time += Time.deltaTime;
        }
        if (time <= 0)
        {
            Kenti = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Kenti = true;
        on = true;
    }
}
