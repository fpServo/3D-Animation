using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterimScript : MonoBehaviour
{
    Animator animatorum;
    void Start()
    {
        animatorum = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //LAN YURU
        if (Input.GetKeyDown(KeyCode.W))
        {
            animatorum.SetBool("yurusun_mu", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            animatorum.SetBool("yurusun_mu", false);
        }
        
        //LAN KOS
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animatorum.SetBool("normalkossun_mu", true);
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            animatorum.SetBool("normalkossun_mu", false);
        }

        //LAN HIZLI KOS
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animatorum.SetBool("hizlikossun_mu", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animatorum.SetBool("hizlikossun_mu", false);
        }


        //LAN ZIPLA
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animatorum.SetBool("ziplasin_mi", true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            animatorum.SetBool("ziplasin_mi", false);
        }

    }
}
