using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HealthBar : MonoBehaviour
{
    public Transform bar = null;

    public int value;

    public Transform character = null;

    // Start is called before the first frame update
    void Start()
    {
        value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = character.position + new Vector3(0, 0.8f, 0.0f);
    }

    public void SetValue(int newValue)
    {
        value = newValue;

        bar.localScale = new Vector3(value / 100.0f, 1.0f, 1.0f);

        if(bar.localScale.x <= 0)
        {
            bar.localScale = new Vector3(0.0f, 1.0f, 1.0f);
        }
    }
}
