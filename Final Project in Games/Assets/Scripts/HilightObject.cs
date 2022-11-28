using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HilightObject : MonoBehaviour
{
    Material material;
    [SerializeField] [ColorUsage(true,true)] Color rimHilightColor, rimDefaultColor;
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    private void OnMouseEnter()
    {
        material.SetColor("_Rim_Color", rimHilightColor);
    }

    private void OnMouseExit()
    {
        material.SetColor("_Rim_Color", rimDefaultColor);
    }
}
