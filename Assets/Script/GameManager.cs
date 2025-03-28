using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    // Start is called before the first frame update

    public CarControler carControler;
    public Ground ground;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        carControler = FindFirstObjectByType<CarControler>();
        ground = FindFirstObjectByType<Ground>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
