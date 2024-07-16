using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAdministorator : MonoBehaviour
{
    public static GameAdministorator instance;
    public float gametime;
    public float maxGameTime = 2 * 10f;
    public PoolManager pool;
    public PlayerMovement player;

    void Awake(){
        instance = this;
    }

    void Update()
    {
        gametime += Time.deltaTime;

        if(gametime > maxGameTime){
            gametime = maxGameTime;
        }
    }
}
