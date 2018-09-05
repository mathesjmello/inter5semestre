using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Substance.Game;


public class MaterialControler : MonoBehaviour
{

	public SubstanceGraph WaterSubstance;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnSliderChange(float value)
	{
		WaterSubstance.SetInputFloat("random",value);
	}
}
