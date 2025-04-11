using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public string triggerName;
    public float delay = 0f;
    public float resetTime;
    public KeyCode triggerKey = KeyCode.None;
    private AudioSource audioSource;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(triggerKey))
        {
            CallTrigger();
        }
    }
    public void CallTrigger()
    {
        StartCoroutine(AwaitDelay(delay));
        StartCoroutine(AwaitReset(resetTime));
    }
    private IEnumerator AwaitDelay(float time)
    {
        yield return new WaitForSeconds(time);

        Debug.Log("tiggername" + triggerName);
        animator.SetTrigger(triggerName);
        if (audioSource != null) audioSource.Play();
    }
    private IEnumerator AwaitReset(float time)
    {
        yield return new WaitForSeconds(time);
        animator.ResetTrigger(triggerName);
    }
}
