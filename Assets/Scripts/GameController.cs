using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject GameController_go;
    public int StrawberryCount = 0;

    void Awake()
    {
        DontDestroyOnLoad(GameController_go);
    }
}
