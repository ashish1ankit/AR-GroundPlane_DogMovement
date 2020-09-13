using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogcontroller : MonoBehaviour
{
    static Animator anim;
    public float speed=10.0f;
    public int x=0;
    //float waitTime = 4;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)||x>0)
        {
            Debug.Log(x);
            float translation=speed;
                translation *=Time.deltaTime;
                transform.Translate(translation,0,0);
                anim.SetBool("isWalk",true);
                x++;
                
                //Debug.Log(x);
                if(x==100){
                    anim.SetBool("isWalk",false);
                    speed=0.0f;
                    x=0;
                    anim.SetBool("stopwalk",true);
                 
                }
            }
    }
}