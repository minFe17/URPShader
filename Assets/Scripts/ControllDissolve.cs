using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllDissolve : MonoBehaviour
{
    [SerializeField] Slider _slider;
    Material _material;

    private void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
    }

    public void SliderChange()
    {
        _material.SetFloat("_Split_Value", _slider.value);
    }
}
