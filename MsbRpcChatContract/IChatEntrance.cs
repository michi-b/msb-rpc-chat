using MsbRpc.Contracts;
using MsbRpc.Generator.Attributes;

namespace MsbRpcChatContract;

[RpcContract(generateServer: true)]
public interface IChatEntrance : IRpcContract
{
    public int Register(string name);
}