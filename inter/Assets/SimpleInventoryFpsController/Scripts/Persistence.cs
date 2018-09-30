using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Persistence
{

    static public bool HaveASave;

    public static void SavaData()
    {
        HaveASave = true;
        PlayerPrefsX.SetBool("HaveASave", HaveASave);
        PlayerPrefs.SetInt("NReds", PickUp.NReds);
        PlayerPrefs.SetInt("NBlues", PickUp.NBlues);
        PlayerPrefs.SetInt("NGreens", PickUp.NGreens);
    }

    public static void LoadData()
    {
        HaveASave = PlayerPrefsX.GetBool("HaveASave");
        PickUp.NReds = PlayerPrefs.GetInt("NReds");
        PickUp.NBlues = PlayerPrefs.GetInt("NBlues");
        PickUp.NGreens = PlayerPrefs.GetInt("NGreens");
    }

    public static void ReturnValues()
    {
        PlayerPrefs.DeleteAll();
        HaveASave = false;
        PickUp.NReds = 0;
        PickUp.NBlues = 0;
        PickUp.NGreens = 0;

    }
}