﻿using System.Reflection;
using System.Data;
System.Data.DataSet ds;
HttpClient client;

Assembly? myApp = Assembly.GetEntryAssembly();
if(myApp == null) return;
foreach(AssemblyName name in myApp.GetReferencedAssemblies()){
    Assembly a = Assembly.Load(name);
    int methodCount = 0;
    foreach(TypeInfo t in a.DefinedTypes){
        methodCount += t.GetMethods().Count();
    }
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name
    );
}

Console.OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
Console.WriteLine(grinningEmoji);