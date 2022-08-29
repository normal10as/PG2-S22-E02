<Flags()>
Public Enum FileAttributeEnum
    System = 1              ' 1     00000001
    Read = 1 << 1           ' 2     00000010
    Write = 1 << 2          ' 4     00000100
    Executable = 1 << 3     ' 8     00001000
    Hidden = 1 << 4         ' 16    00010000
    Folder = 1 << 5         ' 32    00100000
End Enum
