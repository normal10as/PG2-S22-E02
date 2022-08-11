Imports System

Module Program
    Enum FigurasCartasEspa�olas
        Oro
        Espada
        Basto
        Copa
    End Enum
    Sub Main(args As String())
        ' declaraci�n del tipo numerado
        Dim figura As FigurasCartasEspa�olas
        ' asignaci�n de valor
        figura = FigurasCartasEspa�olas.Oro
        ' obtener valor numerado y representaci�n de cadena
        Console.WriteLine("Figura {0} es {1}", figura.GetHashCode, figura.ToString)
        figura = FigurasCartasEspa�olas.Copa
        Console.WriteLine("Figura {0} es {1}", figura.GetHashCode, figura.ToString)
        Console.WriteLine("�Figura {0} es {1}?: {2}",
                          figura.GetHashCode, FigurasCartasEspa�olas.Espada, figura = FigurasCartasEspa�olas.Espada)
        figura = FigurasCartasEspa�olas.Espada
        Console.WriteLine("�Figura {0} es {1}?: {2}",
                          figura.GetHashCode, FigurasCartasEspa�olas.Espada, figura = FigurasCartasEspa�olas.Espada)

        Dim existe As Boolean
        ' asignar valor num�rico a tipo numerado
        figura = 18
        ' evalua si el valor existe en la enumeraci�n
        existe = [Enum].IsDefined(GetType(FigurasCartasEspa�olas), figura)
        Console.WriteLine("Figura {0} �existe?: {1}", figura, existe)

        figura = 2
        existe = [Enum].IsDefined(GetType(FigurasCartasEspa�olas), figura)
        Console.WriteLine("Figura {0} �existe?: {1}", figura, existe)
        Console.WriteLine("Figura escogida: " & figura & " - " & figura.ToString)
    End Sub
End Module
