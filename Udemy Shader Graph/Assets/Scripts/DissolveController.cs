using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveController : MonoBehaviour
{
    //public float cutOff = .5f;

    public Renderer rend;

    public float dissolveSpeed = 1f;
    private float dissolveAmount = 1f;
    private bool dissolving = false;
    public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rend.material.SetFloat("_Cutoff", cutOff);

        if(Input.GetKeyDown(KeyCode.D))
        {
            dissolving = !dissolving;

            if(effect != null)
            {
                effect.SetActive(true);
            }
        }

        if (dissolving == true)
        {
            dissolveAmount = Mathf.MoveTowards(dissolveAmount, 0f, dissolveSpeed * Time.deltaTime);
        } else
        {
            dissolveAmount = Mathf.MoveTowards(dissolveAmount, 1f, dissolveSpeed * Time.deltaTime);
        }

        rend.material.SetFloat("_Cutoff", dissolveAmount);

        if(dissolveAmount <= .5f)
        {
            rend.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        } else
        {
            rend.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
        }
    }
}
