using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacteristics : MonoBehaviour {

     public enum Characteristics01 {Option01, Option02, Option03};
     public static Characteristics01 wathChar1;
     public enum Characteristics02 { Option01, Option02, Option03 };
     public static Characteristics02 wathChar2;
     public enum Characteristics03 { Option01, Option02, Option03 };
     public static Characteristics03 wathChar3;

    // Use this for initialization
    void Start () {

        int i1 = Random.Range(1, 4);
        if (i1 == 1) { wathChar1 = Characteristics01.Option01; } else
        if (i1 == 2) { wathChar1 = Characteristics01.Option02; } else
        if (i1 == 3) { wathChar1 = Characteristics01.Option03; }

        int i2 = Random.Range(1, 4);
        if (i2 == 1) { wathChar2 = Characteristics02.Option01; } else
        if (i2 == 2) { wathChar2 = Characteristics02.Option02; } else
        if (i2 == 3) { wathChar2 = Characteristics02.Option03; }

        int i3 = Random.Range(1, 4);
        if (i3 == 1) { wathChar3 = Characteristics03.Option01; } else
        if (i3 == 2) { wathChar3 = Characteristics03.Option02; } else
        if (i3 == 3) { wathChar3 = Characteristics03.Option03; }

        Debug.Log(wathChar1);
        Debug.Log(wathChar2);
        Debug.Log(wathChar3);

    }

}
