﻿// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: my.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SparkplugNet.Tests
{
    [global::ProtoBuf.ProtoContract()]
    internal partial class VersionBProtoBufPayload : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"timestamp")]
        public ulong Timestamp { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"metrics")]
        public global::System.Collections.Generic.List<Metric> Metrics { get; set; } = new global::System.Collections.Generic.List<Metric>();

        [global::ProtoBuf.ProtoMember(3, Name = @"seq")]
        public ulong Seq { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"uuid")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Uuid { get; set; } = "";

        [global::ProtoBuf.ProtoMember(5, Name = @"body")]
        public byte[] Body { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"details")]
        public global::System.Collections.Generic.List<byte> Details { get; set; } = new global::System.Collections.Generic.List<byte>();

        [global::ProtoBuf.ProtoContract()]
        internal partial class Template : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"version")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Version { get; set; } = "";

            [global::ProtoBuf.ProtoMember(2, Name = @"metrics")]
            public global::System.Collections.Generic.List<Metric> Metrics { get; set; } = new global::System.Collections.Generic.List<Metric>();

            [global::ProtoBuf.ProtoMember(3, Name = @"parameters")]
            public global::System.Collections.Generic.List<Parameter> Parameters { get; set; } = new global::System.Collections.Generic.List<Parameter>();

            [global::ProtoBuf.ProtoMember(4, Name = @"template_ref")]
            [global::System.ComponentModel.DefaultValue("")]
            public string TemplateRef { get; set; } = "";

            [global::ProtoBuf.ProtoMember(5, Name = @"is_definition")]
            public bool IsDefinition { get; set; }

            [global::ProtoBuf.ProtoMember(6, Name = @"details")]
            public global::System.Collections.Generic.List<byte> Details { get; set; } = new global::System.Collections.Generic.List<byte>();

            [global::ProtoBuf.ProtoContract()]
            internal partial class Parameter : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"name")]
                [global::System.ComponentModel.DefaultValue("")]
                public string Name { get; set; } = "";

                [global::ProtoBuf.ProtoMember(2, Name = @"type")]
                public uint Type { get; set; }

                [global::ProtoBuf.ProtoMember(3, Name = @"int_value")]
                public uint IntValue
                {
                    get => __pbn__value.Is(3) ? __pbn__value.UInt32 : default;
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(3, value);
                }
                public bool ShouldSerializeIntValue() => __pbn__value.Is(3);
                public void ResetIntValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 3);

                private global::ProtoBuf.DiscriminatedUnion64Object __pbn__value;

                [global::ProtoBuf.ProtoMember(4, Name = @"long_value")]
                public ulong LongValue
                {
                    get => __pbn__value.Is(4) ? __pbn__value.UInt64 : default;
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(4, value);
                }
                public bool ShouldSerializeLongValue() => __pbn__value.Is(4);
                public void ResetLongValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 4);

                [global::ProtoBuf.ProtoMember(5, Name = @"float_value")]
                public float FloatValue
                {
                    get => __pbn__value.Is(5) ? __pbn__value.Single : default;
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(5, value);
                }
                public bool ShouldSerializeFloatValue() => __pbn__value.Is(5);
                public void ResetFloatValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 5);

                [global::ProtoBuf.ProtoMember(6, Name = @"double_value")]
                public double DoubleValue
                {
                    get => __pbn__value.Is(6) ? __pbn__value.Double : default;
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(6, value);
                }
                public bool ShouldSerializeDoubleValue() => __pbn__value.Is(6);
                public void ResetDoubleValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 6);

                [global::ProtoBuf.ProtoMember(7, Name = @"boolean_value")]
                public bool BooleanValue
                {
                    get => __pbn__value.Is(7) ? __pbn__value.Boolean : default;
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(7, value);
                }
                public bool ShouldSerializeBooleanValue() => __pbn__value.Is(7);
                public void ResetBooleanValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 7);

                [global::ProtoBuf.ProtoMember(8, Name = @"string_value")]
                [global::System.ComponentModel.DefaultValue("")]
                public string StringValue
                {
                    get => __pbn__value.Is(8) ? ((string)__pbn__value.Object) : "";
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(8, value);
                }
                public bool ShouldSerializeStringValue() => __pbn__value.Is(8);
                public void ResetStringValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 8);

                [global::ProtoBuf.ProtoMember(9, Name = @"extension_value")]
                public ParameterValueExtension ExtensionValue
                {
                    get => __pbn__value.Is(9) ? ((ParameterValueExtension)__pbn__value.Object) : default;
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(9, value);
                }
                public bool ShouldSerializeExtensionValue() => __pbn__value.Is(9);
                public void ResetExtensionValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 9);

                public ValueOneofCase ValueCase => (ValueOneofCase)__pbn__value.Discriminator;

                public enum ValueOneofCase
                {
                    None = 0,
                    IntValue = 3,
                    LongValue = 4,
                    FloatValue = 5,
                    DoubleValue = 6,
                    BooleanValue = 7,
                    StringValue = 8,
                    ExtensionValue = 9,
                }

                [global::ProtoBuf.ProtoContract()]
                internal partial class ParameterValueExtension : global::ProtoBuf.IExtensible
                {
                    private global::ProtoBuf.IExtension __pbn__extensionData;
                    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                    [global::ProtoBuf.ProtoMember(1, Name = @"extensions")]
                    public global::System.Collections.Generic.List<byte> Extensions { get; set; } = new global::System.Collections.Generic.List<byte>();

                }

            }

        }

        [global::ProtoBuf.ProtoContract()]
        internal partial class DataSet : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"num_of_columns")]
            public ulong NumOfColumns { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"columns")]
            public global::System.Collections.Generic.List<string> Columns { get; set; } = new global::System.Collections.Generic.List<string>();

            [global::ProtoBuf.ProtoMember(3, Name = @"types", IsPacked = true)]
            public uint[] Types { get; set; }

            [global::ProtoBuf.ProtoMember(4, Name = @"rows")]
            public global::System.Collections.Generic.List<Row> Rows { get; set; } = new global::System.Collections.Generic.List<Row>();

            [global::ProtoBuf.ProtoMember(5, Name = @"details")]
            public global::System.Collections.Generic.List<byte> Details { get; set; } = new global::System.Collections.Generic.List<byte>();

            [global::ProtoBuf.ProtoContract()]
            internal partial class DataSetValue : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"int_value")]
                public uint IntValue
                {
                    get => __pbn__value.Is(1) ? __pbn__value.UInt32 : default;
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(1, value);
                }
                public bool ShouldSerializeIntValue() => __pbn__value.Is(1);
                public void ResetIntValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 1);

                private global::ProtoBuf.DiscriminatedUnion64Object __pbn__value;

                [global::ProtoBuf.ProtoMember(2, Name = @"long_value")]
                public ulong LongValue
                {
                    get => __pbn__value.Is(2) ? __pbn__value.UInt64 : default;
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(2, value);
                }
                public bool ShouldSerializeLongValue() => __pbn__value.Is(2);
                public void ResetLongValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 2);

                [global::ProtoBuf.ProtoMember(3, Name = @"float_value")]
                public float FloatValue
                {
                    get => __pbn__value.Is(3) ? __pbn__value.Single : default;
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(3, value);
                }
                public bool ShouldSerializeFloatValue() => __pbn__value.Is(3);
                public void ResetFloatValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 3);

                [global::ProtoBuf.ProtoMember(4, Name = @"double_value")]
                public double DoubleValue
                {
                    get => __pbn__value.Is(4) ? __pbn__value.Double : default;
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(4, value);
                }
                public bool ShouldSerializeDoubleValue() => __pbn__value.Is(4);
                public void ResetDoubleValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 4);

                [global::ProtoBuf.ProtoMember(5, Name = @"boolean_value")]
                public bool BooleanValue
                {
                    get => __pbn__value.Is(5) ? __pbn__value.Boolean : default;
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(5, value);
                }
                public bool ShouldSerializeBooleanValue() => __pbn__value.Is(5);
                public void ResetBooleanValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 5);

                [global::ProtoBuf.ProtoMember(6, Name = @"string_value")]
                [global::System.ComponentModel.DefaultValue("")]
                public string StringValue
                {
                    get => __pbn__value.Is(6) ? ((string)__pbn__value.Object) : "";
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(6, value);
                }
                public bool ShouldSerializeStringValue() => __pbn__value.Is(6);
                public void ResetStringValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 6);

                [global::ProtoBuf.ProtoMember(7, Name = @"extension_value")]
                public DataSetValueExtension ExtensionValue
                {
                    get => __pbn__value.Is(7) ? ((DataSetValueExtension)__pbn__value.Object) : default;
                    set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(7, value);
                }
                public bool ShouldSerializeExtensionValue() => __pbn__value.Is(7);
                public void ResetExtensionValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 7);

                public ValueOneofCase ValueCase => (ValueOneofCase)__pbn__value.Discriminator;

                public enum ValueOneofCase
                {
                    None = 0,
                    IntValue = 1,
                    LongValue = 2,
                    FloatValue = 3,
                    DoubleValue = 4,
                    BooleanValue = 5,
                    StringValue = 6,
                    ExtensionValue = 7,
                }

                [global::ProtoBuf.ProtoContract()]
                internal partial class DataSetValueExtension : global::ProtoBuf.IExtensible
                {
                    private global::ProtoBuf.IExtension __pbn__extensionData;
                    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                    [global::ProtoBuf.ProtoMember(1, Name = @"details")]
                    public global::System.Collections.Generic.List<byte> Details { get; set; } = new global::System.Collections.Generic.List<byte>();

                }

            }

            [global::ProtoBuf.ProtoContract()]
            internal partial class Row : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"elements")]
                public global::System.Collections.Generic.List<DataSet.DataSetValue> Elements { get; set; } = new global::System.Collections.Generic.List<DataSet.DataSetValue>();

                [global::ProtoBuf.ProtoMember(2, Name = @"details")]
                public global::System.Collections.Generic.List<byte> Details { get; set; } = new global::System.Collections.Generic.List<byte>();

            }

        }

        [global::ProtoBuf.ProtoContract()]
        internal partial class PropertyValue : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"type")]
            public uint Type { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"is_null")]
            public bool IsNull { get; set; }

            [global::ProtoBuf.ProtoMember(3, Name = @"int_value")]
            public uint IntValue
            {
                get => __pbn__value.Is(3) ? __pbn__value.UInt32 : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(3, value);
            }
            public bool ShouldSerializeIntValue() => __pbn__value.Is(3);
            public void ResetIntValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 3);

            private global::ProtoBuf.DiscriminatedUnion64Object __pbn__value;

            [global::ProtoBuf.ProtoMember(4, Name = @"long_value")]
            public ulong LongValue
            {
                get => __pbn__value.Is(4) ? __pbn__value.UInt64 : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(4, value);
            }
            public bool ShouldSerializeLongValue() => __pbn__value.Is(4);
            public void ResetLongValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 4);

            [global::ProtoBuf.ProtoMember(5, Name = @"float_value")]
            public float FloatValue
            {
                get => __pbn__value.Is(5) ? __pbn__value.Single : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(5, value);
            }
            public bool ShouldSerializeFloatValue() => __pbn__value.Is(5);
            public void ResetFloatValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 5);

            [global::ProtoBuf.ProtoMember(6, Name = @"double_value")]
            public double DoubleValue
            {
                get => __pbn__value.Is(6) ? __pbn__value.Double : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(6, value);
            }
            public bool ShouldSerializeDoubleValue() => __pbn__value.Is(6);
            public void ResetDoubleValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 6);

            [global::ProtoBuf.ProtoMember(7, Name = @"boolean_value")]
            public bool BooleanValue
            {
                get => __pbn__value.Is(7) ? __pbn__value.Boolean : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(7, value);
            }
            public bool ShouldSerializeBooleanValue() => __pbn__value.Is(7);
            public void ResetBooleanValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 7);

            [global::ProtoBuf.ProtoMember(8, Name = @"string_value")]
            [global::System.ComponentModel.DefaultValue("")]
            public string StringValue
            {
                get => __pbn__value.Is(8) ? ((string)__pbn__value.Object) : "";
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(8, value);
            }
            public bool ShouldSerializeStringValue() => __pbn__value.Is(8);
            public void ResetStringValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 8);

            [global::ProtoBuf.ProtoMember(9, Name = @"propertyset_value")]
            public PropertySet PropertysetValue
            {
                get => __pbn__value.Is(9) ? ((PropertySet)__pbn__value.Object) : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(9, value);
            }
            public bool ShouldSerializePropertysetValue() => __pbn__value.Is(9);
            public void ResetPropertysetValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 9);

            [global::ProtoBuf.ProtoMember(10, Name = @"propertysets_value")]
            public PropertySetList PropertysetsValue
            {
                get => __pbn__value.Is(10) ? ((PropertySetList)__pbn__value.Object) : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(10, value);
            }
            public bool ShouldSerializePropertysetsValue() => __pbn__value.Is(10);
            public void ResetPropertysetsValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 10);

            [global::ProtoBuf.ProtoMember(11, Name = @"extension_value")]
            public PropertyValueExtension ExtensionValue
            {
                get => __pbn__value.Is(11) ? ((PropertyValueExtension)__pbn__value.Object) : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(11, value);
            }
            public bool ShouldSerializeExtensionValue() => __pbn__value.Is(11);
            public void ResetExtensionValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 11);

            public ValueOneofCase ValueCase => (ValueOneofCase)__pbn__value.Discriminator;

            public enum ValueOneofCase
            {
                None = 0,
                IntValue = 3,
                LongValue = 4,
                FloatValue = 5,
                DoubleValue = 6,
                BooleanValue = 7,
                StringValue = 8,
                PropertysetValue = 9,
                PropertysetsValue = 10,
                ExtensionValue = 11,
            }

            [global::ProtoBuf.ProtoContract()]
            internal partial class PropertyValueExtension : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"details")]
                public global::System.Collections.Generic.List<byte> Details { get; set; } = new global::System.Collections.Generic.List<byte>();

            }

        }

        [global::ProtoBuf.ProtoContract()]
        internal partial class PropertySet : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"keys")]
            public global::System.Collections.Generic.List<string> Keys { get; set; } = new global::System.Collections.Generic.List<string>();

            [global::ProtoBuf.ProtoMember(2, Name = @"values")]
            public global::System.Collections.Generic.List<PropertyValue> Values { get; set; } = new global::System.Collections.Generic.List<PropertyValue>();

            [global::ProtoBuf.ProtoMember(3, Name = @"details")]
            public global::System.Collections.Generic.List<byte> Details { get; set; } = new global::System.Collections.Generic.List<byte>();

        }

        [global::ProtoBuf.ProtoContract()]
        internal partial class PropertySetList : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"propertyset")]
            public global::System.Collections.Generic.List<PropertySet> Propertysets { get; set; } = new global::System.Collections.Generic.List<PropertySet>();

            [global::ProtoBuf.ProtoMember(2, Name = @"details")]
            public global::System.Collections.Generic.List<byte> Details { get; set; } = new global::System.Collections.Generic.List<byte>();

        }

        [global::ProtoBuf.ProtoContract()]
        internal partial class MetaData : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"is_multi_part")]
            public bool IsMultiPart { get; set; }

            [global::ProtoBuf.ProtoMember(2, Name = @"content_type")]
            [global::System.ComponentModel.DefaultValue("")]
            public string ContentType { get; set; } = "";

            [global::ProtoBuf.ProtoMember(3, Name = @"size")]
            public ulong Size { get; set; }

            [global::ProtoBuf.ProtoMember(4, Name = @"seq")]
            public ulong Seq { get; set; }

            [global::ProtoBuf.ProtoMember(5, Name = @"file_name")]
            [global::System.ComponentModel.DefaultValue("")]
            public string FileName { get; set; } = "";

            [global::ProtoBuf.ProtoMember(6, Name = @"file_type")]
            [global::System.ComponentModel.DefaultValue("")]
            public string FileType { get; set; } = "";

            [global::ProtoBuf.ProtoMember(7, Name = @"md5")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Md5 { get; set; } = "";

            [global::ProtoBuf.ProtoMember(8, Name = @"description")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Description { get; set; } = "";

            [global::ProtoBuf.ProtoMember(9, Name = @"details")]
            public global::System.Collections.Generic.List<byte> Details { get; set; } = new global::System.Collections.Generic.List<byte>();

        }

        [global::ProtoBuf.ProtoContract()]
        internal partial class Metric : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1, Name = @"name")]
            [global::System.ComponentModel.DefaultValue("")]
            public string Name { get; set; } = "";

            [global::ProtoBuf.ProtoMember(2, Name = @"alias")]
            public ulong Alias { get; set; }

            [global::ProtoBuf.ProtoMember(3, Name = @"timestamp")]
            public ulong Timestamp { get; set; }

            [global::ProtoBuf.ProtoMember(4, Name = @"datatype")]
            public uint Datatype { get; set; }

            [global::ProtoBuf.ProtoMember(5, Name = @"is_historical")]
            public bool IsHistorical { get; set; }

            [global::ProtoBuf.ProtoMember(6, Name = @"is_transient")]
            public bool IsTransient { get; set; }

            [global::ProtoBuf.ProtoMember(7, Name = @"is_null")]
            public bool IsNull { get; set; }

            [global::ProtoBuf.ProtoMember(8, Name = @"metadata")]
            public MetaData Metadata { get; set; }

            [global::ProtoBuf.ProtoMember(9, Name = @"properties")]
            public PropertySet Properties { get; set; }

            [global::ProtoBuf.ProtoMember(10, Name = @"int_value")]
            public uint IntValue
            {
                get => __pbn__value.Is(10) ? __pbn__value.UInt32 : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(10, value);
            }
            public bool ShouldSerializeIntValue() => __pbn__value.Is(10);
            public void ResetIntValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 10);

            private global::ProtoBuf.DiscriminatedUnion64Object __pbn__value;

            [global::ProtoBuf.ProtoMember(11, Name = @"long_value")]
            public ulong LongValue
            {
                get => __pbn__value.Is(11) ? __pbn__value.UInt64 : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(11, value);
            }
            public bool ShouldSerializeLongValue() => __pbn__value.Is(11);
            public void ResetLongValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 11);

            [global::ProtoBuf.ProtoMember(12, Name = @"float_value")]
            public float FloatValue
            {
                get => __pbn__value.Is(12) ? __pbn__value.Single : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(12, value);
            }
            public bool ShouldSerializeFloatValue() => __pbn__value.Is(12);
            public void ResetFloatValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 12);

            [global::ProtoBuf.ProtoMember(13, Name = @"double_value")]
            public double DoubleValue
            {
                get => __pbn__value.Is(13) ? __pbn__value.Double : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(13, value);
            }
            public bool ShouldSerializeDoubleValue() => __pbn__value.Is(13);
            public void ResetDoubleValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 13);

            [global::ProtoBuf.ProtoMember(14, Name = @"boolean_value")]
            public bool BooleanValue
            {
                get => __pbn__value.Is(14) ? __pbn__value.Boolean : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(14, value);
            }
            public bool ShouldSerializeBooleanValue() => __pbn__value.Is(14);
            public void ResetBooleanValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 14);

            [global::ProtoBuf.ProtoMember(15, Name = @"string_value")]
            [global::System.ComponentModel.DefaultValue("")]
            public string StringValue
            {
                get => __pbn__value.Is(15) ? ((string)__pbn__value.Object) : "";
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(15, value);
            }
            public bool ShouldSerializeStringValue() => __pbn__value.Is(15);
            public void ResetStringValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 15);

            [global::ProtoBuf.ProtoMember(16, Name = @"bytes_value")]
            public byte[] BytesValue
            {
                get => __pbn__value.Is(16) ? ((byte[])__pbn__value.Object) : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(16, value);
            }
            public bool ShouldSerializeBytesValue() => __pbn__value.Is(16);
            public void ResetBytesValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 16);

            [global::ProtoBuf.ProtoMember(17, Name = @"dataset_value")]
            public DataSet DatasetValue
            {
                get => __pbn__value.Is(17) ? ((DataSet)__pbn__value.Object) : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(17, value);
            }
            public bool ShouldSerializeDatasetValue() => __pbn__value.Is(17);
            public void ResetDatasetValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 17);

            [global::ProtoBuf.ProtoMember(18, Name = @"template_value")]
            public Template TemplateValue
            {
                get => __pbn__value.Is(18) ? ((Template)__pbn__value.Object) : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(18, value);
            }
            public bool ShouldSerializeTemplateValue() => __pbn__value.Is(18);
            public void ResetTemplateValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 18);

            [global::ProtoBuf.ProtoMember(19, Name = @"extension_value")]
            public MetricValueExtension ExtensionValue
            {
                get => __pbn__value.Is(19) ? ((MetricValueExtension)__pbn__value.Object) : default;
                set => __pbn__value = new global::ProtoBuf.DiscriminatedUnion64Object(19, value);
            }
            public bool ShouldSerializeExtensionValue() => __pbn__value.Is(19);
            public void ResetExtensionValue() => global::ProtoBuf.DiscriminatedUnion64Object.Reset(ref __pbn__value, 19);

            public ValueOneofCase ValueCase => (ValueOneofCase)__pbn__value.Discriminator;

            public enum ValueOneofCase
            {
                None = 0,
                IntValue = 10,
                LongValue = 11,
                FloatValue = 12,
                DoubleValue = 13,
                BooleanValue = 14,
                StringValue = 15,
                BytesValue = 16,
                DatasetValue = 17,
                TemplateValue = 18,
                ExtensionValue = 19,
            }

            [global::ProtoBuf.ProtoContract()]
            internal partial class MetricValueExtension : global::ProtoBuf.IExtensible
            {
                private global::ProtoBuf.IExtension __pbn__extensionData;
                global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                    => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

                [global::ProtoBuf.ProtoMember(1, Name = @"details")]
                public global::System.Collections.Generic.List<byte> Details { get; set; } = new global::System.Collections.Generic.List<byte>();

            }

        }
    }
}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
