using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WavesUI : MonoBehaviour
{
    // Start is called before the first frame update
    TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
        WaveManager.instance.onChanged.AddListener(RefreshText);
    }

    // Update is called once per frame
    void RefreshText()
    {
        text.text = "Remaining Waves: " + WaveManager.instance.waves.Count;
    }
}
