using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTrigger : MonoBehaviour {

	public void SaveCall()
    {
        Persistence.SavaData();
        Debug.Log("Salve");
    }
    public void LoadCall()
    {
        Persistence.LoadData();
        Debug.Log("Load");
    }
    public void ClearCall()
    {
        Persistence.ReturnValues();
        Debug.Log("Clear");
    }

}
