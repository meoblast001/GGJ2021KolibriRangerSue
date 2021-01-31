public class SockInventory
{
    private Sock _leftSock;
    private Sock _rightSock;

    public Sock LeftSock => _leftSock;
    public Sock RightSock => _rightSock;

    public int SockCount
    {
        get
        {
            int sockCount = 0;
            if (_leftSock != null) sockCount++;
            if (_rightSock != null) sockCount++;
            return sockCount;
        }
    }

    public bool AddSock(Sock sock)
    {
        if (_leftSock == null)
            _leftSock = sock;
        else if (_rightSock == null)
            _rightSock = sock;
        else
            return false;

        return true;
    }
}
