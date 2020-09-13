using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
	public void exitgame()
	{
		Debug.Log("You are out of the game");
		Application.Quit();
	}
}
