﻿using System;
using Blueshift.EntityFrameworkCore.Annotations;

namespace Blueshift.EntityFrameworkCore.MongoDB.Tests.TestDomain
{
    [DerivedType(typeof(SubDerivedType1))]
    [DerivedType(typeof(SubDerivedType2))]
    public abstract class SubRootType1 : RootType, IEquatable<SubRootType1>
    {
        public byte ByteProperty { get; set; } = (byte)new Random().Next(maxValue: 0x0FF);

        public override bool Equals(RootType other)
            => Equals(other as SubRootType1);

        public virtual bool Equals(SubRootType1 other)
            => base.Equals(other) &&
               ByteProperty == other?.ByteProperty;
    }
}