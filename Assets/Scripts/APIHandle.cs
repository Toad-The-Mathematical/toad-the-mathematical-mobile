using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class APIHandle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	IEnumerator GetData(string url)
	{
		using (UnityWebRequest www = UnityWebRequest.Get("http://toadmath-env-1.eba-y3mnv56q.ap-northeast-1.elasticbeanstalk.com/swagger-ui/index.html#/"))
		{
			yield return www.SendWebRequest();

			if (www.result != UnityWebRequest.Result.Success)
			{
				Debug.Log(www.error);
			}
			else
			{
				string data = www.downloadHandler.text;
				// Process the retrieved data
			}
		}
	}

}
