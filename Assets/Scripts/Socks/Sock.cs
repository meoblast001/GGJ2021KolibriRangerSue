using UniRx;

public class Sock
{
    private SockPairConfig _pairConfig;
    private int _pairMember;

    public SockPairConfig PairConfig => _pairConfig;
    public IReactiveProperty<SockState> State { get; }
    public int PairMember => _pairMember;

    public Sock(SockPairConfig pairConfig, int pairMember)
    {
        _pairConfig = pairConfig;
        _pairMember = pairMember;
        State = new ReactiveProperty<SockState>(SockState.InWorld);
    }
}
