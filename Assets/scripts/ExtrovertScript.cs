using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtrovertScript : MonoBehaviour {

	public bool amIHappy;
	public ExtrovertSocialSpace mySocialSpace;
	public ExtrovertPersonalSpace myPersonalSpace;

	void Update() {
		if (mySocialSpace.amIHappy && myPersonalSpace.amIHappy) {
			amIHappy = true;
		} 
		else {
			amIHappy = false;
		}
	}
}