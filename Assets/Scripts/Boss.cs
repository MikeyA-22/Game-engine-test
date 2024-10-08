using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Observer
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public override void Notify(Subject subject)
    {
        transform.Translate(player.transform.right * Time.deltaTime * 10);
    }
}
