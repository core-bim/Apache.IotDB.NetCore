/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


namespace Apache.IoTDB.Service.Rpc.Thrift
{

  public partial class TSQueryDataSet : TBase
  {

    public byte[] Time { get; set; }

    public List<byte[]> ValueList { get; set; }

    public List<byte[]> BitmapList { get; set; }

    public TSQueryDataSet()
    {
    }

    public TSQueryDataSet(byte[] time, List<byte[]> valueList, List<byte[]> bitmapList) : this()
    {
      this.Time = time;
      this.ValueList = valueList;
      this.BitmapList = bitmapList;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_time = false;
        bool isset_valueList = false;
        bool isset_bitmapList = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                Time = await iprot.ReadBinaryAsync(cancellationToken);
                isset_time = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  TList _list201 = await iprot.ReadListBeginAsync(cancellationToken);
                  ValueList = new List<byte[]>(_list201.Count);
                  for(int _i202 = 0; _i202 < _list201.Count; ++_i202)
                  {
                    byte[] _elem203;
                    _elem203 = await iprot.ReadBinaryAsync(cancellationToken);
                    ValueList.Add(_elem203);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_valueList = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.List)
              {
                {
                  TList _list204 = await iprot.ReadListBeginAsync(cancellationToken);
                  BitmapList = new List<byte[]>(_list204.Count);
                  for(int _i205 = 0; _i205 < _list204.Count; ++_i205)
                  {
                    byte[] _elem206;
                    _elem206 = await iprot.ReadBinaryAsync(cancellationToken);
                    BitmapList.Add(_elem206);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_bitmapList = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_time)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_valueList)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_bitmapList)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("TSQueryDataSet");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "time";
        field.Type = TType.String;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteBinaryAsync(Time, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "valueList";
        field.Type = TType.List;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, ValueList.Count), cancellationToken);
          foreach (byte[] _iter207 in ValueList)
          {
            await oprot.WriteBinaryAsync(_iter207, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "bitmapList";
        field.Type = TType.List;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, BitmapList.Count), cancellationToken);
          foreach (byte[] _iter208 in BitmapList)
          {
            await oprot.WriteBinaryAsync(_iter208, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as TSQueryDataSet;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return TCollections.Equals(Time, other.Time)
        && TCollections.Equals(ValueList, other.ValueList)
        && TCollections.Equals(BitmapList, other.BitmapList);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + Time.GetHashCode();
        hashcode = (hashcode * 397) + TCollections.GetHashCode(ValueList);
        hashcode = (hashcode * 397) + TCollections.GetHashCode(BitmapList);
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("TSQueryDataSet(");
      sb.Append(", Time: ");
      sb.Append(Time);
      sb.Append(", ValueList: ");
      sb.Append(ValueList);
      sb.Append(", BitmapList: ");
      sb.Append(BitmapList);
      sb.Append(")");
      return sb.ToString();
    }
  }

}
