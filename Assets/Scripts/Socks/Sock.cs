public class Sock
{
    private SockPairConfig _pairConfig;
    private int _pairMember;

    public SockPairConfig PairConfig => _pairConfig;
    public SockState State { get; set; }
    public int PairMember => _pairMember;

    public Sock(SockPairConfig pairConfig, int pairMember)
    {
        _pairConfig = pairConfig;
        _pairMember = pairMember;
        State = SockState.InWorld;
    }
}
