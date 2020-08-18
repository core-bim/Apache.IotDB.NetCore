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


namespace Apache.IoTDB.Cluster.Rpc.Thrift
{

  public partial class GetAggrResultRequest : TBase
  {
    private byte[] _timeFilterBytes;

    public string Path { get; set; }

    public List<string> Aggregations { get; set; }

    public int DataTypeOrdinal { get; set; }

    public byte[] TimeFilterBytes
    {
      get
      {
        return _timeFilterBytes;
      }
      set
      {
        __isset.timeFilterBytes = true;
        this._timeFilterBytes = value;
      }
    }

    public Node Header { get; set; }

    public long QueryId { get; set; }

    public Node Requestor { get; set; }

    public THashSet<string> DeviceMeasurements { get; set; }


    public Isset __isset;
    public struct Isset
    {
      public bool timeFilterBytes;
    }

    public GetAggrResultRequest()
    {
    }

    public GetAggrResultRequest(string path, List<string> aggregations, int dataTypeOrdinal, Node header, long queryId, Node requestor, THashSet<string> deviceMeasurements) : this()
    {
      this.Path = path;
      this.Aggregations = aggregations;
      this.DataTypeOrdinal = dataTypeOrdinal;
      this.Header = header;
      this.QueryId = queryId;
      this.Requestor = requestor;
      this.DeviceMeasurements = deviceMeasurements;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_path = false;
        bool isset_aggregations = false;
        bool isset_dataTypeOrdinal = false;
        bool isset_header = false;
        bool isset_queryId = false;
        bool isset_requestor = false;
        bool isset_deviceMeasurements = false;
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
                Path = await iprot.ReadStringAsync(cancellationToken);
                isset_path = true;
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
                  TList _list29 = await iprot.ReadListBeginAsync(cancellationToken);
                  Aggregations = new List<string>(_list29.Count);
                  for(int _i30 = 0; _i30 < _list29.Count; ++_i30)
                  {
                    string _elem31;
                    _elem31 = await iprot.ReadStringAsync(cancellationToken);
                    Aggregations.Add(_elem31);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_aggregations = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                DataTypeOrdinal = await iprot.ReadI32Async(cancellationToken);
                isset_dataTypeOrdinal = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                TimeFilterBytes = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Struct)
              {
                Header = new Node();
                await Header.ReadAsync(iprot, cancellationToken);
                isset_header = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.I64)
              {
                QueryId = await iprot.ReadI64Async(cancellationToken);
                isset_queryId = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.Struct)
              {
                Requestor = new Node();
                await Requestor.ReadAsync(iprot, cancellationToken);
                isset_requestor = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.Set)
              {
                {
                  TSet _set32 = await iprot.ReadSetBeginAsync(cancellationToken);
                  DeviceMeasurements = new THashSet<string>(_set32.Count);
                  for(int _i33 = 0; _i33 < _set32.Count; ++_i33)
                  {
                    string _elem34;
                    _elem34 = await iprot.ReadStringAsync(cancellationToken);
                    DeviceMeasurements.Add(_elem34);
                  }
                  await iprot.ReadSetEndAsync(cancellationToken);
                }
                isset_deviceMeasurements = true;
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
        if (!isset_path)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_aggregations)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_dataTypeOrdinal)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_header)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_queryId)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_requestor)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_deviceMeasurements)
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
        var struc = new TStruct("GetAggrResultRequest");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "path";
        field.Type = TType.String;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(Path, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "aggregations";
        field.Type = TType.List;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, Aggregations.Count), cancellationToken);
          foreach (string _iter35 in Aggregations)
          {
            await oprot.WriteStringAsync(_iter35, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "dataTypeOrdinal";
        field.Type = TType.I32;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async(DataTypeOrdinal, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if (TimeFilterBytes != null && __isset.timeFilterBytes)
        {
          field.Name = "timeFilterBytes";
          field.Type = TType.String;
          field.ID = 4;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(TimeFilterBytes, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        field.Name = "header";
        field.Type = TType.Struct;
        field.ID = 5;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await Header.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "queryId";
        field.Type = TType.I64;
        field.ID = 6;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(QueryId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "requestor";
        field.Type = TType.Struct;
        field.ID = 7;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await Requestor.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "deviceMeasurements";
        field.Type = TType.Set;
        field.ID = 8;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteSetBeginAsync(new TSet(TType.String, DeviceMeasurements.Count), cancellationToken);
          foreach (string _iter36 in DeviceMeasurements)
          {
            await oprot.WriteStringAsync(_iter36, cancellationToken);
          }
          await oprot.WriteSetEndAsync(cancellationToken);
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
      var other = that as GetAggrResultRequest;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Path, other.Path)
        && TCollections.Equals(Aggregations, other.Aggregations)
        && System.Object.Equals(DataTypeOrdinal, other.DataTypeOrdinal)
        && ((__isset.timeFilterBytes == other.__isset.timeFilterBytes) && ((!__isset.timeFilterBytes) || (TCollections.Equals(TimeFilterBytes, other.TimeFilterBytes))))
        && System.Object.Equals(Header, other.Header)
        && System.Object.Equals(QueryId, other.QueryId)
        && System.Object.Equals(Requestor, other.Requestor)
        && TCollections.Equals(DeviceMeasurements, other.DeviceMeasurements);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + Path.GetHashCode();
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Aggregations);
        hashcode = (hashcode * 397) + DataTypeOrdinal.GetHashCode();
        if(__isset.timeFilterBytes)
          hashcode = (hashcode * 397) + TimeFilterBytes.GetHashCode();
        hashcode = (hashcode * 397) + Header.GetHashCode();
        hashcode = (hashcode * 397) + QueryId.GetHashCode();
        hashcode = (hashcode * 397) + Requestor.GetHashCode();
        hashcode = (hashcode * 397) + TCollections.GetHashCode(DeviceMeasurements);
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("GetAggrResultRequest(");
      sb.Append(", Path: ");
      sb.Append(Path);
      sb.Append(", Aggregations: ");
      sb.Append(Aggregations);
      sb.Append(", DataTypeOrdinal: ");
      sb.Append(DataTypeOrdinal);
      if (TimeFilterBytes != null && __isset.timeFilterBytes)
      {
        sb.Append(", TimeFilterBytes: ");
        sb.Append(TimeFilterBytes);
      }
      sb.Append(", Header: ");
      sb.Append(Header== null ? "<null>" : Header.ToString());
      sb.Append(", QueryId: ");
      sb.Append(QueryId);
      sb.Append(", Requestor: ");
      sb.Append(Requestor== null ? "<null>" : Requestor.ToString());
      sb.Append(", DeviceMeasurements: ");
      sb.Append(DeviceMeasurements);
      sb.Append(")");
      return sb.ToString();
    }
  }

}