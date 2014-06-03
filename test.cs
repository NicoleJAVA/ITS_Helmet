using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	//public Transform target;

	// Use this for initialization
	void Start () {
		//iTween.LookTo(gameObject, gameObject.transform.forward,2f);
		//iTween.MoveTo(gameObject,iTween.Hash("path",iTweenPath.GetPath("BoxIn"),"time",200,"orienttopath", true)); //Nicole commented
		//iTween.MoveTo(gameObject,iTween.Hash("path",iTweenPath.GetPath("BoxIn"),"movetopath",false,"time",200,"orienttopath", true));
		// v.3. to make the rotation work (to make orientation work like an orbit well )
		//iTween.MoveTo(gameObject,iTween.Hash("path",iTweenPath.GetPath("BoxIn"),"time",240,"orienttopath", true)); //ORIGINAL
		//iTween.MoveTo(gameObject,iTween.Hash("path",iTweenPath.GetPath("BoxIn2"),"time",70,"orienttopath", true));
		//iTween.MoveTo(gameObject,iTween.Hash("path",iTweenPath.GetPath("BoxIn2"),"time",70,"orienttopath", true,"looktime",0.05));
		iTween.MoveTo(gameObject,iTween.Hash("path",iTweenPath.GetPath("BoxIn"),"time",15,"orienttopath", true,"easetype",iTween.EaseType.easeInOutSine,"onComplete","pathComplete"));
	}//easeOutSine
	
	// Update is called once per frame
	void Update () {
		//iTween.LookUpdate(gameObject,target.position,2);
	}

	void pathComplete(){
		iTween.MoveTo(gameObject,iTween.Hash("path",iTweenPath.GetPath("Box2"),"time",10,"orienttopath", true,"easetype",iTween.EaseType.easeInOutSine));

	}    //    End    pathComplete()

}
