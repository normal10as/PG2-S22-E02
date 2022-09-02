Module Program
    Sub Main(args As String())
        Dim fileOne As FileAttributeEnum = FileAttributeEnum.Folder

        Console.WriteLine(fileOne.ToString)
        Console.Write("Is System? ")
        Console.WriteLine(fileOne.HasFlag(FileAttributeEnum.System))
        Console.Write("Is Folder? ")
        Console.WriteLine(fileOne.HasFlag(FileAttributeEnum.Folder))

        Dim fileTwo As FileAttributeEnum = FileAttributeEnum.Read Or FileAttributeEnum.Executable Or FileAttributeEnum.System   '00001011
        Console.WriteLine(fileTwo.ToString)
        Console.Write("Is Folder? ")
        Console.WriteLine(fileTwo.HasFlag(FileAttributeEnum.Folder))
        Console.Write("Is Read? ")
        Console.WriteLine(fileTwo.HasFlag(FileAttributeEnum.Read))
        Console.Write("Is System? ")
        Console.WriteLine(fileTwo.HasFlag(FileAttributeEnum.System))
    End Sub
End Module
