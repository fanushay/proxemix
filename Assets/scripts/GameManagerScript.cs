using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManagerScript : MonoBehaviour
{
	public List<IntrovertScript> introverts = new List<IntrovertScript>();
	public List<IntrovertScript> happyIntroverts = new List<IntrovertScript>();
	public List<IntrovertScript> unhappyIntroverts = new List<IntrovertScript>();
	public GameObject youWin;


    //Personal Space and Social Space Minimum and Maximum Values
    [Header("Introverts")]
    public GameObject introvertPrefab;
    //number of Introverts
    //public int[] NumberOfIntros;
    public int numIntros;
    //introveert personal space
    public int introPersMin;
    public int introPersMax;
    //introvert social space
    public int introSocMin;
    public int introSocMax;

    [Header("Extroverts")]
    public GameObject extrovertPrefab;
    //number of Extroverts
    public int numExtros;
    //extrovert personal space
    public int extroPersMin;
    public int extroPersMax;
    //extrovert social space
    public int extroSocMin;
    public int extroSocMax;

    [Header("Friends A")]
    public GameObject friendAPrefab;
    //number of Friendss
    public int numFriendsA;
    //friends personal space
    public int friendAPersMin;
    public int friendAPersMax;
    //friends social space
    public int friendASocMin;
    public int friendASocMax;

    [Header("Friends B")]
    public GameObject friendBPrefab;
    //number of Friendss
    public int numFriendsB;
    //friends personal space
    public int friendBPersMin;
    public int friendBPersMax;
    //friends social space
    public int friendBSocMin;
    public int friendBSocMax;

    [Header("Couples")]
    public GameObject couplePrefab;
    //number of Couples
    public int numCouples;
    //couples personal space
    public int couplePersMin;
    public int couplePersMax;
    //couples social space
    public int coupleSocMin;
    public int coupleSocMax;



    

    

    
    

    //Create Coordinates For each Character
    
    


    // Use this for initialization
    /*void Start()
    {
        //for (int i = 0; i < numIntros; i++)
        //{
            
            Instantiate(introvertPrefab, new Vector2(1,1), transform.rotation);
            Instantiate(introvertPrefab, new Vector2(1, 1), transform.rotation);
            Instantiate(introvertPrefab, new Vector2(8, 1), transform.rotation);
            Instantiate(introvertPrefab, new Vector2(12, 2), transform.rotation);
            Instantiate(introvertPrefab, new Vector2(16, 1), transform.rotation);
        //}

    }*/

    // Update is called once per frame
    void Update()
    {
		happyIntroverts.Clear ();
		foreach (IntrovertScript eachIntrovert in introverts) {
			if (eachIntrovert.amIHappy == true) {
				happyIntroverts.Add (eachIntrovert);
				if (happyIntroverts.Count == introverts.Count) {
					Debug.Log ("You win");
					youWin.SetActive (true);
				}
			}
		}
      
          
       

    }
}
