using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtrovertScript : MonoBehaviour {

	public bool amIHappy;
	public SocialSpaceScript_Extrovert mySocialSpace;
	public PersonalSpaceScript_Extrovert myPersonalSpace;

	void Update() {
		if (mySocialSpace.amIHappy && myPersonalSpace.amIHappy) {
			amIHappy = true;
		} 
		else {
			amIHappy = false;
		}
	}
}
