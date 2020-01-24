using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;

namespace Parser.Tests
{
  [TestClass()]
  public class ResponseParserTests
  {
    ResponseParser parser = new ResponseParser();

    [TestMethod()]
    public void ExceptionParseXmlTest()
    {
      Task<Dictionary<char, int>> result = null;
      try
      {
        result = parser.ParseXmlAsync("exceptionTest");
        result.Wait();
      }
      catch (AggregateException)
      { }
      Assert.IsTrue(result.Exception.InnerExceptions[0] is XmlException);
    
    }

    [TestMethod()]
    public void ParserXmlTest()
    {
      var xml = "<?xml version='1.0' encoding='UTF-8'?><record xmlns=\"http://beacon.nist.gov/record/0.1/\"><version>Version 1.0</version><frequency>60</frequency><timeStamp>1463958840</timeStamp><seedValue>12DF33BD97FDAF18F670230F1DC40429CC1D9A126E9CFCA161D261F807F25DC1BE78F83143B336E93755B98DAC2033B7FBC5BE9166BFC17BDA9D6933B0B667A3</seedValue><previousOutputValue>E1A0EF3BFB6DDD4F7DB476C864AEE8F867F5B5DD923A14185803940AAF82F0AF82D5FDECB0D23252213C3CCB8D785C2C2354A0109BACB60B341005CBF38DA533</previousOutputValue><signatureValue>B92A36C07875D09CAB6A3314D0E5EB7823F52C612F0F0143AAA2580C3411AFA6E61396D1AEFB665829D4E64ADF05743D01999CF2D93B7E22B8BA7B5251987457A65A307E9F7EB4C8BF706516DD1C3774079C0702B5738ABF419359247B063B8D6BBD243BA25C19E0C107340EABDE8DB80E6E17E7336B6EB0EDE8CDE721E8AC9DAE7CFF2DF00B9591AF88BFF89939C22CDA6AF2E25D4C34319C9FF9F1CAD3B51C09A5BED552C2C6169BB47D320BCC76BA8442CB61FCC1609425CC7D7270F381090E6F6A79B0863C0D68B6EFFBE52AB12E8DC355997C5004779992431031FDE604BD95DD11A543A92F4348405B9EF69A2833758CBA786E91E17333D983F79C2939</signatureValue><outputValue>AA832BF583E70D2390F9C0AEFEC0FC036404C7F7780A714EDDBF3C46B819FE0C472E8FC0179A2914C56FC8E8260E3EFAD463CB324C350BEB8FBE69974DA0E682</outputValue><statusCode>0</statusCode></record>";
      var result = parser.ParseXmlAsync(xml);
      result.Wait();
      Assert.AreEqual(result.Result.Count, 25);
    }
  }
}