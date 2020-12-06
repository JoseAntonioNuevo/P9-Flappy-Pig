using UnityEngine;
using System.Collections;

[System.Serializable] // You need this part, so that you class can be 'serialized', meaning turned into 1s and 0s. Binary baby!
public class Character {

	public string name;

	public Character () {
		this.name = "";
	}

}
