﻿'  Copyright (c) Microsoft Corporation. All rights reserved.

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------



<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),
 System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ICalculatorContract")> _
Public Interface ICalculatorContract

    <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ICalculatorContract/Add",
                                                    ReplyAction:="http://tempuri.org/ICalculatorContract/AddResponse")> _
    Function Add(ByVal x As Integer, ByVal y As Integer, ByVal clientTransactionId As Guid) As Integer
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Public Interface ICalculatorContractChannel
	Inherits ICalculatorContract, System.ServiceModel.IClientChannel
End Interface

<DebuggerStepThroughAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Partial Public Class CalculatorContractClient
	Inherits System.ServiceModel.ClientBase(Of ICalculatorContract)
	Implements ICalculatorContract

	Public Sub New()
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String)
		MyBase.New(endpointConfigurationName)
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
		MyBase.New(endpointConfigurationName, remoteAddress)
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
		MyBase.New(endpointConfigurationName, remoteAddress)
	End Sub

    Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding,
                   ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(binding, remoteAddress)
    End Sub

    Public Function Add(ByVal x As Integer,
                        ByVal y As Integer, ByVal clientTransactionId As Guid) As Integer Implements ICalculatorContract.Add
        Return MyBase.Channel.Add(x, y, clientTransactionId)
    End Function
End Class

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"),
System.ServiceModel.ServiceContractAttribute(ConfigurationName:="IDatagramContract")> _
Public Interface IDatagramContract

    <System.ServiceModel.OperationContractAttribute(IsOneWay:=True,
                                                    Action:="http://tempuri.org/IDatagramContract/Hello")> _
    Sub Hello()
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Public Interface IDatagramContractChannel
	Inherits IDatagramContract, System.ServiceModel.IClientChannel
End Interface

<DebuggerStepThroughAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Partial Public Class DatagramContractClient
	Inherits System.ServiceModel.ClientBase(Of IDatagramContract)
	Implements IDatagramContract

	Public Sub New()
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String)
		MyBase.New(endpointConfigurationName)
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
		MyBase.New(endpointConfigurationName, remoteAddress)
	End Sub

    Public Sub New(ByVal endpointConfigurationName As String,
                   ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(endpointConfigurationName, remoteAddress)
    End Sub

    Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding,
                   ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(binding, remoteAddress)
    End Sub

	Public Sub Hello() Implements IDatagramContract.Hello
		MyBase.Channel.Hello()
	End Sub
End Class