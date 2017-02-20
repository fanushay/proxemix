using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntrovertScript : MonoBehaviour {

	public bool amIHappy;
	public SocialSpaceScript mySocialSpace;
	public PersonalSpaceScript myPersonalSpace;

	void Update() {
		if (mySocialSpace.amIHappy && myPersonalSpace.amIHappy) {
			amIHappy = true;
		} 
		else {
			amIHappy = false;
		}
	}
}
