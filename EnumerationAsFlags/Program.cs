// See https://aka.ms/new-console-template for more information

using EnumerationAsFlagsCs;

FileAttributeEnum fileOne = FileAttributeEnum.System;
FileAttributeEnum fileTwo = FileAttributeEnum.Read | FileAttributeEnum.Executable | FileAttributeEnum.System;   //00001011;

Console.WriteLine(fileOne);
Console.Write("Is Read? ");
Console.WriteLine(fileOne.HasFlag( FileAttributeEnum.Read));
Console.Write("Is System? ");
Console.WriteLine(fileOne.HasFlag( FileAttributeEnum.System));

Console.WriteLine(fileTwo);
Console.Write("Is Folder? ");
Console.WriteLine(fileTwo.HasFlag(FileAttributeEnum.Folder));
Console.Write("Is Read? ");
Console.WriteLine(fileTwo.HasFlag( FileAttributeEnum.Read));
Console.Write("Is System? ");
Console.WriteLine(fileTwo.HasFlag( FileAttributeEnum.System));

Console.WriteLine("Turn off System attribute");
fileTwo -= FileAttributeEnum.System;
Console.WriteLine(fileTwo);
