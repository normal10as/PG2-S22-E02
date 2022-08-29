// See https://aka.ms/new-console-template for more information

using EnumerationAsFlagsCs;

FileAttributeEnum fileOne = FileAttributeEnum.System;
FileAttributeEnum fileTwo = FileAttributeEnum.Read | FileAttributeEnum.Executable;

Console.WriteLine(fileOne);
Console.Write("Is Read? ");
Console.WriteLine(fileOne.HasFlag( FileAttributeEnum.Read));
Console.Write("Is System? ");
Console.WriteLine(fileOne.HasFlag( FileAttributeEnum.System));

Console.WriteLine(fileTwo);
Console.Write("Is Read? ");
Console.WriteLine(fileTwo.HasFlag( FileAttributeEnum.Read));
Console.Write("Is System? ");
Console.WriteLine(fileTwo.HasFlag( FileAttributeEnum.System));