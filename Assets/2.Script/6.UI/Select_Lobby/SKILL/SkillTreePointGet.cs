using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTreePointGet : MonoBehaviour {
    Text PointCount;
    // Use this for initialization
    int Pcount;

	public void SpointSet () {
        Pcount = Player.NewPlayer.PlayerSkillUpPoint;

        PointCount = GetComponent<Text>();

        PointCount.text = Pcount.ToString();
	}
	
}
