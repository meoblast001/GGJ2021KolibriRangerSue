public class Sock
{
    private SockPairConfig _pairConfig;
    private SockState _state;

    public SockPairConfig PairConfig => _pairConfig;
    public SockState State => _state;

    public Sock(SockPairConfig pairConfig)
    {
        _pairConfig = pairConfig;
        _state = SockState.InWorld;
    }
}
