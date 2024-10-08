using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Subject
{
    public BoxCollider2D boxCollider;
    ScoreManager scoreManager;
    public GameObject bulletPrefab;
    public Observer Observer1;
    public Observer Observer2;
    public Observer Observer3;
    public Observer Observer4;
    
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        
        
        
        Attach(Observer1);
        Attach(Observer2);
        Attach(Observer3);
        Attach(Observer4);
        
    }

    public float currentHealth
    {
        get { return currentHealth; }
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            NotifyObservers();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            NotifyObservers();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            NotifyObservers();
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        NotifyObservers();
    }
}
