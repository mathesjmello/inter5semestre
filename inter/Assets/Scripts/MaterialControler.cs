using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Substance.Game;


public class MaterialControler : MonoBehaviour
{
	
	public SubstanceGraph WaterSubstance;
	private float _value=0;
	private bool _right;
	public float Velocity;

	
	private void Update()
	{
		if (!_right)
		{
			_value += Time.deltaTime/Velocity;
			if (_value>1)
			{
				_right = true;
			}
		}
		else
		{
			_value -= Time.deltaTime/Velocity;
			if (_value<0)
			{
				_right = false;
			}
		}
		WaterSubstance.SetInputFloat("disorder", _value);
		WaterSubstance.QueueForRender();
	}

}
