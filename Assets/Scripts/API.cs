using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class API : MonoBehaviour
{
    private const string GetUrl = "https://reqres.in/api/users?page=1"; // Free API for GET request
    private const string PostUrl = "https://reqres.in/api/users"; // Free API for POST request

    public Text ResponseText;

    public void RequestGet()
    {
        StartCoroutine(GetRequest());
    }

    public void RequestPost()
    {
        StartCoroutine(PostRequest());
    }

    private IEnumerator GetRequest()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(GetUrl))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError("GET Error: " + request.error);
                ResponseText.text = "GET Error: " + request.error;
            }
            else
            {
                ResponseText.text = request.downloadHandler.text;
                Debug.Log("GET Response: " + request.downloadHandler.text);
            }
        }
    }

    private IEnumerator PostRequest()
    {
        // Creating an object for JSON data
        Person person = new Person { Name = "Man", Job = "Learner" };
        string jsonData = JsonUtility.ToJson(person);

        using (UnityWebRequest request = new UnityWebRequest(PostUrl, "POST"))
        {
            byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonData);
            request.uploadHandler = new UploadHandlerRaw(bodyRaw);
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError("POST Error: " + request.error);
                ResponseText.text = "POST Error: " + request.error;
            }
            else
            {
                ResponseText.text = request.downloadHandler.text;
                Debug.Log("POST Response: " + request.downloadHandler.text);
            }
        }
    }
}

// Class for JSON serialization
[System.Serializable]
public class Person
{
    public string Name;
    public string Job;
}
