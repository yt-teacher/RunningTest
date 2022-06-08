using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private MapContoller mapContoller;

    [SerializeField]
    private PlayerContoller playerContoller;

    // Start is called before the first frame update
    void Start()
    {
        mapContoller.Init();
        playerContoller.Init();
    }

    // Update is called once per frame
    void Update()
    {
        mapContoller.OnUpdate();
        playerContoller.OnUpdate();
    }
}
