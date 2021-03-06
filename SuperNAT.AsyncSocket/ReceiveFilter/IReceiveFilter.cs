﻿using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;

namespace SuperNAT.AsyncSocket
{
    public interface IReceiveFilter<TRequestInfo> where TRequestInfo : IRequestInfo, new()
    {
        IReceiveFilter<TRequestInfo> NextReceiveFilter { get; }
        TRequestInfo Filter(ref SequenceReader<byte> reader);
        TRequestInfo DecodePackage(ReadOnlySequence<byte> data);
        void Reset();
    }
}
