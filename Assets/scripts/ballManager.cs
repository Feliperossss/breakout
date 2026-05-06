using System;
using System.Collections.Generic;
using NUnit.Framework;
using Unity.Mathematics;
using UnityEngine;

public class ballManager : MonoBehaviour
{

     #region  Singleton
    private static  ballManager _instance;

    public static ballManager instance => _instance;

    private void Awake()
    {
        if(_instance != null)
        {
            Destroy(gameObject); 
        }
        else
        {
            _instance = this;
        }
    }
    #endregion


    [SerializeField]
    private  ballScript ballPrefab;
    private ballScript initialBall;

    private Rigidbody2D initialBallRB;

   public List<ballScript> balls{get; set;}

    public void Start()
    {
        initBall();
    }

    private void initBall()
    {
        Vector3 paddle = PlayerScript.instance.gameObject.transform.position;
        Vector3 startPosition = new Vector3(paddle.x,paddle.y+ 5f, -2);
        initialBall = Instantiate(ballPrefab, startPosition, quaternion.identity);
        initialBallRB = initialBall.GetComponent<Rigidbody2D>(); 

        this.balls = new List<ballScript>
        {
          initialBall  
        };
    }
}
