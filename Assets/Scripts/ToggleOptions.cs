using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOptions : MonoBehaviour
{
    // Resource: Unity Docs/forums on Lists vs Arrays, coroutines, and changing conditions to play animation.

    public GameObject optionsPanel;
    public GameObject viewPanel;
    public GameObject playButton;
    public GameObject nextColorButton;
    public GameObject movie;
    public GameObject spinningObject;

    public List<GameObject> toggledGameObjects;

    public Animator optionsAnimator;
    public Animator viewAnimator;

    private bool isExpanded = false;

    private void Start()
    {
        //assign animators
        optionsAnimator = optionsPanel.GetComponent<Animator>();
        viewAnimator = viewPanel.GetComponent<Animator>();

        //Adding gameobjects to list
        //Improve elegance???
        toggledGameObjects.Add(playButton);
        toggledGameObjects.Add(nextColorButton);
        toggledGameObjects.Add(movie);
        toggledGameObjects.Add(spinningObject);
    }

    public void ToggleOptionsPanel()
    {
        isExpanded = !isExpanded;

        //change bool to change animator states
        //can this be combined into one???
        optionsAnimator.SetBool("isExpanded", isExpanded);
        viewAnimator.SetBool("isExpanded", isExpanded);

        //flip button direction
        gameObject.transform.localScale = new Vector3((transform.localScale.x * -1), 1, 1);

        if(isExpanded)
        {
            StartCoroutine(WaitForAnim());
        }
        else
        {
            //hide all objects
            foreach (GameObject go in toggledGameObjects)
            {
                go.SetActive(isExpanded);
            }
        }
    }

    IEnumerator WaitForAnim()
    {
        //waits to complete animation before showing objects
        yield return new WaitForSeconds(1f);
        foreach (GameObject go in toggledGameObjects)
        {
            go.SetActive(isExpanded);
        }
    }

}
