# API Calling Guide

This guide will help you understand how to make API calls using **Unity (C#)** and **Postman**, covering both **GET** and **POST** requests.

---

## 1. What is an API?

> An API (Application Programming Interface) allows communication between different applications.  
> In Unity, APIs are often used to send and receive data from a server.


---

## 2. Difference Between GET and POST Requests

| Request Type | Purpose                        |
|--------------|--------------------------------|
| GET          | Retrieves data from the server |
| POST         | Sends new data to the server   |

---

## 3. How to Make API Calls in Unity (C#)

### ✅ Import Required Namespaces

Before making API calls, import the required namespaces in Unity:

```csharp
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
```

---

# ✅ How to Make API Calls in Unity

## 1. ✅ Create a Script for API Calls

Create a new C# script called `APIManager.cs` and add the following code:

🔗 [APIManager.cs on Pastebin](https://pastebin.com/raw/zTvTeNkV)

---

## 2. ✅ Attach the Script to a GameObject

- Create a new **GameObject** in Unity.
- Attach the `APIManager` script to the GameObject.
- Assign a **UI Text element** to the `ResponseText` field in the **Inspector**.
- Create two buttons:
  - **"GET Data"** — Assign it to the `GetRequest()` method.
  - **"POST Data"** — Assign it to the `PostRequest()` method.

---

## 3. ✅ How to Make API Calls in Postman

### 🔹 Open Postman
- Download Postman: [https://www.postman.com/downloads/](https://www.postman.com/downloads/)
- Open Postman and click on **"Send an API Request"**

---

### 🔹 Send a GET Request

- Click **New Request**
- Change method to `GET`
- Enter URL:  
  ```
  https://reqres.in/api/users?page=2
  ```
- Click **Send**
- The response will appear below

---

### 🔹 Send a POST Request

- Click **New Request**
- Change method to `POST`
- Enter URL:  
  ```
  https://reqres.in/api/users
  ```
- Click on the **Body** tab, select **raw**, and choose **JSON**
- Paste the following JSON:

```json
{
  "name": "Man",
  "job": "Learner"
}
```

- Click **Send**
- The response will appear below with a success message

---

## 4. ✅ Common Errors and Fixes

| **Error**                  | **Solution**                                           |
|----------------------------|--------------------------------------------------------|
| 400 Bad Request            | Check if JSON data is properly formatted              |
| 401 Unauthorized           | Ensure you have the correct API keys (if required)     |
| 404 Not Found              | Verify the API endpoint URL                            |
| 500 Internal Server Error  | Issue is on the server-side                            |

![image (20)](https://github.com/user-attachments/assets/efac946e-26f6-4180-8f2d-2673cffda3fb)


---

## 5. ✅ Unity UI Requirements

You need to create a UI like the image (if provided), with:

- One button for **GET Request**
- One button for **POST Request**
- Each button should call:
  - `RequestGet()` for GET
  - `RequestPost()` for POST
- A **Text field** for displaying the response

⚠️ If **TextMeshPro (TMPro)** is not supported, use a standard **UI Text** component instead.
[![How to Structure and Write JSON Files](https://img.youtube.com/vi/iiADhChRriM/0.jpg)](https://www.youtube.com/watch?v=iiADhChRriM)

The link above likely explains how to structure and write **JSON files**.
**JSON (JavaScript Object Notation)** is a lightweight data format used to store and exchange data.
