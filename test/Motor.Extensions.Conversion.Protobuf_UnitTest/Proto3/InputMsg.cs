// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: InputMsg.proto

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;

namespace Motor.Extensions.Conversion.Protobuf_UnitTest
{
    /// <summary>Holder for reflection information generated from InputMsg.proto</summary>
    public static partial class InputMsgReflection
    {
        #region Descriptor

        /// <summary>File descriptor for InputMsg.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }

        private static pbr::FileDescriptor descriptor;

        static InputMsgReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                    "Cg5JbnB1dE1zZy5wcm90bxIeanVtcHN0YXJ0Lm1lc3NhZ2VzLnByb3RvM190",
                    "ZXN0IjsKCElucHV0TXNnEhAKCGZvcmVuYW1lGAEgASgJEhAKCHN1cmVuYW1l",
                    "GAIgASgJEgsKA2FnZRgDIAEoBUIhqgIeSnVtcHN0YXJ0Lk1lc3NhZ2VzLlBy",
                    "b3RvM19UZXN0YgZwcm90bzM="));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { },
                new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[]
                {
                    new pbr::GeneratedClrTypeInfo(
                        typeof(global::Motor.Extensions.Conversion.Protobuf_UnitTest.InputMsg),
                        global::Motor.Extensions.Conversion.Protobuf_UnitTest.InputMsg.Parser,
                        new[] {"Forename", "Surename", "Age"}, null, null, null)
                }));
        }

        #endregion
    }

    #region Messages

    public sealed partial class InputMsg : pb::IMessage<InputMsg>
    {
        /// <summary>Field number for the "forename" field.</summary>
        public const int ForenameFieldNumber = 1;

        /// <summary>Field number for the "surename" field.</summary>
        public const int SurenameFieldNumber = 2;

        /// <summary>Field number for the "age" field.</summary>
        public const int AgeFieldNumber = 3;

        private static readonly pb::MessageParser<InputMsg> _parser =
            new pb::MessageParser<InputMsg>(() => new InputMsg());

        private int age_;
        private string forename_ = "";
        private string surename_ = "";

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public InputMsg()
        {
            OnConstruction();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public InputMsg(InputMsg other) : this()
        {
            forename_ = other.forename_;
            surename_ = other.surename_;
            age_ = other.age_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<InputMsg> Parser
        {
            get { return _parser; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get
            {
                return global::Motor.Extensions.Conversion.Protobuf_UnitTest.InputMsgReflection.Descriptor
                    .MessageTypes[0];
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Forename
        {
            get { return forename_; }
            set { forename_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Surename
        {
            get { return surename_; }
            set { surename_ = pb::ProtoPreconditions.CheckNotNull(value, "value"); }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Age
        {
            get { return age_; }
            set { age_ = value; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public InputMsg Clone()
        {
            return new InputMsg(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(InputMsg other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }

            if (ReferenceEquals(other, this))
            {
                return true;
            }

            if (Forename != other.Forename) return false;
            if (Surename != other.Surename) return false;
            if (Age != other.Age) return false;
            return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (Forename.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteString(Forename);
            }

            if (Surename.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteString(Surename);
            }

            if (Age != 0)
            {
                output.WriteRawTag(24);
                output.WriteInt32(Age);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (Forename.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Forename);
            }

            if (Surename.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeStringSize(Surename);
            }

            if (Age != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeInt32Size(Age);
            }

            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(InputMsg other)
        {
            if (other is null)
            {
                return;
            }

            if (other.Forename.Length != 0)
            {
                Forename = other.Forename;
            }

            if (other.Surename.Length != 0)
            {
                Surename = other.Surename;
            }

            if (other.Age != 0)
            {
                Age = other.Age;
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        input.SkipLastField();
                        break;
                    case 10:
                        {
                            Forename = input.ReadString();
                            break;
                        }
                    case 18:
                        {
                            Surename = input.ReadString();
                            break;
                        }
                    case 24:
                        {
                            Age = input.ReadInt32();
                            break;
                        }
                }
            }
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as InputMsg);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (Forename.Length != 0) hash ^= Forename.GetHashCode();
            if (Surename.Length != 0) hash ^= Surename.GetHashCode();
            if (Age != 0) hash ^= Age.GetHashCode();
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }
    }

    #endregion
}

#endregion Designer generated code
