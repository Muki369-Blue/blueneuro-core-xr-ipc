
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class PythonIPCClient : MonoBehaviour
{
    TcpClient client;

    void Start()
    {
        client = new TcpClient("127.0.0.1", 8765);
        Send("{\"command\":\"ping\"}");
    }

    void Send(string msg)
    {
        var stream = client.GetStream();
        byte[] data = Encoding.UTF8.GetBytes(msg);
        stream.Write(data, 0, data.Length);
    }
}
