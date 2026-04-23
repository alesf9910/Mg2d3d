using System;
using Mg2d3d.Core;
using Mg2d3d.Interop;

namespace Mg2d3d.Text;

public unsafe struct DirectWriteContext
{
    public void* Factory;

    public ResultCode Initialize()
    {
        Guid iid = Guid.Parse("B859EE5A-D838-4B5B-A2E8-1ADC7D93DB48");
        void* factory = null;
        int hr = DirectWriteNative.DWriteCreateFactory(DirectWriteNative.DWriteFactoryTypeShared, ref iid, &factory);
        if (hr < 0 || factory is null)
        {
            return ResultCode.BackendFailure;
        }

        Factory = factory;
        return ResultCode.Success;
    }

    public void Shutdown()
    {
        if (Factory is not null)
        {
            Factory = null;
        }
    }
}
