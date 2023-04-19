using UnityEngine;

public class ControllPhaser : MonoBehaviour
{
    Material _material;
    float _time = 0;
    private void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        _time += Time.deltaTime;
        if (_time > 2f)
        {
            _time = 0f;
        }
        _material.SetFloat("_Split_Value", _time);
    }
}
