Imports System
Imports System.Runtime.InteropServices

Module MainModule
    Sub Main(args As String())
        '�@���A��������\������
        'Class1�^�̃C���X�^���X�𐶐�
        Dim obj1 As New Class1()
        obj1.MonthDisplay()
        '���s
        Console.WriteLine()

        '�A���l����͂��A�����ɂ���ĈقȂ�߂�l���擾
        Console.WriteLine("���l��2����͂��ĉ������B")
        '���͂��ꂽ������^���l��ϐ��Ɋi�[
        Dim input1 As String = Console.ReadLine
        Dim input2 As String = Console.ReadLine

        Try
            '���͂��ꂽ������^���l�𐮐��^�ɕϊ�
            Dim num1 As Integer = Convert.ToInt32(input1)
            Dim num2 As Integer = Convert.ToInt32(input2)
            Dim substruct As Integer
            'Class2�^�̃C���X�^���X�𐶐�
            Dim obj2 As New Class2()
            'num1��num2��substruct�������ɂ���Substruct���\�b�h�����s
            '���ʂ�outcome�Ɋi�[
            Dim outcome = obj2.Substruct(num1, num2, substruct)
            Console.WriteLine(outcome)
        Catch ex As Exception
            '��O����
            Console.WriteLine("�s�K�؂ȓ��͂��s���܂����B" & vbCrLf &
                              "�ēx���l����͂��ĉ������B")
        End Try
        '���s
        Console.WriteLine()

        '�B�v���p�e�B�̎��s����
        '�R���\�[���ւ̓��t���͂𑣂�
        Console.WriteLine("�C�ӂ̓��t���ɕ���ē��͂��ĉ������B" & vbCrLf &
                          "�i��j2024/04/14")
        '�R���\�[���֓��͂����������ϐ��Ɋi�[
        Dim inputDate = Console.ReadLine()

        Try
            '���͂���t�^�ɕϊ�����
            Dim realDate = Date.Parse(inputDate)
            'Class3�^�̃C���X�^���X�𐶐�
            Dim obj3 As New Class3()
            '�����̓��t��DateMonth�v���p�e�B�Ŏ擾
            obj3.DateMonth = realDate
            'DateMonth�v���p�e�B�l�i�����̓��t�j��\������B
            Console.WriteLine("�����̓��t�́A" & obj3.DateMonth & "�ł��B")
            'realDate�̌����������ŕ\������B
            Console.WriteLine("���͂������t�̌��̋�������" & obj3.GetMonthName() & "�ł��B")
        Catch ex As Exception
            Console.WriteLine("���������t�ɕϊ��o���܂���ł����B")
        End Try
        '���s
        Console.WriteLine()

        '�C��ƒ��̃f�B���N�g����\������
        'Class4�^�̃C���X�^���X�𐶐�����
        Dim obj4 As New Class4()
        '�ϐ���GetCurrentDirectory���\�b�h�Ŏ擾�����p�X���i�[
        Dim path As String = obj4.GetCurrentDirectory()
        '�R���\�[���ɕ\������
        Console.WriteLine("��ƒ��f�B���N�g��:{0}", path)
    End Sub
End Module
