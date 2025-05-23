﻿//HintName: RegressionMultipleUniqueIndexesHadSameName.cs
// <auto-generated />
#nullable enable

partial struct RegressionMultipleUniqueIndexesHadSameName
    : System.IEquatable<RegressionMultipleUniqueIndexesHadSameName>,
        SpacetimeDB.BSATN.IStructuralReadWrite
{
    public void ReadFields(System.IO.BinaryReader reader)
    {
        Unique1 = BSATN.Unique1.Read(reader);
        Unique2 = BSATN.Unique2.Read(reader);
    }

    public void WriteFields(System.IO.BinaryWriter writer)
    {
        BSATN.Unique1.Write(writer, Unique1);
        BSATN.Unique2.Write(writer, Unique2);
    }

    object SpacetimeDB.BSATN.IStructuralReadWrite.GetSerializer()
    {
        return new BSATN();
    }

    public override string ToString() =>
        $"RegressionMultipleUniqueIndexesHadSameName {{ Unique1 = {SpacetimeDB.BSATN.StringUtil.GenericToString(Unique1)}, Unique2 = {SpacetimeDB.BSATN.StringUtil.GenericToString(Unique2)} }}";

    public readonly partial struct BSATN
        : SpacetimeDB.BSATN.IReadWrite<RegressionMultipleUniqueIndexesHadSameName>
    {
        internal static readonly SpacetimeDB.BSATN.U32 Unique1 = new();
        internal static readonly SpacetimeDB.BSATN.U32 Unique2 = new();

        public RegressionMultipleUniqueIndexesHadSameName Read(System.IO.BinaryReader reader)
        {
            var ___result = new RegressionMultipleUniqueIndexesHadSameName();
            ___result.ReadFields(reader);
            return ___result;
        }

        public void Write(
            System.IO.BinaryWriter writer,
            RegressionMultipleUniqueIndexesHadSameName value
        )
        {
            value.WriteFields(writer);
        }

        public SpacetimeDB.BSATN.AlgebraicType.Ref GetAlgebraicType(
            SpacetimeDB.BSATN.ITypeRegistrar registrar
        ) =>
            registrar.RegisterType<RegressionMultipleUniqueIndexesHadSameName>(
                _ => new SpacetimeDB.BSATN.AlgebraicType.Product(
                    new SpacetimeDB.BSATN.AggregateElement[]
                    {
                        new(nameof(Unique1), Unique1.GetAlgebraicType(registrar)),
                        new(nameof(Unique2), Unique2.GetAlgebraicType(registrar))
                    }
                )
            );

        SpacetimeDB.BSATN.AlgebraicType SpacetimeDB.BSATN.IReadWrite<RegressionMultipleUniqueIndexesHadSameName>.GetAlgebraicType(
            SpacetimeDB.BSATN.ITypeRegistrar registrar
        ) => GetAlgebraicType(registrar);
    }

    public override int GetHashCode()
    {
        var ___hashUnique1 = Unique1.GetHashCode();
        var ___hashUnique2 = Unique2.GetHashCode();
        return ___hashUnique1 ^ ___hashUnique2;
    }

#nullable enable
    public bool Equals(RegressionMultipleUniqueIndexesHadSameName that)
    {
        var ___eqUnique1 = this.Unique1.Equals(that.Unique1);
        var ___eqUnique2 = this.Unique2.Equals(that.Unique2);
        return ___eqUnique1 && ___eqUnique2;
    }

    public override bool Equals(object? that)
    {
        if (that == null)
        {
            return false;
        }
        var that_ = that as RegressionMultipleUniqueIndexesHadSameName?;
        if (((object?)that_) == null)
        {
            return false;
        }
        return Equals(that_);
    }

    public static bool operator ==(
        RegressionMultipleUniqueIndexesHadSameName this_,
        RegressionMultipleUniqueIndexesHadSameName that
    )
    {
        if (((object?)this_) == null || ((object?)that) == null)
        {
            return object.Equals(this_, that);
        }
        return this_.Equals(that);
    }

    public static bool operator !=(
        RegressionMultipleUniqueIndexesHadSameName this_,
        RegressionMultipleUniqueIndexesHadSameName that
    )
    {
        if (((object?)this_) == null || ((object?)that) == null)
        {
            return !object.Equals(this_, that);
        }
        return !this_.Equals(that);
    }
#nullable restore
} // RegressionMultipleUniqueIndexesHadSameName
