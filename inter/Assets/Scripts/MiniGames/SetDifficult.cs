using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class SetDifficult : MonoBehaviour
{
	public Image BackGround;
	public List<Sprite> PlayableBackground;
	private Sprite _choosedSprite;
	public List<Sprite> EasyGame;
	public List<Sprite> MedioGame;
	public List<Sprite> HardGame;
	// Use this for initialization
	void Start () {
		if (PlayableBackground==null)
		{
			var i = Random.Range(0, 2);
			GetDifficult(i);
		}
		PickBackground(PlayableBackground);
		BackGround.sprite = _choosedSprite;
	}

	public void GetDifficult(int n)
	{
		switch (n)
		{
			case 0:
				PlayableBackground = EasyGame;
				break;
			case 1:
				PlayableBackground = MedioGame;
				break;
			case 2:
				PlayableBackground = HardGame;
				break;
		}
	}

	void PickBackground(List<Sprite> difficult)
	{
		var sprites = difficult.ToArray();
		var i = Random.Range(0, sprites.Length);
		_choosedSprite = sprites[i];
	}
}
