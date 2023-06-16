using MsbRpc.Contracts;
using MsbRpc.Generator.Attributes;

namespace MsbRpcChatContract;

[RpcContract]
[GenerateServer]
public interface IChatEntrance : IRpcContract
{
}