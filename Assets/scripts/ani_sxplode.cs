using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ani_sxplode : MonoBehaviour, IVirtualButtonEventHandler
{
    Animator anim;
    public GameObject Right_CerebrumObj, Left_CerebrumObj, CerebellumObj, Corpus_CallosumObj, Brain_StemObj;
    public GameObject dialogePanel;
    // Start is called before the first frame update
    void Start()
    {
        Right_CerebrumObj = GameObject.Find("Right_Cerebrum");
        Right_CerebrumObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Left_CerebrumObj = GameObject.Find("Left_Cerebrum");
        Left_CerebrumObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        CerebellumObj = GameObject.Find("Cerebellum");
        CerebellumObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Corpus_CallosumObj = GameObject.Find("Corpus_Callosum");
        Corpus_CallosumObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Brain_StemObj = GameObject.Find("Brain_Stem");
        Brain_StemObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      /*  if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("presssed");
            anim.SetBool("Left_Cerebrum", true);
            anim.SetBool("Right_Cerebrum", false);
            anim.SetBool("Thalamus", false);
            anim.SetBool("Corpus_Callosum", false);
            anim.SetBool("Cerebellum", false);
            anim.SetBool("Brain_Stem", false);
        }else if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W is presssed");
            anim.SetBool("Left_Cerebrum", false);
            anim.SetBool("Right_Cerebrum", true);
            anim.SetBool("Thalamus", false);
            anim.SetBool("Corpus_Callosum", false);
            anim.SetBool("Cerebellum", false);
            anim.SetBool("Brain_Stem", false);
        } */
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(vb.VirtualButtonName == "Right_Cerebrum")
        {
            Debug.Log("right presssed");
            anim.SetBool("Left_Cerebrum", true);
            anim.SetBool("Right_Cerebrum", false);
            anim.SetBool("Thalamus", false);
            anim.SetBool("Corpus_Callosum", false);
            anim.SetBool("Cerebellum", false);
            anim.SetBool("Brain_Stem", false);

            StartCoroutine("Fade");
        }
        else if(vb.VirtualButtonName == "Left_Cerebrum")
        {
            Debug.Log("left is presssed");
            anim.SetBool("Left_Cerebrum", false);
            anim.SetBool("Right_Cerebrum", true);
            anim.SetBool("Thalamus", false);
            anim.SetBool("Corpus_Callosum", false);
            anim.SetBool("Cerebellum", false);
            anim.SetBool("Brain_Stem", false);
        }else if(vb.VirtualButtonName == "Cerebellum")
        {
            Debug.Log("left is presssed");
            anim.SetBool("Left_Cerebrum", false);
            anim.SetBool("Right_Cerebrum", false);
            anim.SetBool("Thalamus", false);
            anim.SetBool("Corpus_Callosum", false);
            anim.SetBool("Cerebellum", true);
            anim.SetBool("Brain_Stem", false);
        }else if (vb.VirtualButtonName == "Corpus_Callosum")
        {
            Debug.Log("left is presssed");
            anim.SetBool("Left_Cerebrum", false);
            anim.SetBool("Right_Cerebrum", false);
            anim.SetBool("Thalamus", false);
            anim.SetBool("Corpus_Callosum", true);
            anim.SetBool("Cerebellum", false);
            anim.SetBool("Brain_Stem", false);
        }else if (vb.VirtualButtonName == "Brain_Stem")
        {
            Debug.Log("left is presssed");
            anim.SetBool("Left_Cerebrum", false);
            anim.SetBool("Right_Cerebrum", false);
            anim.SetBool("Thalamus", false);
            anim.SetBool("Corpus_Callosum", false);
            anim.SetBool("Cerebellum", false);
            anim.SetBool("Brain_Stem", true);
        }
    }

    IEnumerator Fade()
    {
        dialogePanel.SetActive(true);
        Debug.Log(Time.time);
        yield return new WaitForSeconds(5f);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("none");
    }
}
