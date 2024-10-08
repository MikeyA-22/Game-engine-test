using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : Observer
{
    public BoxCollider2D boxCollider;
    ScoreManager scoreManager;
    
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        scoreManager.Score += 10;
    }

    public override void Notify(Subject subject)
    {
        throw new NotImplementedException();
    }
}
