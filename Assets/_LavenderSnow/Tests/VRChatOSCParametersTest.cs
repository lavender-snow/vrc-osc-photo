using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using OSCPhoto;
using UnityEngine.TestTools;

public class VRChatOSCParametersTest
{
    [Test]
    public void VRChatOSCParametersTestSimplePasses()
    {
        var fieldNames = typeof(VRChatOSCParameters)
            .GetFields(BindingFlags.Instance | BindingFlags.Public)
            .Select(f => f.Name)
            .OrderBy(n => n)
            .ToArray();

        var enumNames = Enum.GetNames(typeof(VRChatOSCParameter))
            .OrderBy(n => n)
            .ToArray();

        CollectionAssert.AreEqual(enumNames, fieldNames, "enumとクラスのフィールドが一致していません");
    }
}
