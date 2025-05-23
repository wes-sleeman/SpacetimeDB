﻿//HintName: TestAutoIncNotInteger.cs
// <auto-generated />
#nullable enable

partial struct TestAutoIncNotInteger
    : System.IEquatable<TestAutoIncNotInteger>,
        SpacetimeDB.BSATN.IStructuralReadWrite
{
    public void ReadFields(System.IO.BinaryReader reader)
    {
        AutoIncField = BSATN.AutoIncField.Read(reader);
        IdentityField = BSATN.IdentityField.Read(reader);
    }

    public void WriteFields(System.IO.BinaryWriter writer)
    {
        BSATN.AutoIncField.Write(writer, AutoIncField);
        BSATN.IdentityField.Write(writer, IdentityField);
    }

    object SpacetimeDB.BSATN.IStructuralReadWrite.GetSerializer()
    {
        return new BSATN();
    }

    public override string ToString() =>
        $"TestAutoIncNotInteger {{ AutoIncField = {SpacetimeDB.BSATN.StringUtil.GenericToString(AutoIncField)}, IdentityField = {SpacetimeDB.BSATN.StringUtil.GenericToString(IdentityField)} }}";

    public readonly partial struct BSATN : SpacetimeDB.BSATN.IReadWrite<TestAutoIncNotInteger>
    {
        internal static readonly SpacetimeDB.BSATN.F32 AutoIncField = new();
        internal static readonly SpacetimeDB.BSATN.String IdentityField = new();

        public TestAutoIncNotInteger Read(System.IO.BinaryReader reader)
        {
            var ___result = new TestAutoIncNotInteger();
            ___result.ReadFields(reader);
            return ___result;
        }

        public void Write(System.IO.BinaryWriter writer, TestAutoIncNotInteger value)
        {
            value.WriteFields(writer);
        }

        public SpacetimeDB.BSATN.AlgebraicType.Ref GetAlgebraicType(
            SpacetimeDB.BSATN.ITypeRegistrar registrar
        ) =>
            registrar.RegisterType<TestAutoIncNotInteger>(
                _ => new SpacetimeDB.BSATN.AlgebraicType.Product(
                    new SpacetimeDB.BSATN.AggregateElement[]
                    {
                        new(nameof(AutoIncField), AutoIncField.GetAlgebraicType(registrar)),
                        new(nameof(IdentityField), IdentityField.GetAlgebraicType(registrar))
                    }
                )
            );

        SpacetimeDB.BSATN.AlgebraicType SpacetimeDB.BSATN.IReadWrite<TestAutoIncNotInteger>.GetAlgebraicType(
            SpacetimeDB.BSATN.ITypeRegistrar registrar
        ) => GetAlgebraicType(registrar);
    }

    public override int GetHashCode()
    {
        var ___hashAutoIncField = AutoIncField.GetHashCode();
        var ___hashIdentityField = IdentityField == null ? 0 : IdentityField.GetHashCode();
        return ___hashAutoIncField ^ ___hashIdentityField;
    }

#nullable enable
    public bool Equals(TestAutoIncNotInteger that)
    {
        var ___eqAutoIncField = this.AutoIncField.Equals(that.AutoIncField);
        var ___eqIdentityField =
            this.IdentityField == null
                ? that.IdentityField == null
                : this.IdentityField.Equals(that.IdentityField);
        return ___eqAutoIncField && ___eqIdentityField;
    }

    public override bool Equals(object? that)
    {
        if (that == null)
        {
            return false;
        }
        var that_ = that as TestAutoIncNotInteger?;
        if (((object?)that_) == null)
        {
            return false;
        }
        return Equals(that_);
    }

    public static bool operator ==(TestAutoIncNotInteger this_, TestAutoIncNotInteger that)
    {
        if (((object?)this_) == null || ((object?)that) == null)
        {
            return object.Equals(this_, that);
        }
        return this_.Equals(that);
    }

    public static bool operator !=(TestAutoIncNotInteger this_, TestAutoIncNotInteger that)
    {
        if (((object?)this_) == null || ((object?)that) == null)
        {
            return !object.Equals(this_, that);
        }
        return !this_.Equals(that);
    }
#nullable restore
} // TestAutoIncNotInteger
