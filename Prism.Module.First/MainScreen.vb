Imports System.Reflection
Imports Prism.Ioc
Imports Prism.Modularity
Imports Prism.Regions

Public Class MainScreen
    Implements IModule

    Public Sub RegisterTypes(containerRegistry As IContainerRegistry) Implements IModule.RegisterTypes
        containerRegistry.Register(Of ViewMain)
    End Sub

    Public Sub OnInitialized(containerProvider As IContainerProvider) Implements IModule.OnInitialized
        '_regionManager.RegisterViewWithRegion("Screen", GetType(ModuleC))
        Dim region = containerProvider.Resolve(Of IRegionManager)()
        region.RegisterViewWithRegion("MainScreen", GetType(ViewMain))
    End Sub

End Class
