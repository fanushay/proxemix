using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialSpaceScript : MonoBehaviour
{

    //SpriteRenderer socSprite = GetComponent<SpriteRenderer>();
    public Color unComfyColor = new Color();
    public Color comfyColor = new Color();

    private int numBreach = 0;


    void ChangeColor(Color newColor)
    {
        SpriteRenderer socRender = GetComponent<SpriteRenderer>();
        socRender.color = newColor;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        numBreach++;
        Debug.Log(numBreach);


        if (numBreach > 1)
        {

            Debug.Log("Too Many In Social Space!");
            ChangeColor(unComfyColor);
        }
    }


    void OnTriggerExit2D(Collider2D collision)
    {
        numBreach--;
        Debug.Log(numBreach);

        if (numBreach > 1)
        {

            Debug.Log("Too Many In Social Space!");
            ChangeColor(unComfyColor);
        }
    }

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
}
